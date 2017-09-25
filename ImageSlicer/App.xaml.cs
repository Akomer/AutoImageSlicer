using System;
using System.Windows;

namespace ImageSlicer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    { 
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var rnd = new Random();

            StartupUri = new Uri("/ImageSlicer;component/View/MainWindow.xaml", UriKind.Relative);

        }
    }

}
