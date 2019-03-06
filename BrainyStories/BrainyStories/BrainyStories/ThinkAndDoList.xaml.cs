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

        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView view = (ListView)sender;
            var think = (ThinkAndDo)view.SelectedItem;
            ThinkAndDoPopup pop = new ThinkAndDoPopup(think);
            await PopupNavigation.Instance.PushAsync(pop);     
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