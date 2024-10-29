using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseForgeLauncher
{
    public class MainWindowViewModel : ModelViewBase
    {
        public ObservableCollection<Game> GameBanners { get; set; } = new ObservableCollection<Game>();


        public MainWindowViewModel()
        {
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
