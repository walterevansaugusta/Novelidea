using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Plugin.SimpleAudioPlayer;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StoryPage : ContentPage
	{
        private ISimpleAudioPlayer player;
        private Settings settingsPage;
        private int quizNum = -1;

        private bool fullScreen = false;

        View oldContent = null;

        private PinchGestureRecognizer pinchGesture = new PinchGestureRecognizer();

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
            
            Label displayLabel = new Label
            {
                Text = "0:00",
            };
            Slider slider = new Slider
            {
                Maximum = story.Duration.Seconds + (story.Duration.Minutes * 60),
                Minimum = 0,
                Value = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 50 // Controls size of area that can grab the slider
            };
            Image storyImage = new Image() { Source = story.PictureCues[new TimeSpan(0, 0, 0)], HeightRequest = 150 };
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                if (!fullScreen)
                {
                    Content = storyImage;
                    fullScreen = true;
                } else
                {
                    if (oldContent != null)
                    {
                        Content = oldContent;
                        storyImage.HeightRequest = 150;
                        fullScreen = false;
                    } 
                }
                
            };
            storyImage.GestureRecognizers.Add(tapGestureRecognizer);
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
                quizNum = -1;
                for (int i = 0; i < 1; i++) // CHANGE TO NUM OF QUIZZES
                {
                    if (timeStamp.CompareTo(story.Quizzes[i].PlayTime) >= 0)
                    {
                        quizNum++;
                    }
                } 
                for (int i = 0; i < 1; i++) // CHANGE NUM OF QUIZZES
                {
                    if (timeStamp.Equals(story.Quizzes[i].PlayTime))
                    {
                        player.Pause();
                        QuizButton.IsVisible = true;
                        playAudio = false;
                        button.IsVisible = false;
                        button2.IsVisible = true;
                        Content = oldContent;
                        storyImage.HeightRequest = 150;
                        fullScreen = false;
                    }
                }
                audioFromTimer = false;
            };

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
            oldContent = Content;
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