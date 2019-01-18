using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BrainyStories
{
    public class Story
    {
        public String Name { get; set; }

        public ImageSource Icon { get; set; }

        public TimeSpan Duration { get; set; }

        public int WordCount { get; set; }
    }
}
