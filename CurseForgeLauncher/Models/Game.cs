using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CurseForgeLauncher
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        bool isInstalled;

        public string BannerPath { get; set; }
        public string IconPath { get; set; }
        public string Title { get; set; }

        public RelayCommand SelectedCommand { get; set; }
        public bool IsInstalled
        {
            get
            {
                return isInstalled;
            }
            set
            {
                isInstalled = value;
                OnPropertyChanged();
            }
        }

        public string IsInstalledString => isInstalled ? "Installed" : "Not Installed";
        public ObservableCollection<ModPack> ModPack { get; set; } = new ObservableCollection<ModPack>();
        public int ModsCount => ModPack.Count;

        void OnPropertyChanged([CallerMemberName] string _propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(_propName));
        }
    }
}
