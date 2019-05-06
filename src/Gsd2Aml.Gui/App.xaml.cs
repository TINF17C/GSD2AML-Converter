using System.Windows;

namespace Gsd2Aml.Gui
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            NLog.LogManager.Shutdown();
        }
    }
}
