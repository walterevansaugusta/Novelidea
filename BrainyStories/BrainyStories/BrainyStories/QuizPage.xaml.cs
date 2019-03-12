using BrainyStories.Objects;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        private Settings settingsPage;
        private int QuestionNum = 0;

        public QuizPage(Quiz quiz)
        {
            InitializeComponent();
            settingsPage = new Settings();
            QuizTitle.Text = quiz.QuizName;
            QuestionTitle.Text = quiz.Questions[QuestionNum].QuestionText;
        }
    
        async void CheckAnswer(object sender, EventArgs e)
        {
            //Button clicked = (Button)sender;
            //if (clicked.)
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