using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;

namespace D250113
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var culture = new CultureInfo("en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
