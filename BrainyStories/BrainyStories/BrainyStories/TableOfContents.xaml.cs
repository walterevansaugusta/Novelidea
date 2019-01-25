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

        private Layout<View> simpleLayout;
        private Layout<View> advancedLayout;

        public enum UserLayout
        {
            Simple,
            Advanced
        };

        public TableOfContents ()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            CreateAppealKey();
           
            StoryFactory storyFact = new StoryFactory();
            
            storyList = storyFact.generateStories();
            imaginesList = storyFact.generateImagines();

            simpleLayout = BuildSimpleLayout(storyList);
            advancedLayout = BuildSimpleLayout(storyList);

            SetLayout(UserLayout.Simple);
        }

        private Layout<View> BuildSimpleLayout(List<Story> stories)
        {
            Grid grid = new Grid
            {
                Padding = new Thickness(0, 10)
            };
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            var storyIndex = 0;
            var rowNum = 0;

            for (int storyNum = 0; storyNum < storyList.Count; storyNum += 3)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

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
                    var horizontalStack = CreateStoryActivitiesStack(story);

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
                    grid.Children.Add(verticalStack, columnIndex, rowNum);
                }

                rowNum += 1;
            }

            return grid;
        }

        StackLayout CreateStoryActivitiesStack(Story story)
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

            appealKeyStackLayout.Orientation = StackOrientation.Horizontal;
            appealKeyStackLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
            appealKeyStackLayout.Children.Add(generalDot);
            appealKeyStackLayout.Children.Add(general);
            appealKeyStackLayout.Children.Add(animalDot);
            appealKeyStackLayout.Children.Add(animal);
            appealKeyStackLayout.Children.Add(femaleDot);
            appealKeyStackLayout.Children.Add(female);
            appealKeyStackLayout.Children.Add(maleDot);
            appealKeyStackLayout.Children.Add(male);
        }

        private void LayoutToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                SetLayout(UserLayout.Advanced);
            }
            else
                SetLayout(UserLayout.Simple);
        }

        public void SetLayout(UserLayout layout)
        {
            switch (layout)
            {
                case UserLayout.Simple:
                    scrollView.Content = simpleLayout;
                    break;
                case UserLayout.Advanced:
                    scrollView.Content = advancedLayout;
                    break;
            }
        }
    }
}