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
        /// <param name="aml">The aml file you want to be zipped.</param>
        /// <param name="destination">The directory you want to store the archive in.</param>
        /// <param name="amlxName"></param>
        /// <param name="ressources">An array of paths to ressources to be part of the AMLX package.</param>
        /// <exception cref="IOException"></exception>
        public static string Compress(string aml, string destination, string amlxName, string[] ressources)
        {
            var tmpPath = CreateTmpDirectory(Gsd2AmlName);

            try
            {
                foreach (var ressource in ressources)
                {
                    var fileName = Path.GetFileName(ressource);
                    CopyFile(ressource, Path.Combine(tmpPath, fileName));
                }
                var amlFileName = Path.GetFileName(aml);
                CopyFile(aml, Path.Combine(tmpPath, amlFileName));

                Zip(tmpPath, Path.Combine(destination, amlxName));

                DelteFolder(tmpPath);

                return Path.Combine(destination, amlxName);
            }
            catch (IOException)
            {
                throw;
                // TODO: Wait for logger module.
            }
            return string.Empty;
        }

        /// <summary>
        /// Creates a zip archive from a directory.
        /// </summary>
        /// <param name="source">The directory you want to be zipped.</param>
        /// <param name="destination">The directory you want to store the archive in.</param>
        /// <exception cref="IOException"></exception>
        private static void Zip(string source, string destination)
        {
            try
            {
                ZipFile.CreateFromDirectory(source, destination);
            }
            catch (IOException)
            {
                throw;
                // TODO: Wait for logger module.
            }
        }

        /// <summary>
        /// Creates a new directory in user/tmp.
        /// </summary>
        /// <param name="folderName">The folder to be created.</param>
        /// <returns>The path to the directory as a string.</returns>
        /// <exception cref="IOException"></exception>
        private static string CreateTmpDirectory(string folderName)
        {
            try
            {
                return Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), folderName)).FullName;
            }
            catch (IOException)
            {
                // TODO: Wait for logger module.
                throw;
            }
        }

        /// <summary>
        /// Moves a file from one directory to another.
        /// </summary>
        /// <param name="source">The source path.</param>
        /// <param name="destination">The destination path.</param>
        /// <param name="newFileName">The new file name.</param>
        /// <exception cref="IOException"></exception>
        private static void CopyFile(string source, string destination)
        {
            try
            {
                File.Copy(source, destination, true);
            }
            catch (IOException)
            {
                // TODO: Wait for logger module.
            }
        }

        /// <summary>
        /// Deletes a folder if it exists.
        /// </summary>
        /// <param name="target">The target path.</param>
        /// <exception cref="IOException"></exception>
        private static void DelteFolder(string target)
        {
            try
            {
                if (Directory.Exists(target))
                {
                    Directory.Delete(target, true);
                }
            }
            catch (IOException)
            {
                throw;
                // TODO: Wait for logger module.
            }
        }
    }
}
