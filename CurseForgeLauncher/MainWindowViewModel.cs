using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CurseForgeLauncher
{
    public class MainWindowViewModel : ModelViewBase
    {
        public ObservableCollection<Game> GameBanners { get; set; } = new ObservableCollection<Game>();

        RelayCommand subscribeCommand => new RelayCommand(Subscribe);
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

        private void Subscribe(object obj)
        {
            // open subscride page 
            MessageBox.Show("Subscride Page");
        }

        public MainWindowViewModel()
        {
            GameManager.OnAddGame += GameBanners.Add;

            GameBanners.Add(new Game() 
            { 
                BannerPath = "Images/MinecraftBanner.png", 
                IconPath = "Images/MinecraftIcon.png",
                Title = "Minecraft",
                IsInstalled = false,
            });
            GameBanners.Add(new Game()
            {
                BannerPath = "Images/PalworldBanner.png",
                IconPath = "Images/PalworldIcon.png",
                Title = "Palworld",
                IsInstalled = false,
            });
            GameBanners.Add(new Game()
            {
                BannerPath = "Images/StardewValleyBanner.png",
                IconPath = "Images/StardewValleyIcon.png",
                Title = "Stardew Valley",
                IsInstalled = false,
            });
            GameBanners.Add(new Game()
            {
                BannerPath = "Images/Sims4Banner.png",
                IconPath = "Images/Sims4Icon.png",
                Title = "Sims 4",
                IsInstalled = false,
            });
            GameBanners.Add(new Game()
            {
                BannerPath = "Images/WowBanner.png",
                IconPath = "Images/WowIcon.png",
                Title = "World of Warcraft",
                IsInstalled = false,
            });
        }
    }
}
