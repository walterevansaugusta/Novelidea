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
        private Grid simpleGridLayout;
        private Grid advancedGridLayout;

        public enum UserLayout
        {
            Simple,
            Advanced
        };

        public TableOfContents ()
		{
			InitializeComponent();

            // TO-DO: 
            // make these into their own class for better code
            // add icons below title for quizes and home expierences
            /// add clickability

            StoryFactory storyFact = new StoryFactory();
            storyList = storyFact.generateStories();

            simpleGridLayout = BuildGrid(new Grid(), UserLayout.Simple);
            advancedGridLayout = BuildGrid(new Grid(), UserLayout.Advanced);

            PopulateGrid(simpleGridLayout, storyList, UserLayout.Simple);
            PopulateGrid(advancedGridLayout, storyList, UserLayout.Advanced);

            SetLayout(UserLayout.Simple);
        }


        public void SetLayout(UserLayout layout)
        {
            switch(layout)
            {
                case UserLayout.Simple:
                    scrollView.Content = simpleGridLayout;
                    break;
                case UserLayout.Advanced:
                    scrollView.Content = advancedGridLayout;
                    break;
            }
        }

        private Grid BuildGrid(Grid grid, UserLayout layout)
        {
            // All layouts require atleast 3 columns
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            // Advanced layout requires an additional 3 columns, total of 6
            if(layout == UserLayout.Advanced)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            return grid;
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

        private void PopulateGrid(Grid grid, List<Story> stories, UserLayout layout)
        {
            var storyIndex = 0;
            var rowNum = grid.RowDefinitions.Count;
            for (int storyNum = 0; storyNum < storyList.Count; storyNum += 3)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                if(layout == UserLayout.Advanced)
                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    var story = storyList[storyIndex];
                    storyIndex += 1;
                    var image = new Image {
                        Source = story.Icon,
                        Aspect = Aspect.AspectFit
                    };

                    var label = new Label
                    {
                        Text = story.Name,
                        //VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center
                    };

                    int column = columnIndex;
                    int columnSpan = 1;
                    if(layout == UserLayout.Advanced)
                    {
                        column = columnIndex * 2;
                        columnSpan = 2;
                    }

                    grid.Children.Add(image, column, column + columnSpan, rowNum, rowNum + 1);
                    grid.Children.Add(label, column, column + columnSpan, rowNum + 1, rowNum + 2);

                    if(layout == UserLayout.Advanced)
                    {
                        Label durationLabel = new Label
                        {
                            Text = story.Duration.ToString(@"mm\:ss"),
                            HorizontalOptions = LayoutOptions.Center
                        };

                        Label wordCountLabel = new Label
                        {
                            Text = story.WordCount + " words",
                            HorizontalOptions = LayoutOptions.Center
                        };

                        grid.Children.Add(durationLabel, column, rowNum + 2);
                        grid.Children.Add(wordCountLabel, column + 1, rowNum + 2);
                    }
                }
                switch(layout)
                {
                    case UserLayout.Simple:
                        rowNum += 2;
                        break;
                    case UserLayout.Advanced:
                        rowNum += 3;
                        break;
                }
            }
        }
    }
}