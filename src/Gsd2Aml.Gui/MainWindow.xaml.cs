using System;
using System.Linq;
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

        private void Convert_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                App.Logger.Log(Lib.Logging.LogLevel.Info, "Start conversion of file \"" + TxtGsdFile.Text + "\"");
                Lib.Converter.Convert(TxtGsdFile.Text, TxtAmlFile.Text, false);
                App.Logger.Log(Lib.Logging.LogLevel.Info, "Conversion successfully completed!");
                MessageBox.Show(this, "Conversion successfully completed!", "GSD2AML Converter");
            }
            catch (Exception ex)
            {
                App.Logger.Log(Lib.Logging.LogLevel.Error, ex.Message);
                MessageBox.Show(this, ex.Message, "GSD2AML Converter: Conversion failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
