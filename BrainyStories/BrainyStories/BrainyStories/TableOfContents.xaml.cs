using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TableOfContents : ContentPage
	{
        private List<Story> storyList;
        public TableOfContents ()
		{
			InitializeComponent();
            CreateAppealKey();
            NavigationPage.SetHasNavigationBar(this, false);

            // TO-DO: 
            // remove whitespace btw cols

            StoryFactory storyFact = new StoryFactory();
            storyList = storyFact.generateStories();

            //gridLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
            gridLayout.RowDefinitions.Add(new RowDefinition());
            var storyIndex = 0;
            var rowNum = 0;
            for (int storyNum = 0; storyNum < storyList.Count; storyNum+=3 )
            {
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    var story = storyList[storyIndex];
                    storyIndex += 1;
                    var image = new Image { Source = story.Icon };
                    var quiz = new Image { Source = "QuizzesIcon.png" };
                    var think = new Image { Source = "ThinkAndDoIcon.png" };
                    var label = new Label
                    {
                        Text = story.Name,
                        //VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center
                    };
                    var horizontalStack = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Children = {
                            quiz,
                            think
                        }
                    };
                    var verticalStack = new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Children =
                        {
                            image,
                            label,
                            horizontalStack
                        }
                    };
                    
                    gridLayout.Children.Add(verticalStack, columnIndex, rowNum);
                    //gridLayout.RowDefinitions.Add(new RowDefinition());
                }
                rowNum += 2;
            }
        }

        void CreateAppealKey()
        {
            var general = new Label()
            {
                Text = "General",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var male = new Label()
            {
                Text = "Male",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var female = new Label()
            {
                Text = "Female",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var animal = new Label()
            {
                Text = "Animals",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var generalDot = new Image()
            {
                Source = "GeneralAppeal.png",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var maleDot = new Image()
            {
                Source = "MaleProtagonist.png",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var femaleDot = new Image()
            {
                Source = "FemaleProtagonist.png",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var animalDot = new Image()
            {
                Source = "AnimalAppeal.png",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            horizontalStackLayout.Orientation = StackOrientation.Horizontal;
            horizontalStackLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
            horizontalStackLayout.Children.Add(generalDot);
            horizontalStackLayout.Children.Add(general);
            horizontalStackLayout.Children.Add(animalDot);
            horizontalStackLayout.Children.Add(animal);
            horizontalStackLayout.Children.Add(femaleDot);
            horizontalStackLayout.Children.Add(female);
            horizontalStackLayout.Children.Add(maleDot);
            horizontalStackLayout.Children.Add(male);
        }
    }
}