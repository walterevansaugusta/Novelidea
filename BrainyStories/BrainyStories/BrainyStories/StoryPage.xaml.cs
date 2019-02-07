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
	public partial class StoryPage : ContentPage
	{
		public StoryPage (Story story)
		{
			InitializeComponent();
            testLabel.Text = story.Name;
            Label rotationLabel = new Label
            {
                Text = "TEST",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label displayLabel = new Label
            {
                Text = "0",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Slider slider = new Slider
            {
                Maximum = story.Duration.Seconds + (story.Duration.Minutes * 60),
                Minimum = 0,
                Value = 0
            };
            slider.ValueChanged += (sender, args) =>
            {
                rotationLabel.Rotation = slider.Value;
                displayLabel.Text = String.Format("The Slider value is {0}", args.NewValue);
            };

            Title = "Basic Slider Code";
            Padding = new Thickness(10, 10);
            Content = new StackLayout
            {
                Children =
            {
                rotationLabel,
                displayLabel,
                slider
            }
            };
        }
	}
}