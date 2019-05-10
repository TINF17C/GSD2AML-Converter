using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace Gsd2Aml.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _strictModeEnabled = true;
        private bool _warningShown = false;

        public string ProductTitle => "GSD2AML Converter";

        public string ProductVersion => System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

        public bool StrictModeEnabled
        {
            get { return _strictModeEnabled; }
            set
            {
                if (!value)
                {
                    if (_warningShown)
                    {
                        _strictModeEnabled = value;
                    }
                    else if (MessageBox.Show(this, "WARNING!\n\nBy turning strict mode off, the converter will not validate GSDML files anymore.",
                        "GSD2AML Converter", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                    {
                        _warningShown = true;
                        _strictModeEnabled = value;
                    }
                }
                else
                {
                    _strictModeEnabled = value;
                }
            }
        }

        /// <summary>
        /// Initializes the main window component.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Dialogs
        private void BrowseGsdFile_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                DefaultExt = ".xml",
                Filter = "Generic station description markup language files (.xml)|*.xml",
                InitialDirectory = string.IsNullOrEmpty(TxtGsdFile.Text.Trim()) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : System.IO.Path.GetDirectoryName(TxtGsdFile.Text) ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "GSD2AML Converter"
            };

            if (dialog.ShowDialog(this).Value)
            {
                TxtGsdFile.Text = dialog.FileName;
                App.Logger.Log(Lib.Logging.LogLevel.Info, "Open file \"" + TxtGsdFile.Text + "\"");
            }
        }

        private void BrowseAmlFile_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                AddExtension = true,
                CheckPathExists = true,
                DefaultExt = ".amlx",
                Filter = "AutomationML archives (.amlx)|*.amlx",
                InitialDirectory = string.IsNullOrEmpty(TxtAmlFile.Text.Trim()) ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : System.IO.Path.GetDirectoryName(TxtAmlFile.Text) ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                FileName = !string.IsNullOrEmpty(TxtAmlFile.Text.Trim()) ? System.IO.Path.GetFileName(TxtAmlFile.Text) : "",
                Title = "GSD2AML Converter",
                ValidateNames = true
            };

            if (dialog.ShowDialog(this).Value)
            {
                TxtAmlFile.Text = dialog.FileName;
                App.Logger.Log(Lib.Logging.LogLevel.Info, "Save file to \"" + TxtGsdFile.Text + "\"");
            }
        }
        #endregion

        /// <summary>
        /// On click tries to convert the file and prompts the user whether or not to open the file in AutomationML Editor if one is installed.
        /// </summary>
        /// <param name="sender">The sending object.</param>
        /// <param name="e">Corresponding event.</param>
        private void Convert_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var overwrite = false;
                if (System.IO.File.Exists(TxtAmlFile.Text))
                {
                    overwrite = MessageBox.Show(this, $"The File \"{TxtAmlFile.Text}\" already exits.\n\nDo you want to overwrite it?", "GSD2AML Converter", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
                }

                App.Logger.Log(Lib.Logging.LogLevel.Info, "Start conversion of file \"" + TxtGsdFile.Text + "\"");
                Lib.Converter.Convert(TxtGsdFile.Text, TxtAmlFile.Text, overwrite, StrictModeEnabled);

                App.Logger.Log(Lib.Logging.LogLevel.Info, "Conversion successfully completed!");
                MessageBox.Show(this, "Conversion successfully completed!", "GSD2AML Converter");

                if (GetAmlEditor() is string editor && !string.IsNullOrEmpty(editor))
                {
                    if (MessageBox.Show(this, "Do you want to open the file in AutomationML Editor?", "GSD2AML Converter", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        try
                        {
                            App.Logger.Log(Lib.Logging.LogLevel.Debug, "Trying to start AutomationML Editor");
                            System.Diagnostics.Process.Start(editor, "\"" + TxtAmlFile.Text + "\"");
                        }
                        catch (Exception ex)
                        {
                            App.Logger.Log(Lib.Logging.LogLevel.Error, ex.Message);
                            MessageBox.Show(this, "An error occured when trying to open the AutomationML Editor.", "GSD2AML Converter", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                App.Logger.Log(Lib.Logging.LogLevel.Error, ex.Message);
                MessageBox.Show(this, ex.Message, "GSD2AML Converter: Conversion failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Searches for an installed AutomationML Editor and returns it.
        /// </summary>
        /// <returns>Path to the AutomationML Editor.</returns>
        private string GetAmlEditor()
        {
            try
            {
                App.Logger.Log(Lib.Logging.LogLevel.Debug, "Search for AutomationML Editor");
                var key = Registry.CurrentUser.OpenSubKey(@"Software\AutomationML\AutomationML Editor");

                App.Logger.Log(Lib.Logging.LogLevel.Debug, "Opened key \"" + key.Name + "\"");
                key = key.OpenSubKey(key.GetSubKeyNames().FirstOrDefault());

                App.Logger.Log(Lib.Logging.LogLevel.Debug, "Opened subkey \"" + key.Name + "\"");
                var valueName = key.GetValueNames().FirstOrDefault();

                App.Logger.Log(Lib.Logging.LogLevel.Debug, "Reading value from \"" + valueName + "\"");
                var value = key.GetValue(valueName).ToString();

                App.Logger.Log(Lib.Logging.LogLevel.Debug, "Result from value is \"" + value + "\"");
                var dir = new System.IO.DirectoryInfo(value);

                if (dir.Exists)
                {
                    var file = dir.GetFiles("AutomationML Editor.lnk", System.IO.SearchOption.TopDirectoryOnly).FirstOrDefault();
                    return file.FullName;
                }
            }
            catch (Exception ex)
            {
                App.Logger.Log(Lib.Logging.LogLevel.Debug, ex.Message);
            }

            return string.Empty;
        }

        #region Drag&Drop

        #region Window
        private void MainWindow_OnDragEnter(object sender, DragEventArgs e)
        {
            App.Logger.Log(Lib.Logging.LogLevel.Debug, "Drag entered window");
            var data = e.Data.GetData(DataFormats.FileDrop);
            if ((data as string[])?.FirstOrDefault() != null)
            {
                var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
                App.Logger.Log(Lib.Logging.LogLevel.Debug, "File \"" + fileName + "\" drag onto window");
                if (!string.IsNullOrEmpty(fileName) && fileName.StartsWith("GSDML", StringComparison.InvariantCultureIgnoreCase) &&
                    fileName.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase))
                {
                    App.Logger.Log(Lib.Logging.LogLevel.Debug, "File is legal");
                    e.Effects = DragDropEffects.All | DragDropEffects.Copy | DragDropEffects.Link | DragDropEffects.Move;
                }
                else
                {
                    App.Logger.Log(Lib.Logging.LogLevel.Debug, "File is not legal");
                    e.Effects = DragDropEffects.None;
                }
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void MainWindow_OnPreviewDragOver(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if ((data as string[])?.FirstOrDefault() != null)
            {
                var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
                App.Logger.Log(Lib.Logging.LogLevel.Debug, "File \"" + fileName + "\" draged over window");
                if (!string.IsNullOrEmpty(fileName) && fileName.StartsWith("GSDML", StringComparison.InvariantCultureIgnoreCase) &&
                    fileName.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase))
                {
                    e.Effects = DragDropEffects.All | DragDropEffects.Copy | DragDropEffects.Link | DragDropEffects.Move;
                }
                else
                {
                    e.Effects = DragDropEffects.None;
                }
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void MainWindow_OnDrop(object sender, DragEventArgs e)
        {
            App.Logger.Log(Lib.Logging.LogLevel.Debug, "Dropped file onto window");
            var data = e.Data.GetData(DataFormats.FileDrop);

            if ((data as string[])?.FirstOrDefault() == null) return;

            var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
            App.Logger.Log(Lib.Logging.LogLevel.Debug, "Dropped file \"" + fileName + "\"");
            if (!string.IsNullOrEmpty(fileName) && fileName.StartsWith("GSDML", StringComparison.InvariantCultureIgnoreCase) &&
                fileName.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase))
            {
                TxtGsdFile.Text = ((string[])data)[0];
            }
        }
        #endregion

        #region Textbox
        private void TxtGsdFile_OnDragEnter(object sender, DragEventArgs e)
        {
            App.Logger.Log(Lib.Logging.LogLevel.Debug, "Drag entered gsd textbox");
            var data = e.Data.GetData(DataFormats.FileDrop);
            if ((data as string[])?.FirstOrDefault() != null)
            {
                var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
                App.Logger.Log(Lib.Logging.LogLevel.Debug, "File \"" + fileName + "\" drag onto gsd textbox");
                if (!string.IsNullOrEmpty(fileName) && fileName.StartsWith("GSDML", StringComparison.InvariantCultureIgnoreCase) &&
                    fileName.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase))
                {
                    App.Logger.Log(Lib.Logging.LogLevel.Debug, "File is legal");
                    e.Effects = DragDropEffects.All | DragDropEffects.Copy | DragDropEffects.Link | DragDropEffects.Move;
                    e.Handled = true;
                }
                else
                {
                    App.Logger.Log(Lib.Logging.LogLevel.Debug, "File is not legal");
                    e.Effects = DragDropEffects.None;
                }
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void TxtGsdFile_OnPreviewDragOver(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if ((data as string[])?.FirstOrDefault() != null)
            {
                var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
                App.Logger.Log(Lib.Logging.LogLevel.Debug, "File \"" + fileName + "\" draged over gsd textbox");
                if (!string.IsNullOrEmpty(fileName) && fileName.StartsWith("GSDML", StringComparison.InvariantCultureIgnoreCase) &&
                    fileName.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase))
                {
                    e.Effects = DragDropEffects.All | DragDropEffects.Copy | DragDropEffects.Link | DragDropEffects.Move;
                    e.Handled = true;
                }
                else
                {
                    e.Effects = DragDropEffects.None;
                }
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void TxtGsdFile_OnDrop(object sender, DragEventArgs e)
        {
            App.Logger.Log(Lib.Logging.LogLevel.Debug, "Dropped file onto gsd textbox");
            var data = e.Data.GetData(DataFormats.FileDrop);

            if ((data as string[])?.FirstOrDefault() == null) return;

            var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
            App.Logger.Log(Lib.Logging.LogLevel.Debug, "Dropped file \"" + fileName + "\"");
            if (!string.IsNullOrEmpty(fileName) && fileName.StartsWith("GSDML", StringComparison.InvariantCultureIgnoreCase) &&
                fileName.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase))
            {
                ((TextBox)sender).Text = fileName;
            }
        }
        #endregion

        #endregion

        /// <summary>
        /// Takes the GSDML file path and tries to convert it to an .amlx output path.
        /// </summary>
        /// <param name="sender">The sending object.</param>
        /// <param name="e">Corresponding event.</param>
        private void TxtGsdFile_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var senderText = ((TextBox)sender).Text;
            if (string.IsNullOrEmpty(senderText))
                return;

            if (Regex.IsMatch(senderText, $"(.+(GSDML|gsdml)-.+{Regex.Escape(".xml")})"))
            {
                var diretoryName = System.IO.Path.GetDirectoryName(senderText) ?? "";
                var fileName = System.IO.Path.GetFileNameWithoutExtension(senderText).Remove(0, "GSDML-".Length) + ".amlx";

                TxtAmlFile.Text = System.IO.Path.Combine(diretoryName, fileName);
            }
        }
    }
}
