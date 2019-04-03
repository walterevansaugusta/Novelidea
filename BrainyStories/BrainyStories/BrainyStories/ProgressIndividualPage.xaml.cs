using BrainyStories.Objects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrainyStories
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgressIndividualPage : ContentPage
	{
		public ProgressIndividualPage ()
		{
			InitializeComponent ();
            BindingContext = User.Instance;
		}
	}
}