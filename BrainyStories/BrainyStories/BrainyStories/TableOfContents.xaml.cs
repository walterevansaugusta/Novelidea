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
        public TableOfContents ()
		{
			InitializeComponent();
		}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var viewModel = BindingContext as TableOfContentsModel;

            var story = e.Item as Story;
            var grid = this.FindByName("ButtonGrid");
            Console.WriteLine(grid);
            viewModel.HideShowRead(story);
        }
    }

    public class StatusToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, null))
                return new GridLength(0);

            var story = value as Story;

            if (story.CanRead)
            {
                return new GridLength(0);
            }
            else
            {
                return new GridLength(1, GridUnitType.Auto);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException("Only one way bindings are supported with this converter");
        }
    }
}
