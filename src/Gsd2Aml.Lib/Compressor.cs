﻿using Gsd2Aml.Lib.Logging;
using System;
using System.IO;
using System.IO.Compression;

namespace Gsd2Aml.Lib
{
    public class Compressor
    {
        private const string Gsd2AmlName = "GSD2AML";

        /// <summary>
        /// Creates a zip archive from a directory and the relevant GSD ressources.
        /// </summary>
        /// <param name="aml">The AML file which will be zipped.</param>
        /// <param name="destination">The directory you want to store the archive in including the name of the archive.amlx.</param>
        /// <param name="ressources">An array of paths to the ressources to be part of the AMLX package.</param>
        /// <exception cref="IOException"></exception>
        public static void Compress(string aml, string destination, string[] ressources)
        {
            var tmpPath = CreateTmpDirectory(Gsd2AmlName);

            try
            {
                foreach (var ressource in ressources)
                {
                    var fileName = Path.GetFileName(ressource);
                    if (fileName != null) CopyFile(ressource, Path.Combine(tmpPath, fileName));
                }

                var amlFileName = Path.GetFileName(aml);
                if (amlFileName != null) CopyFile(aml, Path.Combine(tmpPath, amlFileName));

                Zip(tmpPath, destination);
                Util.Logger.Log(LogLevel.Info, $"Successfully saved AMLX package to {destination}.");

                DeleteFolder(tmpPath);
            }
            catch (IOException e)
            {
                Util.Logger.Log(LogLevel.Error, e.Message);
                Util.Logger.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Error while compressing the AML-file and the ressources to the .amlx file.");
            }
        }

        /// <summary>
        /// Creates a zip archive from a directory.
        /// </summary>
        /// <param name="source">The directory you want to be zipped.</param>
        /// <param name="destination">The directory you want to store the zip archive in.</param>
        /// <exception cref="IOException"></exception>
        private static void Zip(string source, string destination)
        {
            try
            {
                ZipFile.CreateFromDirectory(source, destination);
            }
            catch (IOException e)
            {
                Util.Logger.Log(LogLevel.Error, e.Message);
                Util.Logger.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not create the .amlx compressed file.");
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
                return Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), folderName)).FullName;
            }
            catch (IOException e)
            {
                Util.Logger.Log(LogLevel.Error, e.Message);
                Util.Logger.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not create the the temporary directory which was created to compress the .amlx file.");
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
                Util.Logger.Log(LogLevel.Error, e.Message);
                Util.Logger.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not copy a resource file to the temporary directory which was created to compress the .amlx file.");
            }
        }

        /// <summary>
        /// Deletes a folder if it exists.
        /// </summary>
        /// <param name="target">The target path.</param>
        /// <exception cref="IOException"></exception>
        private static void DeleteFolder(string target)
        {
            try
            {
                if (Directory.Exists(target))
                {
                    Directory.Delete(target, true);
                }
            }
            catch (IOException e)
            {
                Util.Logger.Log(LogLevel.Error, e.Message);
                Util.Logger.Log(LogLevel.Trace, e.StackTrace);
                throw new Exception("Could not delete the temporary directory which was created to compress the .amlx file.");
            }
        }
    }
}
