using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Gsd2AmlConverter
{
    public class Compressor
    {

        const string GSD2AML_NAME = "GSD2AML";

        /// <summary>
        /// Creates a zip archive from a directory and the relevant GSD ressources.
        /// </summary>
        /// <param name="aml">The aml file you want to be zipped.</param>
        /// <param name="destination">The directory you want to store the archive in.</param>
        /// <param name="ressources">An array of paths to ressources to be part of the AMLX package.</param>
        /// <exception cref="IOException"></exception>
        public void Compress(string aml, string destination, string amlx_name, string[] ressources)
        {
            string tmp_path = CreateTmpDirectory(GSD2AML_NAME);

            try
            {
                foreach (string ressource in ressources)
                {
                    MoveFile(ressource, tmp_path);
                }
                MoveFile(aml, tmp_path);

                Zip(tmp_path, Path.Combine(destination, amlx_name));

                DelteFolder(tmp_path);
            }
            catch (IOException)
            {
                // TODO: Wait for logger module.
            }
        }

        /// <summary>
        /// Creates a zip archive from a directory.
        /// </summary>
        /// <param name="source">The directory you want to be zipped.</param>
        /// <param name="destination">The directory you want to store the archive in.</param>
        /// <exception cref="IOException"></exception>
        private void Zip(string source, string destination)
        {
            try
            {
                ZipFile.CreateFromDirectory(source, destination);
            }
            catch (IOException)
            {
                // TODO: Wait for logger module.
            }
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
        private void MoveFile(string source, string destination)
        {
            try
            {
                File.Move(source, destination);
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
        private void DelteFolder(string target)
        {
            try
            {
                if (Directory.Exists(target))
                {
                    Directory.Delete(target);
                }
            }
            catch (IOException)
            {
                // TODO: Wait for logger module.
            }
        }
    }
}
