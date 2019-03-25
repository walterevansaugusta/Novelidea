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
        private User user;

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
                ColorChange();
            }
            if (QuestionNum > 0)
            {
                PreviousButton.IsVisible = true;
            }
            else
            {
                PreviousButton.IsVisible = false;
            }
            if (QuestionNum == quiz.NumQuestions - 1)
            {
                NextButton.IsVisible = false;
                BackToStory.IsVisible = true;
            }
            else
            {
                NextButton.IsVisible = true;
                BackToStory.IsVisible = false;
            }

        }

        private void NextQuestion(object sender, EventArgs e)
        {
            if (QuestionNum < quiz.NumQuestions - 1)
            {
                QuestionNum++;
                QuestionTitle.Text = quiz.Questions[QuestionNum].QuestionText;
                One.Text = quiz.Questions[QuestionNum].AnswerArray[0];
                Two.Text = quiz.Questions[QuestionNum].AnswerArray[1];
                Three.Text = quiz.Questions[QuestionNum].AnswerArray[2];
                Four.Text = quiz.Questions[QuestionNum].AnswerArray[3];
                ColorChange();
            }
            if (QuestionNum > 0)
            {
                PreviousButton.IsVisible = true;
            } else
            {
                PreviousButton.IsVisible = false;
            }
            if (QuestionNum == quiz.NumQuestions - 1)
            {
                NextButton.IsVisible = false;
                BackToStory.IsVisible = true;
            } else
            {
                NextButton.IsVisible = true;
                BackToStory.IsVisible = false;
            }
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            quiz.NumAttempts[QuestionNum]++;
            if (clicked.Text.Equals(quiz.Questions[QuestionNum].CorrectAnswer)) {
                clicked.BackgroundColor = Color.Green;
                QuestionsCorrect++;
                quiz.Questions[QuestionNum].AnswerSelected[clicked.Text] = true;
                if (quiz.NumAttempts[QuestionNum] == 1)
                {
                    user.rewardsRecieved["Gold"]++;
                } else if (quiz.NumAttempts[QuestionNum] == 2)
                {
                    user.rewardsRecieved["Silver"]++;
                } else
                {
                    user.rewardsRecieved["Bronze"]++;
                }
            } else
            {
                clicked.BackgroundColor = Color.Red;
                quiz.Questions[QuestionNum].AnswerSelected[clicked.Text] = true;
            }
            NumCorrect.Text = "Questions Correct: " + QuestionsCorrect;
        }

        private void ColorChange()
        {
            Button[] buttonArray = { One, Two, Three, Four };
            for (int i = 0; i < buttonArray.Length; i++)
            {
                if (quiz.Questions[QuestionNum].AnswerSelected[buttonArray[i].Text] == true)
                {
                    if (buttonArray[i].Text.Equals(quiz.Questions[QuestionNum].CorrectAnswer))
                    {
                        buttonArray[i].BackgroundColor = Color.Green;
                    }
                    else
                    {
                        buttonArray[i].BackgroundColor = Color.Red;
                    }
                }
                else
                {
                    buttonArray[i].BackgroundColor = Color.FromHex("#6F2DBD");
                }
            }  
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