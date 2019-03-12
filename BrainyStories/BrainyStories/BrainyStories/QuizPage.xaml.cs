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
        private int QuestionsCorrect = 0;
        private Quiz quiz;

        public QuizPage(Quiz temp)
        {
            InitializeComponent();
            temp.NumAttemptsQuiz++;
            quiz = temp;
            settingsPage = new Settings();
            QuizTitle.Text = quiz.QuizName;
            NumCorrect.Text = "Questions Correct: " + QuestionsCorrect;
            QuestionTitle.Text = quiz.Questions[QuestionNum].QuestionText;
            One.Text = quiz.Questions[QuestionNum].AnswerArray[0];
            Two.Text = quiz.Questions[QuestionNum].AnswerArray[1];
            Three.Text = quiz.Questions[QuestionNum].AnswerArray[2];
            Four.Text = quiz.Questions[QuestionNum].AnswerArray[3];
            PreviousButton.IsVisible = false;
        }

        private void PreviousQuestion(object sender, EventArgs e)
        {
            if (QuestionNum > 0)
            {
                QuestionNum--;
                QuestionTitle.Text = quiz.Questions[QuestionNum].QuestionText;
                One.Text = quiz.Questions[QuestionNum].AnswerArray[0];
                Two.Text = quiz.Questions[QuestionNum].AnswerArray[1];
                Three.Text = quiz.Questions[QuestionNum].AnswerArray[2];
                Four.Text = quiz.Questions[QuestionNum].AnswerArray[3];
            }
        }

        private void NextQuestion(object sender, EventArgs e)
        {
            if (QuestionNum < quiz.NumQuestions)
            {
                QuestionNum++;
                QuestionTitle.Text = quiz.Questions[QuestionNum].QuestionText;
                One.Text = quiz.Questions[QuestionNum].AnswerArray[0];
                Two.Text = quiz.Questions[QuestionNum].AnswerArray[1];
                Three.Text = quiz.Questions[QuestionNum].AnswerArray[2];
                Four.Text = quiz.Questions[QuestionNum].AnswerArray[3];
            }
            if (QuestionNum > 0)
            {
                PreviousButton.IsVisible = true;
            }
            if (QuestionNum == quiz.NumQuestions)
            {
                // call end of quiz
            }
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (clicked.Text.Equals(quiz.Questions[QuestionNum].CorrectAnswer)) {
                clicked.BackgroundColor = Color.Green;
                QuestionsCorrect++;
                // something with rewards / score
            } else
            {
                clicked.BackgroundColor = Color.Red;
            }
            quiz.NumAttempts[QuestionNum]++;
            NumCorrect.Text = "Questions Correct: " + QuestionsCorrect;
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