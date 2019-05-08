using Gsd2Aml.Lib.Logging;
using System;
using System.IO;
using System.IO.Compression;
using Aml.Engine;

namespace Gsd2Aml.Lib
{
    public static class Compressor
    {
        private const string Gsd2AmlName = "GSD2AML";

        /// <summary>
        /// Creates a zip archive from a directory and the relevant GSD ressources.
        /// </summary>
        /// <param name="amlFilePath">The path to the AML file which will be zipped.</param>
        /// <param name="destination">The directory you want to store the archive in including the name of the archive.amlx.</param>
        /// <param name="ressources">An array of paths to the ressources to be part of the .amlx package.</param>
        /// <param name="overwriteFile">A flag which indicates if the file should be overwritten if it exists.</param>
        /// <exception cref="IOException"></exception>
        public static void Compress(string amlFilePath, string destination, string[] ressources, bool overwriteFile = false)
        {
            if (amlFilePath.Equals("") || destination.Equals(""))
            {
                Util.Logger?.Log(LogLevel.Error, "The AML or destination string cant be omitted.");
                throw new Exception("AML or destination string was omitted.");
            }

            var tmpPath = CreateTmpDirectory(Gsd2AmlName);

            if (String.IsNullOrEmpty(tmpPath))
            {
                Util.Logger?.Log(LogLevel.Error, "Path to Temp folder is unexpectedly null.");
                throw new Exception("Path to Temp folder unexpectedly null.");
            }

            try
            {
                foreach (var ressource in ressources)
                {
                    var fileName = Path.GetFileName(ressource);
                    if (fileName != null) CopyFile(ressource, Path.Combine(tmpPath, fileName));
                }

                var amlFileName = Path.GetFileName(amlFilePath);
                var amlFileTmpPath = Path.Combine(tmpPath, amlFileName);

                if (amlFileName != null) CopyFile(amlFilePath, amlFileTmpPath);

                Zip(amlFileTmpPath, destination, ressources, overwriteFile);
                Util.Logger?.Log(LogLevel.Info, $"Successfully saved AMLX package to {destination}.");

                DeleteFolder(tmpPath);
            }
            catch (IOException e)
            {
                Util.Logger?.Log(LogLevel.Error, e.Message);
                Util.Logger?.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Error while compressing the AML-file and the ressources to the .amlx file.", e);
            }
        }

        /// <summary>
        /// Creates a zip archive from a directory.
        /// </summary>
        /// <param name="source">The directory you want to be zipped.</param>
        /// <param name="destination">The directory you want to store the zip archive in.</param>
        /// <param name="overwriteFile">A flag which indicates if the file should be overwritten if it exists.</param>
        /// <exception cref="Exception"></exception>
        private static void Zip(string sourceAML, string destination, string[] ressources, bool overwriteFile)
        {
            if (overwriteFile)
            {
                File.Delete(destination);
            }

            try
            {
                using (Aml.Engine.AmlObjects.AutomationMLContainer ac = new Aml.Engine.AmlObjects.AutomationMLContainer(destination))
                {
                    var root = ac.AddRoot(sourceAML, new Uri("/" + Path.GetFileName(sourceAML), UriKind.Relative));

                    foreach (var ressource in ressources)
                    {
                        var fileName = Path.GetFileName(ressource);
                        if (fileName != null)
                        {
                            ac.AddAnyContent(
                                root,
                                Path.Combine(Path.GetTempPath(), Gsd2AmlName, fileName),
                                new Uri("/" + fileName, UriKind.Relative));
                        }
                    }

                    ac.Save();
                    ac.Close();
                }
            }
            catch (Exception e)
            {
                Util.Logger?.Log(LogLevel.Error, e.Message);
                Util.Logger?.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not create the .amlx compressed file.", e);
            }
        }

        /// <summary>
        /// Creates a new directory in the temporary folder of Windows.
        /// </summary>
        /// <param name="folderName">The name of the folder to be created.</param>
        /// <returns>The path to the directory as a string.</returns>
        /// <exception cref="IOException"></exception>
        private static string CreateTmpDirectory(string folderName)
        {
            try
            {
                var path = Path.Combine(Path.GetTempPath(), folderName);
                return CreateDirectory(path);
            }
            catch (IOException e)
            {
                Util.Logger?.Log(LogLevel.Error, e.Message);
                Util.Logger?.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not create the the temporary directory which was created to compress the .amlx file.", e);
            }
        }

        /// <summary>
        /// Moves a file from one directory to another.
        /// </summary>
        /// <param name="source">The source path.</param>
        /// <param name="destination">The destination path.</param>
        /// <exception cref="IOException"></exception>
        private static void CopyFile(string source, string destination)
        {
            try
            {
                File.Copy(source, destination, true);
            }
            catch (IOException e)
            {
                Util.Logger?.Log(LogLevel.Error, e.Message);
                Util.Logger?.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not copy a resource file to the temporary directory which was created to compress the .amlx file.", e);
            }
        }

        /// <summary>
        /// Deletes a folder if it exists.
        /// </summary>
        /// <param name="destination">The destination path.</param>
        /// <exception cref="IOException"></exception>
        private static void DeleteFolder(string destination)
        {
            try
            {
                if (Directory.Exists(destination))
                {
                    Directory.Delete(destination, true);
                }
            }
            catch (IOException e)
            {
                Util.Logger?.Log(LogLevel.Error, e.Message);
                Util.Logger?.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not delete the temporary directory which was created to compress the .amlx file.", e);
            }
        }

        /// <summary>
        /// Creates a directory path.
        /// </summary>
        /// <param name="destination">The directory path.</param>
        /// <exception cref="Exception"></exception>
        private static string CreateDirectory(string destination)
        {
            var output = new DirectoryInfo(destination);

            if (output == null || output.Exists)
            {
                if (output.Exists) return output.FullName;
                return null;
            }

            try
            {
                return Directory.CreateDirectory(output.FullName).FullName;
            }
            catch (Exception e)
            {
                Util.Logger?.Log(LogLevel.Error, e.Message);
                Util.Logger?.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not create output directory for destination");
            }
        }
    }
}
