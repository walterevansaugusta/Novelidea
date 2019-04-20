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
    public partial class MainPage : ContentPage {
        private Settings settingsPage;

        public MainPage() {
            InitializeComponent();
            settingsPage = new Settings();
        }
        
        // Imagines TOC
        // Argument: True = Imagines, False = Stories
        async void ImaginesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TableOfContents(true));
        }

        // Stories Table of Contents Page Button
        // Argument: True = Imagines, False = Stories
        async void StoriesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TableOfContents(false));
        }
        
        // Think and Do List Page Button
        async void ThinkAndDoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThinkAndDoList());
        }

        // Quiz List Page Button
        async void QuizzesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizList());
        }
        
        // Progress Page Button
        async void ProgressClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgressPage());
        }

        // Rewards Page button
        async void RewardsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RewardsPage());
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

        // Returns to the Home page
        async void SettingsClicked(object sender, EventArgs e)
        {

            await PopupNavigation.Instance.PushAsync(settingsPage);
        }

       
    }
}
