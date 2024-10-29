using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CurseForgeLauncher
{
    public class GameManager
    {
        public static Action<Game>? OnAddGame = null;
        public static ObservableCollection<Game> Games { get; set; } = new ObservableCollection<Game>();
    }
}
 