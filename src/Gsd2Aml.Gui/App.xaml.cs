using System.Windows;

namespace Gsd2Aml.Gui
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        internal static Logger Logger { get; } = new Logger();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Lib.Util.Logger = Logger;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            NLog.LogManager.Shutdown();
        }
    }
}
