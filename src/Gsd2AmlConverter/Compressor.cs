using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Gsd2AmlConverter
{
    public class Compressor
    {
        // TODO: .NET doc
        public void Compress(string amlFilePath)
        {

        }

        /// <summary>
        /// Creates a zip archive from a directory.
        /// </summary>
        /// <param name="source">The directory you want to be zipped.</param>
        /// <param name="destination">The directory you want to store the archive in.</param>
        /// <exception cref="IOException"></exception>
        private void zip(string source, string destination)
        {
            try
            {
                ZipFile.CreateFromDirectory(source, destination);
            }
            catch (IOException)
            {
                // TODO: Wait for logger module.
                throw;
            }
        }

        /// <summary>
        /// Parses the gsd object for external resources and makes a list out of them.
        /// </summary>
        /// <param name="gsd">The gsd object to be parsed.</param>
        /// <returns>A list of external resources.</returns>
        private List<string> ParseGsdForResources()
        {
            List<string> resources = new List<string>();

            // TODO: Parse the GSD

            return resources;
        }

        /// <summary>
        /// Creates a new directory in user/tmp.
        /// </summary>
        /// <param name="folderName">The folder to be created.</param>
        /// <returns>The path to the directory as a string.</returns>
        /// <exception cref="IOException"></exception>
        private string CreateTmpDirectory(string folderName)
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
        private void MoveFile(string source, string destination, string newFileName)
        {
            try
            {
                File.Move(source, Path.Combine(destination, newFileName));
            }
            catch (IOException)
            {
                // TODO: Wait for logger module.
                throw;
            }
        }
    }
}
