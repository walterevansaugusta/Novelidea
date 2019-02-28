using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
        StoryFactory storyFact = new StoryFactory();

        public TableOfContents (bool imagines)
		{
            NavigationPage.SetHasNavigationBar(this, false);
            if (imagines)
            {
                Story.ListOfStories = storyFact.generateImagines();
            }
            else
            {
                Story.ListOfStories = storyFact.generateStories();
            }
            InitializeComponent();
        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView view = (ListView)sender;
            var story = view.SelectedItem;
            Navigation.PushAsync(new StoryPage((Story)story));
        }
    }
}