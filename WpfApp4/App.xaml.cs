using System.Configuration;
using System.Data;
using System.Windows;
using WpfApp4.ViewModels;
using WpfApp4.Views;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var w = new MainView();

            var vm = new MainViewModel();

            w.DataContext = vm;

            w.Show();
        }
    }

}
