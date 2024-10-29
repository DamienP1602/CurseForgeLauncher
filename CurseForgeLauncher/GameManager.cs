using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseForgeLauncher
{
    public class GameManager
    {
        public static Action<bool>? OnGameInstalled = null;
        public static event Action? OnGameClicked = null;

        public static ObservableCollection<Game> Games { get; set; } = new ObservableCollection<Game>();
    }
}
