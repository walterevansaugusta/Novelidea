using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TableOfContents : ContentPage
	{
        StoryFactory storyFact = new StoryFactory();

        private Settings settingsPage;

        public TableOfContents (bool imagines)
		{
            NavigationPage.SetHasNavigationBar(this, false);
            if (imagines)
            {
                Story.ListOfStories = storyFact.generateImagines();
            }
            else
            {
                Story.ListOfStories = storyFact.generateStories();
            }
            InitializeComponent();

            settingsPage = new Settings();
        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView view = (ListView)sender;
            var story = (Story)view.SelectedItem;
            story = storyFact.playedStory(story.Name);
            Navigation.PushAsync(new StoryPage(story));
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
    }
}