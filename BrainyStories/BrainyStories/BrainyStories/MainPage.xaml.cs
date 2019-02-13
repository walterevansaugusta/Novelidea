using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BrainyStories {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        
        // Imagines TOC
        // Argument: True = Imagines, False = Stories
        async void ImaginesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TableOfContents(true));
        }

        // Stories TOC
        // Argument: True = Imagines, False = Stories
        async void StoriesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TableOfContents(false));
        }
    }
}
