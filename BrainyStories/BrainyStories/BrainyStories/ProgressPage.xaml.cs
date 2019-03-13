using BrainyStories.Objects;
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
    public partial class ProgressPage : ContentPage
    {
        public ProgressPage()
        {
            InitializeComponent();
            User.Stories.Add(new StoryFactory().generateStories().ToArray()[0]);
        }

        private void IndividualClicked(object sender, EventArgs e)
        {
            introLayout.IsVisible = false;
            individualLayout.IsVisible = true;
            overallLayout.IsVisible = false;
        }

        private void OverallClicked(object sender, EventArgs e)
        {
            introLayout.IsVisible = false;
            individualLayout.IsVisible = false;
            overallLayout.IsVisible = true;
        }
    }
}