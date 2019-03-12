using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Plugin.SimpleAudioPlayer;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StoryPage : ContentPage
	{
        private ISimpleAudioPlayer player;
        private Settings settingsPage;
        private int quizNum = -1;

        public StoryPage (Story story)
		{
			InitializeComponent();
            settingsPage = new Settings();
            Button button = new Button()
            {
                Text = "Pause"
            };
            Button button2 = new Button()
            {
                Text = "Play",
                IsVisible = false
            };
            Button QuizButton = new Button()
            {
                Text = "Quiz",
                BackgroundColor = Color.Green,
                IsVisible = false
            };
            SizeRequest HRequest = Measure(100,100);
            Image storyImage = new Image() { Source = story.PictureCues[new TimeSpan(0, 0, 0)], HeightRequest = 150, Aspect = Aspect.AspectFit };
            Label displayLabel = new Label
            {
                Text = "0:00",
            };
            Slider slider = new Slider
            {
                Maximum = story.Duration.Seconds + (story.Duration.Minutes * 60),
                Minimum = 0,
                Value = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(story.AudioClip);
            bool audioFromTimer = false;
            bool playAudio = true;
            player.Play();
            Device.StartTimer(new TimeSpan(0,0,1), () =>
            {
                if (playAudio)
                {
                    audioFromTimer = true;
                    slider.Value += 1;
                }
                if (slider.Value == story.Duration.Seconds + (story.Duration.Minutes * 60))
                {
                    player.Stop();
                    ChangePage(story); 
                    return false;
                }

                return true;
            });
            button.Clicked += (sender, args) =>
            {
                player.Pause();
                playAudio = false;
                button.IsVisible = false;
                button2.IsVisible = true;
            };
            button2.Clicked += (sender, args) =>
            {
                player.Play();
                playAudio = true;
                button.IsVisible = true;
                button2.IsVisible = false;
            };
            QuizButton.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new QuizPage(story.Quizzes[quizNum]));
                QuizButton.IsVisible = false;
                button.IsVisible = false;
                button2.IsVisible = true;
            };
            slider.ValueChanged += (sender, args) =>
            {
                QuizButton.IsVisible = false;
                int minutes = (int) args.NewValue / 60;
                int seconds = (int) args.NewValue - (minutes * 60);
                Console.WriteLine(args.NewValue);
                Console.WriteLine(player.CurrentPosition);
                Console.WriteLine(args.NewValue);
                if (!audioFromTimer)
                {
                    player.Seek(args.NewValue);
                }
                String second = seconds.ToString();
                if (seconds < 10)
                {
                    second = '0' + seconds.ToString();
                }
                displayLabel.Text = String.Format("{0}:{1}", minutes, second);
                var timeStamp = new TimeSpan(0, minutes, seconds);
                var savedTime = new TimeSpan(0, 0, 0);
                foreach (TimeSpan key in story.PictureCues.Keys) {
                    if (key.TotalSeconds < args.NewValue)
                    {
                        savedTime = key;
                    } else
                    {
                        break;
                    }
                }
                storyImage.Source = story.PictureCues[savedTime];
                //storyImage.HeightRequest = 200;
                for (int i = 0; i < 1; i++)
                {
                    if (timeStamp.Equals(story.Quizzes[i].PlayTime))
                    {
                        player.Pause();
                        QuizButton.IsVisible = true;
                        playAudio = false;
                        quizNum++;
                    }
                }
                audioFromTimer = false;
            };

            

            Title = "Basic Slider Code";
            //Padding = new Thickness(10, 10);
            StackLayout audio = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    button,
                    button2,
                    displayLabel,
                    QuizButton
                }
            };

            TopStack.Children.Add(storyImage);
            TopStack.Children.Add(slider);
            TopStack.Children.Add(audio);
            //Content = new StackLayout
            //{
            //    Children =
            //    {
            //        storyImage,
            //        slider,
            //        audio
            //    }
            //};
        }

       protected void ChangePage(Story story)
        {
            Navigation.PushAsync(new EndOfStory(story));
        }
  
        protected override bool OnBackButtonPressed()
        {
            player.Stop();
            return base.OnBackButtonPressed();
        }

        // Navbar methods
        async void BackClicked(object sender, EventArgs e)
        {
            player.Stop();
            await App.Current.MainPage.Navigation.PopAsync();
        }

        async void HomeClicked(object sender, EventArgs e)
        {
            player.Stop();
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }

        async void SettingsClicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(settingsPage);
        }
    }
}