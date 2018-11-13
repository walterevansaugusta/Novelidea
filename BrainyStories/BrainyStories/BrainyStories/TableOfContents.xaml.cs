using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public TableOfContents ()
		{
			InitializeComponent();
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var viewModel = BindingContext as TableOfContentsModel;

            var story = e.Item as Story;

            viewModel.HideShowRead(story);
        }
    }
}