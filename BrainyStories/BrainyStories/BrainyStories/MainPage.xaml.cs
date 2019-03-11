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

        // Stories TOC
        // Argument: True = Imagines, False = Stories
        async void StoriesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TableOfContents(false));
        }
        
        async void ThinkAndDoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThinkAndDoList());
        }
        // Navbar methods
        async void BackClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        async void HomeClicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }

        async void SettingsClicked(object sender, EventArgs e)
        {

            await PopupNavigation.Instance.PushAsync(settingsPage);
        }

        async void ProgressClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgressPage());
        }
    }
}
