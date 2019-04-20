using BrainyStories.Objects;
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
    
    // Class for the table of contents
	public partial class TableOfContents : ContentPage
	{
        private Settings settingsPage;

        public TableOfContents (bool imagines)
		{
            NavigationPage.SetHasNavigationBar(this, false);
            if (imagines)
            {
                Story.ListOfStories = StoryFactory.Imagines;
            }
            else
            {
                Story.ListOfStories = StoryFactory.Stories;
            }
            InitializeComponent();
            listView.SelectedItem = null;
            settingsPage = new Settings();
        }

        // Launchs a StoryPage for the selected story
        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView view = (ListView)sender;
            if (view.SelectedItem == null)
            {
                return;
            }
            User user = User.Instance;
            var story = (Story)view.SelectedItem;
            view.SelectedItem = null;
            await Navigation.PushAsync(new StoryPage(story));  
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