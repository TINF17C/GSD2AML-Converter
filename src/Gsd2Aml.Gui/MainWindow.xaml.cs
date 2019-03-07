using System;
using System.Windows;
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
                Filter = "Generic station description files (.gsdml; .xml)|*.gsdml;*.xml",
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
    }
}
