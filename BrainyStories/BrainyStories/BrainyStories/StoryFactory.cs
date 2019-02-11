using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyStories
{
    

    public class StoryFactory
    {
        // MANUAL LIST OF STORIES
        public List<Story> generateStories()
        {
            List<Story> storyListTemp = new List<Story>();

            storyListTemp.Add(new Story { Name = "The Country Mouse and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 3, 44),
                WordCount = 434,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Female,
                QuizNum = 2,
                ThinkDoNum = 2,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.General,
                QuizNum = 1,
                ThinkDoNum = 3,
                Duration = new TimeSpan(0, 13, 08),
                WordCount = 2126,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Country and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 2,
                ThinkDoNum = 2,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 2,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Female,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Country Mouse and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.General,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Country and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Female,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.General,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Country and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.General,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
            });

            return storyListTemp;
        }
        
        //MANUAL LIST OF IMAGINES 
        public List<Story> generateImagines()
        {
            List<Story> imaginesListTemp = new List<Story>();

            imaginesListTemp.Add(new Story
            {
                Name = "I AM AN IMAGINE",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 1,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 20),
                WordCount = 353,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                PictureCues = new Dictionary<TimeSpan, string> {
                    { new TimeSpan(0, 0, 0), "General.png" },
                    { new TimeSpan(0,0,10), "Male.png" },
                    { new TimeSpan(0,0,20), "Female.png" }
                },
                AudioClip = "S6_BGG.mp3"
            });

            return imaginesListTemp;
        }
    }
}
