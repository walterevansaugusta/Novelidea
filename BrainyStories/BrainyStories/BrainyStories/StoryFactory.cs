using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyStories
{
    public class StoryFactory
    {
        public List<Story> generateStories()
        {
            List<Story> storyListTemp = new List<Story>();
            storyListTemp.Add(new Story { Name = "The Country Mouse and the City Mouse", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 3, 44), WordCount = 434 });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 13, 08), WordCount = 2126 });
            storyListTemp.Add(new Story { Name = "The Country and the City Mouse", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Country Mouse and the City Mouse", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Country and the City Mouse", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Country and the City Mouse", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg", Duration = new TimeSpan(0, 2, 20), WordCount = 353 });

            return storyListTemp;
        }
    }
}
