using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace Gsd2Aml.Gui
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BrowseGsdFile_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                DefaultExt = ".gsd",
                Filter = "Generic station description files (.xml)|*.xml",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "GSD2AML Converter"
            };

            if (dialog.ShowDialog(this).Value)
            {
                TxtGsdFile.Text = dialog.FileName;
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
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "GSD2AML Converter",
                ValidateNames = true
            };

            if (dialog.ShowDialog(this).Value)
            {
                TxtAmlFile.Text = dialog.FileName;
            }
        }

        private void Convert_OnClick(object sender, RoutedEventArgs e)
        {
            //ToDo: Do conversion
        }

        private void MainWindow_OnDragEnter(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if ((data as string[])?.FirstOrDefault() != null)
            {
                var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
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

        private void MainWindow_OnPreviewDragOver(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if ((data as string[])?.FirstOrDefault() != null)
            {
                var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
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
            var data = e.Data.GetData(DataFormats.FileDrop);

            if ((data as string[])?.FirstOrDefault() == null) return;

            var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
            if (!string.IsNullOrEmpty(fileName) && fileName.StartsWith("GSDML", StringComparison.InvariantCultureIgnoreCase) &&
                fileName.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase))
            {
                TxtGsdFile.Text = fileName;
            }
        }

        private void TxtGsdFile_OnDragEnter(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if ((data as string[])?.FirstOrDefault() != null)
            {
                var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
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

        private void TxtGsdFile_OnPreviewDragOver(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if ((data as string[])?.FirstOrDefault() != null)
            {
                var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
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
            var data = e.Data.GetData(DataFormats.FileDrop);

            if ((data as string[])?.FirstOrDefault() == null) return;

            var fileName = System.IO.Path.GetFileName(((string[])data)[0]);
            if (!string.IsNullOrEmpty(fileName) && fileName.StartsWith("GSDML", StringComparison.InvariantCultureIgnoreCase) &&
                fileName.EndsWith(".xml", StringComparison.InvariantCultureIgnoreCase))
            {
                ((TextBox)sender).Text = fileName;
            }
        }
    }
}
