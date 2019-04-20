using System;
using System.Threading.Tasks;
using BrainyStories.Objects;
using Plugin.SimpleAudioPlayer;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    // Class for the ThinkAndDo popups
    public partial class ThinkAndDoPopup : PopupPage
    {
        private ISimpleAudioPlayer player;

        public ThinkAndDoPopup (ThinkAndDo thinkAndDo)
        {
            InitializeComponent();
            ThinkAndDoTitle.Text = thinkAndDo.ThinkAndDoName;
            Button button = new Button()
            {
                Text = "Pause"
            };
            Button button2 = new Button()
            {
                Text = "Play",
                IsVisible = false
            };
            Label displayLabel = new Label
            {
                Text = "0:00",
            };
            Slider slider = new Slider
            {
                Maximum = thinkAndDo.Length.Seconds + (thinkAndDo.Length.Minutes * 60),
                Minimum = 0,
                Value = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 50 // Controls size of area that can grab the slider
            };
           
            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(thinkAndDo.ThinkAndDoAudioClip);
            bool audioFromTimer = false;
            bool playAudio = true;
            player.Play();
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
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                if (playAudio)
                {
                    audioFromTimer = true;
                    slider.Value += 1;
                }
                return true;
            });
            slider.ValueChanged += (sender, args) =>
            {
                int minutes = (int)args.NewValue / 60;
                int seconds = (int)args.NewValue - (minutes * 60);
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
                audioFromTimer = false;
                if (timeStamp.Equals(thinkAndDo.Length))
                {
                    thinkAndDo.Completed = true;
                }
            };
            StackLayout audio = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    button,
                    button2,
                    displayLabel
                }
            };
            TopStack.Children.Add(slider);
            TopStack.Children.Add(audio);
        }

        // Returns to previous page when back button is selected
        protected override bool OnBackButtonPressed()
        {
            player.Stop();
            return false;
        }

        // Returns to the previous page when an area outside the popup is clicked
        private void OnCloseButtonTapped(object sender, EventArgs e)
        {
            player.Stop();
            CloseAllPopup();
        }

        // Returns to the previous page when an area outside the popup is clicked
        protected override bool OnBackgroundClicked()
        {
            player.Stop();
            CloseAllPopup();
            return false;
        }

        // Returns to the previous page when an area outside the popup is clicked
        private async void CloseAllPopup()
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}