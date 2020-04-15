/*
 *  Copyright (C) 2019 GSD2AML Team (Nico Dietz, Steffen Gerdes, Constantin Ruhdorfer,
 *  Jonas Komarek, Phuc Quang Vu, Michael Weidmann)
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as published by
 *  the Free Software Foundation version 3 of the License.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Affero General Public License for more details.
 *
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Gsd2Aml.Lib.Logging;
using System;
using System.Collections.Generic;
using System.IO;

namespace Gsd2Aml.Lib
{
    /// <summary>
    /// Compress an AML file and its resources to an .amlx package using the AML.Engine.
    /// </summary>
    public static class Compressor
    {
        private const string Gsd2AmlName = "GSD2AML";

        /// <summary>
        /// Creates a zip archive from a directory and the relevant GSD resources.
        /// </summary>
        /// <param name="amlFilePath">The path to the AML file which will be zipped.</param>
        /// <param name="destination">The directory you want to store the archive in including the name of the archive.amlx.</param>
        /// <param name="resources">An array of paths to the resources to be part of the .amlx package.</param>
        /// <param name="overwriteFile">A flag which indicates if the file should be overwritten if it exists.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="Exception"></exception>
        public static void Compress(string amlFilePath, string destination, string[] resources, bool overwriteFile = false)
        {
            if (string.IsNullOrEmpty(amlFilePath)) throw new ArgumentNullException(amlFilePath, "AML file path was null or empty.");
            if (string.IsNullOrEmpty(destination)) throw new ArgumentNullException(destination, "Destination file path was null or empty.");

            var tmpPath = CreateTmpDirectory(Gsd2AmlName);

            if (string.IsNullOrEmpty(tmpPath)) throw new IOException("Path to GSD2AML-Temp folder unexpectedly null or empty.");

            var amlFileName = Path.GetFileName(amlFilePath);
            if (string.IsNullOrEmpty(amlFileName)) throw new IOException("AML filename unexpectedly null or empty.");

            var amlFileTmpPath = Path.Combine(tmpPath, amlFileName);
            if (string.IsNullOrEmpty(amlFileTmpPath)) throw new IOException("Path to AML file in TMP directory unexpectedly null or empty.");

            try
            {
                foreach (var resource in resources)
                {
                    var fileName = Path.GetFileName(resource);
                    if (string.IsNullOrEmpty(fileName))
                    {
                        Converter.Logger?.Log(LogLevel.Warning, "While copying a null or empty filename was found - skipping.");
                    }
                    else
                    {
                        try
                        {
                            CopyFile(resource, Path.Combine(tmpPath, fileName));
                        }
                        catch (FileNotFoundException)
                        {
                            Converter.Logger?.Log(LogLevel.Warning, $"While trying to copy {fileName} the file was not found - skipping.");
                        }
                        catch (DirectoryNotFoundException)
                        {
                            Converter.Logger?.Log(LogLevel.Warning, $"While trying to copy {resource} the directory was not found - skipping.");
                        }
                    }
                }

                if (!string.IsNullOrEmpty(amlFileName)) CopyFile(amlFilePath, amlFileTmpPath);

                Zip(amlFileTmpPath, destination, resources, overwriteFile);

                Converter.Logger?.Log(LogLevel.Info,
                    $"Successfully saved .amlx package {Path.GetFileName(destination)} to {destination}.");

                DeleteFolder(tmpPath);
            }
            catch (IOException e)
            {
                throw new IOException("Error while compressing the AML and resource files to the .amlx package.", e);
            }
            catch (Exception e)
            {
                throw new Exception("An exception occured while compressing the AML and resource files to the .amlx package.", e);
            }
        }

        /// <summary>
        /// Creates a zip archive from a directory.
        /// </summary>
        /// <param name="sourceAml">The directory you want to be zipped.</param>
        /// <param name="destination">The directory you want to store the zip archive in.</param>
        /// <param name="resources">An array of paths to the resources to be part of the .amlx package.</param>
        /// <param name="overwriteFile">A flag which indicates if the file should be overwritten if it exists.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="Exception"></exception>
        private static void Zip(string sourceAml, string destination, IEnumerable<string> resources, bool overwriteFile)
        {
            if (string.IsNullOrEmpty(sourceAml)) throw new ArgumentNullException(sourceAml, "Source Aml was null or empty.");
            if (string.IsNullOrEmpty(destination)) throw new ArgumentNullException(destination, "Destination was null or empty.");
            if (overwriteFile)
            {
                File.Delete(destination);
            }
            else if (File.Exists(destination))
            {
                throw new IOException("Could not create the .amlx compressed file because the file should not be overwritten.");
            }

            try
            {
                using (var ac = new Aml.Engine.AmlObjects.AutomationMLContainer(destination))
                {
                    var root = ac.AddRoot(sourceAml, new Uri("/" + Path.GetFileName(sourceAml), UriKind.Relative));

                    foreach (var resource in resources)
                    {
                        var fileName = Path.GetFileName(resource);
                        if (string.IsNullOrEmpty(fileName)) continue;
                        var fileTmpPath = Path.Combine(Path.GetTempPath(), Gsd2AmlName, fileName);
                        if (!File.Exists(fileTmpPath)) continue;
                        var fileUri = new Uri("/" + fileName, UriKind.Relative);
                        ac.AddAnyContent(root, fileTmpPath, fileUri);
                    }
                    ac.Close();
                }
            }
            catch (IOException e)
            {
                throw new IOException("Could not create the .amlx package while using the AutomationML container.", e);
            }
            catch (Exception e)
            {
                throw new Exception("An exception occured while creating the .amlx package while using the AutomationML container.", e);
            }
        }

        /// <summary>
        /// Creates a new directory in the temporary folder of Windows.
        /// </summary>
        /// <param name="folderName">The name of the folder to be created.</param>
        /// <returns>The path to the directory as a string.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="Exception"></exception>
        private static string CreateTmpDirectory(string folderName)
        {
            if (string.IsNullOrEmpty(folderName)) throw new ArgumentNullException(folderName, "Folder name was null or empty.");
            try
            {
                var path = Path.Combine(Path.GetTempPath(), folderName);
                return CreateDirectory(path);
            }
            catch (PathTooLongException e)
            {
                throw new PathTooLongException("Could not create TMP directory for creating the .amlx package because the path was too long.", e);
            }
            catch (IOException e)
            {
                throw new IOException("Could not create the the temporary directory which was created to compress the .amlx package.", e);
            }
            catch (UnauthorizedAccessException e)
            {
                throw new UnauthorizedAccessException("Could not create TMP directory for creating the .amlx package because of unauthorized access.", e);
            }
            catch (Exception e)
            {
                throw new Exception("An exception occured while creating the TMP directory for creating the .amlx package.", e);
            }
        }

        /// <summary>
        /// Moves a file from one directory to another.
        /// </summary>
        /// <param name="source">The source path.</param>
        /// <param name="destination">The destination path.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="Exception"></exception>
        private static void CopyFile(string source, string destination)
        {
            if (string.IsNullOrEmpty(source)) throw new ArgumentNullException(source, "Source was null or empty.");
            if (string.IsNullOrEmpty(destination)) throw  new ArgumentNullException(destination, "Destination was null or empty.");
            try
            {
                File.Copy(source, destination, true);
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }
            catch (PathTooLongException e)
            {
                throw new PathTooLongException("Could not copy the file because a path was too long.", e);
            }
            catch (IOException e)
            {
                throw new IOException("Could not copy a file to the temporary directory which was created to compress the .amlx package.", e);
            }
            catch (UnauthorizedAccessException e)
            {
                throw new UnauthorizedAccessException("Could not copy a file because of unauthorized access.", e);
            }
            catch (Exception e)
            {
                throw new Exception("An exception occured while copying a file.", e);
            }
        }

        /// <summary>
        /// Deletes a folder if it exists.
        /// </summary>
        /// <param name="destination">The destination path.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="Exception"></exception>
        private static void DeleteFolder(string destination)
        {
            if (string.IsNullOrEmpty(destination)) throw new ArgumentNullException(destination, "Destination was null or empty");
            try
            {
                if (Directory.Exists(destination))
                {
                    Directory.Delete(destination, true);
                }
            }
            catch (PathTooLongException e)
            {
                throw new PathTooLongException("Could not delete the directory because the path was too long.", e);
            }
            catch (IOException e)
            {
                throw new IOException("Could not delete the directory which was created to compress the .amlx package.", e);
            }
            catch (UnauthorizedAccessException e)
            {
                throw new UnauthorizedAccessException("Could not delete the directory because of unauthorized access.", e);
            }
            catch (Exception e)
            {
                throw new Exception("An exception occured while deleting a directory.", e);
            }
        }

        /// <summary>
        /// Creates a directory path.
        /// </summary>
        /// <param name="destination">The directory path.</param>
        /// <returns>Path to the created directory.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="PathTooLongException"></exception>
        /// <exception cref="UnauthorizedAccessException"></exception>
        /// <exception cref="Exception"></exception>
        private static string CreateDirectory(string destination)
        {
            if (string.IsNullOrEmpty(destination)) throw new ArgumentNullException(destination, "Destination path was null or empty.");
            var output = new DirectoryInfo(destination);

            if (output.Exists) return output.Exists ? output.FullName : null;

            try
            {
                return Directory.CreateDirectory(output.FullName).FullName;
            }
            catch (PathTooLongException e)
            {
                throw new PathTooLongException("Could not create destination output directory because the path was too long.", e);
            }
            catch (IOException e)
            {
                throw new IOException("Could not create destination output directory.", e);
            }
            catch (UnauthorizedAccessException e)
            {
                throw new UnauthorizedAccessException("Could not create destination output directory because of unauthorized access.", e);
            }
            catch (Exception e)
            {
                throw new Exception("An exception occured while creating a directory.", e);
            }
        }
    }
}
