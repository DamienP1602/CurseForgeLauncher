﻿using System;
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

        RelayCommand gameClickedCommand => new RelayCommand(GameClicked);


        void GameClicked(object obj)
        {
            if (((Game)obj).IsInstalled == false)
            {
                ((Game)obj).IsInstalled = true;
                MessageBox.Show("Game Installed");
                return;
            }
            // User Control qui ouvre la fenetre de modpack du jeu
            MessageBox.Show("Game Open...");
        }
    }
}
 