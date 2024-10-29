using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseForgeLauncher
{
    public class AddGameViewModel : ModelViewBase
    {
        public Game gameBanner { get; set; }

        public RelayCommand AddGameCommand => new RelayCommand(AddGame);

        private void AddGame(object obj)
        {
            if ((obj as Game).IsInstalled)
            {
                // Open Game Mods Page
                return;
            }
            (obj as Game).IsInstalled = true;
        }
    }
}
