using System;
using System.IO;
using Gsd2Aml.Lib;

namespace Gsd2Aml.CLI
{
    internal class Trigger
    {
        public Settings Settings { get; }
        private FileInfo FInfo { get; }
        public Trigger(Settings settings)
        {
            Settings = settings;
            GetOutputFile();
            FInfo = new FileInfo(Settings.OutputFile);
        }

        public void Convert()
        {
            CreateDirectories();
            CheckOutput();

            Converter.Convert(Settings.InputFile, Settings.OutputFile, Settings.AsString);
            
        }

        private void CheckOutput()
        {
            if (FInfo.Exists)
            {
                string userInput;

                do
                {
                    Console.Write($"{FInfo.FullName} exists already. Overwrite file? (y/n): ");
                    userInput = Console.ReadKey().KeyChar.ToString().ToLower();
                    Console.WriteLine(Environment.NewLine);
                } while (!userInput.Equals("y") && !userInput.Equals("n"));

                if (userInput.Equals("n"))
                {
                    Console.WriteLine("Could not convert file because the output file should not be overwritten.");
                    Environment.Exit(0);
                }
            }
        }

        private void CreateDirectories()
        {
            if (FInfo.Directory == null || string.IsNullOrEmpty(FInfo.DirectoryName) || FInfo.Directory.Exists)
            {
                return;
            }

            try
            {
                Directory.CreateDirectory(FInfo.DirectoryName);
            }
            catch
            {
                Console.WriteLine($"{Environment.NewLine}Error: Could not create output directory.");
                throw;
            }
        }

        /// <summary>
        /// Checks if the output file is valid. If not it changes the string:
        /// 1) outputFile is empty --> inputFileDirectory + timestamp.amlx
        /// 2) outputFile is like ...\test or ...\.amlx --> outputDirectory + timestamp.amlx (Example: ...\test\[timestamp].amlx ...\.amlx\[timestamp].amlx)
        /// </summary>
        /// <returns>A valid outputFile string.</returns>
        internal void GetOutputFile()
        {
            if (string.IsNullOrEmpty(Settings.OutputFile))
            {
                var inputDirectoryName = Path.GetDirectoryName(Settings.InputFile);
                if (!string.IsNullOrEmpty(inputDirectoryName))
                {
                    Settings.OutputFile = Path.Combine(inputDirectoryName, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".amlx");
                }
            }

            if (!string.IsNullOrEmpty(Path.GetExtension(Settings.OutputFile)) &&
                !string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(Settings.OutputFile))) return;
            if (Settings.OutputFile != null)
            {
                Settings.OutputFile = Path.Combine(Settings.OutputFile, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".amlx");
            }
        }
    }
}
