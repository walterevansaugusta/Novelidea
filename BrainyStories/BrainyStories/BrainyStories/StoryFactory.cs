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
            storyListTemp.Add(new Story { Name = "The Country Mouse and the City Mouse", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Country and the City Mouse", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Country Mouse and the City Mouse", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Country and the City Mouse", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Country and the City Mouse", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Dog and his Shadow", Icon = "giraffe.jpg" });
            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes", Icon = "giraffe.jpg" });

            return storyListTemp;
        }
        
        public List<Story> generateImagines()
        {
            List<Story> imaginesListTemp = new List<Story>();
            imaginesListTemp.Add(new Story { Name = "Imagine 1", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 2", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 3", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 4", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 5", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 6", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 7", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 8", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 9", Icon = "giraffe.jpg" });
            imaginesListTemp.Add(new Story { Name = "Imagine 10", Icon = "giraffe.jpg" });

            return imaginesListTemp;
        }
    }
}
