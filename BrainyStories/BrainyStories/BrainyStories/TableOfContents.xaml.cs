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
        private List<Story> imaginesList;
        public TableOfContents ()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            CreateAppealKey();
           
            StoryFactory storyFact = new StoryFactory();
            
            storyList = storyFact.generateStories();
            imaginesList = storyFact.generateImagines();
            BuildGrid(storyList);           
        }

        void BuildGrid(List<Story> storyList)
        {
            gridLayout.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            var storyIndex = 0;
            var rowNum = 0;
            for (int storyNum = 0; storyNum < storyList.Count; storyNum += 3)
            {
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    var story = storyList[storyIndex];
                    storyIndex += 1;
                    var image = new Image { Source = story.Icon, HeightRequest = 150 };
                    var label = new Label
                    {
                        Text = story.Name,
                        HorizontalTextAlignment = TextAlignment.Center,
                        HorizontalOptions = LayoutOptions.Center
                    };
                    var horizontalStack = CreateHorizontalStack(story);

                    var verticalStack = new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Fill,
                        Children =
                        {
                            image,
                            label,
                            horizontalStack
                        }
                    };
                    gridLayout.Children.Add(verticalStack, columnIndex, rowNum);
                }
                rowNum += 1;
            }
        }

        StackLayout CreateHorizontalStack(Story story)
        {
            var horizontalStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                Children = {
                            new Image { Source = story.Appeal.Value},
                        }
            };
            // Adds Quizzes icon (pencil) for each quiz in stories
            for (int i = 0; i < story.QuizNum; i++)
            {
                horizontalStack.Children.Add(new Image { Source = "QuizzesIcon.png" });
            }

            // Adds Think and Do icon (star) for each Think and Do in stories
            for (int i = 0; i < story.ThinkDoNum; i++)
            {
                horizontalStack.Children.Add(new Image { Source = "ThinkAndDoIcon.png" });
            }
            return horizontalStack;
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
                Source = "General.png",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var maleDot = new Image()
            {
                Source = "Male.png",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var femaleDot = new Image()
            {
                Source = "Female.png",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            var animalDot = new Image()
            {
                Source = "Animal.png",
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