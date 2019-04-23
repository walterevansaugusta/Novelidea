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

    // Class for the page at the end of a completed classic story
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
                FontFamily = "Comic",
                VerticalOptions = LayoutOptions.Center,
                FontSize = 20
            };
            LastQuiz.Children.Add(displayLabel);
            settingsPage = new Settings();
        }

        // Launches a ThinkAndDo popup for selected activity
        async void OnTaskTapped(object sender, ItemTappedEventArgs e)
        {
            ListView view = (ListView)sender;
            var think = (ThinkAndDo)view.SelectedItem;
            ThinkAndDoPopup pop = new ThinkAndDoPopup(think);
            await PopupNavigation.Instance.PushAsync(pop);
        }

        // Launches a quiz page for selected quiz
        async void OnQuizTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizPage(last));
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