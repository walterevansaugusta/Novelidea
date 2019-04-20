using BrainyStories.Objects;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    // Class for the ThinkAndDo list page
	public partial class ThinkAndDoList : ContentPage
	{
        private Settings settingsPage;
        private ThinkAndDoFactory factory = new ThinkAndDoFactory();

        public ObservableCollection<ThinkAndDo> ListOfThinkAndDos;
        public ThinkAndDoList ()
		{ 
            ListOfThinkAndDos = factory.generateThinkAndDos();
            InitializeComponent();
            BindList.ItemsSource = ListOfThinkAndDos;
            settingsPage = new Settings();
           
        }

        // Lauches a ThinkAndDo popup for the selected ThinkAndDo
        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView view = (ListView)sender;
            if (view.SelectedItem == null)
            {
                return;
            }
            var think = (ThinkAndDo)view.SelectedItem;
            view.SelectedItem = null;
            ThinkAndDoPopup pop = new ThinkAndDoPopup(think);
            await PopupNavigation.Instance.PushAsync(pop);     
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