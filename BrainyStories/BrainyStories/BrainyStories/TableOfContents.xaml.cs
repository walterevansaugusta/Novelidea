using DLToolkit.Forms.Controls;
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
        private List<Image> imagesList;

        private Layout<View> simpleLayout;
        private Layout<View> advancedLayout;

        private StoryFactory storyFact = new StoryFactory();

        public enum UserLayout
        {
            Simple,
            Advanced
        };

        public TableOfContents (bool imagines)
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //CreateAppealKey();
            
            if (imagines) 
            {
                storyList = storyFact.generateImagines();
            } else 
            {
                storyList = storyFact.generateStories();
            }

            fastList.FlowItemsSource = storyList;
            //BuildSimpleLayout(storyList);
            //BuildAdvancedLayout(storyList);

            //SetLayout(UserLayout.Simple);
        }

        private void BuildSimpleLayout(List<Story> stories)
        {
            //ContentView view = new ContentView();
            //fastList.FlowItemsSource = stories;
            //Grid grid = new Grid
            //{
            //    Padding = new Thickness(0, 10)
            //};

            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

            //var storyIndex = 0;
            //var rowNum = 0;

            //for (int storyNum = 0; storyNum < storyList.Count; storyNum += 3)
            //{
            //    grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            //    for (int columnIndex = 0; columnIndex < 3; columnIndex++)
            //    {
            //        var story = storyList[storyIndex];
            //        storyIndex += 1;


            //        var image = new Image { Source = story.Icon, HeightRequest = 150 };

            //        var label = new Label
            //        {
            //            Text = story.Name,
            //            HorizontalTextAlignment = TextAlignment.Center,
            //            HorizontalOptions = LayoutOptions.Center
            //        };
            //        var horizontalStack = CreateStoryActivitiesStack(story);

            //        var verticalStack = new StackLayout
            //        {
                        //Orientation = StackOrientation.Vertical,
                        //HorizontalOptions = LayoutOptions.FillAndExpand,
                        //VerticalOptions = LayoutOptions.Fill,
                        //Children =
                        //{
                        //    image,
                        //    label,
                        //    horizontalStack
                        //}
            //        };
            //        view = new ContentView
            //        {
            //            Content = verticalStack
            //        };
            //        grid.Children.Add(view, columnIndex, rowNum);
            //        var tapGestureRecognizer = new TapGestureRecognizer();
            //        tapGestureRecognizer.Tapped += (s, e) =>
            //        {
            //            ContentView clickedView = s as ContentView;
            //            //var lazyStory = new Lazy<Story>(() => storyFact.playedStory(story.Name));
            //            Navigation.PushModalAsync(new StoryPage(storyFact.playedStory(story.Name)));
            //        };
            //        view.GestureRecognizers.Add(tapGestureRecognizer);
            //        if (storyIndex >= storyList.Count)
            //        {
            //            break;
            //        }  
            //    }
            //    rowNum += 1;
            //}
            //return grid;
        }

        private Layout<View> BuildAdvancedLayout(List<Story> storyList)
        {
            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Spacing = 10
            };
            ContentView view = new ContentView();
            foreach (Story story in storyList)
            {
                Image image = new Image { Source = story.Icon, HeightRequest = 150 };
                StackLayout detailsStack = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children =
                    {
                        new Label
                        {
                            Text = story.Duration.ToString(@"mm\:ss"),
                            HorizontalTextAlignment = TextAlignment.Start,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                        },
                        CreateStoryActivitiesStack(story),
                        new Label
                        {
                            Text = story.WordCount + " words",
                            HorizontalTextAlignment = TextAlignment.End,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                        }
                    }
                };

                StackLayout infoStack = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Children =
                    {
                        new Label
                        {
                            Text = story.Name,
                            FontAttributes = FontAttributes.Bold
                        },
                        new Label
                        {
                            Text = story.Description,
                            VerticalOptions = LayoutOptions.FillAndExpand,
                        },
                        detailsStack
                    }
                };

                StackLayout storyStack = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Children =
                    {
                        image,
                        infoStack
                    },
                };
                view = new ContentView
                {
                    Content = storyStack
                };
                stackLayout.Children.Add(view);
                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += (s, e) =>
                {
                    ContentView clickedView = s as ContentView;
                    Navigation.PushModalAsync(new StoryPage(story));
                };
                view.GestureRecognizers.Add(tapGestureRecognizer);
            }

            return stackLayout;
        }

        StackLayout CreateStoryActivitiesStack(Story story)
        {
            var verticalStack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Fill
            };
            var horizontalStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
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
            verticalStack.Children.Add(horizontalStack);
            
            return verticalStack;
        }

        private List<Image> ListOfImages(Story story)
        {
            imagesList = new List<Image>();
            for (int i = 0; i < story.QuizNum; i++)
            {
                imagesList.Add(new Image { Source = "QuizzesIcon.png" });
            }
            for (int i = 0; i < story.ThinkDoNum; i++)
            {
                imagesList.Add(new Image { Source = "ThinkAndDoIcon.png" });
            }
            return imagesList;
        }

        //void CreateAppealKey()
        //{
        //    var general = new Label()
        //    {
        //        Text = "General",
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //    };

        //    var male = new Label()
        //    {
        //        Text = "Male",
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //    };

        //    var female = new Label()
        //    {
        //        Text = "Female",
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //    };

        //    var animal = new Label()
        //    {
        //        Text = "Animals",
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //    };

        //    var generalDot = new Image()
        //    {
        //        Source = "General.png",
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //    };

        //    var maleDot = new Image()
        //    {
        //        Source = "Male.png",
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //    };

        //    var femaleDot = new Image()
        //    {
        //        Source = "Female.png",
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //    };

        //    var animalDot = new Image()
        //    {
        //        Source = "Animal.png",
        //        HorizontalOptions = LayoutOptions.FillAndExpand,
        //    };

        //    Switch advancedSwitch = new Switch();
        //    advancedSwitch.Toggled += LayoutToggled;

        //    appealKeyStackLayout.Orientation = StackOrientation.Horizontal;
        //    appealKeyStackLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
        //    appealKeyStackLayout.Children.Add(generalDot);
        //    appealKeyStackLayout.Children.Add(general);
        //    appealKeyStackLayout.Children.Add(animalDot);
        //    appealKeyStackLayout.Children.Add(animal);
        //    appealKeyStackLayout.Children.Add(femaleDot);
        //    appealKeyStackLayout.Children.Add(female);
        //    appealKeyStackLayout.Children.Add(maleDot);
        //    appealKeyStackLayout.Children.Add(male);
        //    appealKeyStackLayout.Children.Add(advancedSwitch);
        //}

        //private void LayoutToggled(object sender, ToggledEventArgs e)
        //{
        //    if (e.Value)
        //    {
        //        SetLayout(UserLayout.Advanced);
        //    }
        //    else
        //        SetLayout(UserLayout.Simple);
        //}

        //public void SetLayout(UserLayout layout)
        //{
        //    switch (layout)
        //    {
        //        case UserLayout.Simple:
        //            scrollView.IsVisible = true;
        //            //scrollViewAdvanced.IsVisible = false;
        //            break;
        //        case UserLayout.Advanced:
        //            scrollView.IsVisible = false;
        //            //scrollViewAdvanced.IsVisible = true;
        //            break;
        //    }
        //}
    }
}