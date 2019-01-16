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
    }
}
