using CurseForgeLauncher.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CurseForgeLauncher
{
    public class MainWindowViewModel : ModelViewBase
    {
        public RelayCommand HomeCommand => new RelayCommand(GoHomeCommand);
        public RelayCommand LoginCommand => new RelayCommand(execute => OpenLoginURL());
        public RelayCommand DiscordCommand => new RelayCommand(execute => OpenDiscordURL());
        public RelayCommand DownloadCommand => new RelayCommand(execute => OpenDownload(), canExecute => false);
        public RelayCommand SubscribeCommand => new RelayCommand(Subscribe);
        RelayCommand gameClickedCommand => new RelayCommand(GameClicked);


        void GameClicked(object obj)
        {
            if (((Game)obj).IsInstalled == false)
            {
                ((Game)obj).IsInstalled = true;
                return;
            }
            // User Control qui ouvre la fenetre de modpack du jeu
        }

        private void Subscribe(object _obj)
        {
            LauncherPanel _panel = _obj as LauncherPanel;

            if (_panel == null)
                return;

            _panel.SubscribePage.Visibility = System.Windows.Visibility.Visible;
            _panel.HomePage.Visibility = System.Windows.Visibility.Hidden;
        }

        public MainWindowViewModel()
        {
           
        }

        void GoHomeCommand(object _obj)
        {
            LauncherPanel _panel = _obj as LauncherPanel;

            if (_panel == null)
                return;

            _panel.HomePage.Visibility = System.Windows.Visibility.Visible;
            _panel.SubscribePage.Visibility = System.Windows.Visibility.Hidden;
        }

        void OpenLoginURL()
        {
            string _url = "https://www.curseforge.com/api/v1/auth/login?returnUrl=https://www.curseforge.com/";

            ProcessStartInfo _psi = new ProcessStartInfo(_url);
            _psi.UseShellExecute = true;
            Process.Start(_psi);
        }
        void OpenDiscordURL()
        {
            string _url = "https://discord.com/invite/curseforge";

            ProcessStartInfo _psi = new ProcessStartInfo(_url);
            _psi.UseShellExecute = true;
            Process.Start(_psi);
        }

        void OpenDownload()
        {

        }


    }
}
