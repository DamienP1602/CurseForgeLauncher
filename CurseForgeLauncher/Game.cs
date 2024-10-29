using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseForgeLauncher
{
    public class Game
    {
        public string BannerPath { get; set; }
        public string IconPath { get; set; }
        public string Title { get; set; }

        public bool IsInstalled { get; set; }

        public ObservableCollection<Mod> Mods { get; set; } = new ObservableCollection<Mod>();

        public int ModsCount => Mods.Count;
    }
}
