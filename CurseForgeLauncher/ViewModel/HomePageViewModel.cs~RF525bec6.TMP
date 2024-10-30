using CurseForgeLauncher.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CurseForgeLauncher.ViewModel
{
    class HomePageViewModel : ModelViewBase
    {
        public ObservableCollection<Game> GameBanners { get; set; } = new ObservableCollection<Game>();

        public HomePageViewModel()
        {
            GameBanners.Add(new Game()
            {
                BannerPath = "/Views/MinecraftBanner.png",
                IconPath = "/Images/MinecraftIcon.png",
                Title = "Minecraft",
                IsInstalled = false,
            });
            GameBanners.Add(new Game()
            {
                BannerPath = "/Views/PalworldBanner.png",
                IconPath = "Images/PalworldIcon.png",
                Title = "Palworld",
                IsInstalled = false,
            });
            GameBanners.Add(new Game()
            {
                BannerPath = "/Views/StardewValleyBanner.png",
                IconPath = "Images/StardewValleyIcon.png",
                Title = "Stardew Valley",
                IsInstalled = false,
            });
            GameBanners.Add(new Game()
            {
                BannerPath = "/Views/Sims4Banner.png",
                IconPath = "Images/Sims4Icon.png",
                Title = "Sims 4",
                IsInstalled = false,
            });
            GameBanners.Add(new Game()
            {
                BannerPath = "/Views/WowBanner.png",
                IconPath = "Images/WowIcon.png",
                Title = "World of Warcraft",
                IsInstalled = false,
            });

            foreach (Game _game in GameBanners)
            {
                _game.SelectedCommand = new RelayCommand(execute => SelectGame(_game));
            }
        }

        void SelectGame(Game _gamesSelected)
        {
            MessageBox.Show(_gamesSelected.Title);
            _gamesSelected.IsInstalled = true;
        }

    }
}
