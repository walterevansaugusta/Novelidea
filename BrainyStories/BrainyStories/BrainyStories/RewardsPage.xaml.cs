using BrainyStories.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RewardsPage : ContentPage {
        public RewardsPage()
        {
            InitializeComponent();
            //User user = new User();
            int numOfBronzeCoins = User.rewardsRecieved["Bronze"];
            int numOfSilverCoins = User.rewardsRecieved["Silver"] + (numOfBronzeCoins / 5);
            int numOfGoldCoins = User.rewardsRecieved["Gold"] + (numOfSilverCoins / 5);
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
    }
}