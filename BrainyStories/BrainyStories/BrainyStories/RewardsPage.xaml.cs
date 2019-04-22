using BrainyStories.Objects;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories {
    [XamlCompilation(XamlCompilationOptions.Compile)]

    // Class for the rewards page
    public partial class RewardsPage : ContentPage {
        Settings settingsPage;
        public RewardsPage()
        {
            InitializeComponent();
            settingsPage = new Settings();
            User user = User.Instance;
            int numOfBronzeCoins = user.RewardsRecieved["Bronze"];
            int numOfSilverCoins = user.RewardsRecieved["Silver"] + (numOfBronzeCoins / 5);
            int numOfGoldCoins = user.RewardsRecieved["Gold"] + (numOfSilverCoins / 5);
            int numOfBags = numOfGoldCoins / 5;
            numOfBronzeCoins = numOfBronzeCoins % 5;
            numOfSilverCoins = numOfSilverCoins % 5;
            numOfGoldCoins = numOfGoldCoins % 5;
            for (int i = 0; i < numOfBags; i++)
            {
                Image bag = new Image() { Source = "Gem.png" };
                GoldList.Children.Add(bag);
            }
            for (int i = 0; i < numOfGoldCoins; i++)
            {
                Image goldCoin = new Image() { Source = "Bank.png" };
                GoldList.Children.Add(goldCoin);
            }

            for (int i = 0; i < numOfSilverCoins; i++)
            {
                Image silverCoin = new Image() { Source = "Coins.png" };
                SilverList.Children.Add(silverCoin);
            }

            for (int i = 0; i < numOfBronzeCoins; i++)
            {
                Image bronzeCoin = new Image() { Source = "Coin.png" };
                BronzeList.Children.Add(bronzeCoin);
            }
           
        }

        // Navbar methods
        // Returns to the previous page
        async void BackClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        // Returns to the Home page
        async void HomeClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }

        // Launches a settings popup
        async void SettingsClicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(settingsPage);
        }
    }
}