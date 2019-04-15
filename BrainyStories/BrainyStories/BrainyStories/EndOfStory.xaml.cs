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
	public partial class EndOfStory : ContentPage
	{
        private Settings settingsPage;

        public ObservableCollection<ThinkAndDo> ListOfThinkAndDos;
        Quiz last;

        public EndOfStory (Story story)
		{
            if(!User.Instance.StoriesRead.Contains(story))
                User.Instance.StoriesRead.Add(story);
            ListOfThinkAndDos = story.ThinkAndDos;
            last = story.Quizzes[story.QuizNum - 1];
            InitializeComponent ();
            BindThinkAndDoList.ItemsSource = ListOfThinkAndDos;
            Label displayLabel = new Label
            {
                Text = last.QuizName,
                VerticalOptions = LayoutOptions.Center,
                FontSize = 20
            };
            LastQuiz.Children.Add(displayLabel);
            settingsPage = new Settings();
        }

        async void OnTaskTapped(object sender, ItemTappedEventArgs e)
        {
            ListView view = (ListView)sender;
            var think = (ThinkAndDo)view.SelectedItem;
            ThinkAndDoPopup pop = new ThinkAndDoPopup(think);
            await PopupNavigation.Instance.PushAsync(pop);
        }

        async void OnQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizPage(last));
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

        //async void BackToTOC(object sender, EventArgs e)
        //{

        //}

    }
}