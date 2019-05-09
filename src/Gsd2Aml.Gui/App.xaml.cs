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
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Lib.Converter.Logger = Logger;
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            NLog.LogManager.Shutdown();
        }
    }
}
