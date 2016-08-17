using FriendStorage.UI.View;
using FriendStorage.UI.ViewModel;
using System.Windows;

namespace FriendStorage.UI
{
  public partial class App : Application
  {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindows = new MainWindow(new MainViewModel());
            mainWindows.Show();

        }
    }
}
