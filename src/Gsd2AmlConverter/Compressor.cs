using System.CodeDom;
using System.IO;

namespace Gsd2AmlConverter
{
    public class Compressor
    {
        public void Compress()
        {

        }

        /// <summary>
        /// Creates a new directory in user/tmp.
        /// </summary>
        /// <param name="folderName">The folder to be created.</param>
        /// <returns>The path to the directory as a string.</returns>
        /// <exception cref="IOException"></exception>
        private string createTMPDirectory(string folderName)
        {
            try
            {
                return Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), folderName)).FullName;
            }
            catch (IOException)
            {
                throw new IOException();
            }
        }

        /// <summary>
        /// Moves a file from one directory to another.
        /// </summary>
        /// <param name="source">The source path.</param>
        /// <param name="destination">The destination path.</param>
        /// <param name="newFileName">The new file name.</param>
        /// <exception cref="IOException"></exception>
        private void moveFile(string source, string destination, string newFileName)
        {
            try
            {
                File.Move(source, Path.Combine(destination, newFileName));
            }
            catch (IOException)
            {
                throw;
            }
        }
    }
}
