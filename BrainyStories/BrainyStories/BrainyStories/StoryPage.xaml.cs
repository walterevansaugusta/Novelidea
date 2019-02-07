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
            NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}