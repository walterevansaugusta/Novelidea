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

            storyListTemp.Add(new Story {
                Name = "The Lion and the Mouse",
                Icon = "S1_LATM_1.png",
                Appeal = AppealType.Animal,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 51),
                WordCount = 395,
                Description = "A lion releases a mouse, believing it’s too small and weak ever to return the favor, " +
                              "but when the lion is trapped in a net the mouse gnaws the threads and releases the lion.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S1_LATM_1.png" },
                   { new TimeSpan(0, 0, 5), "S1_LATM_2.png" },
                   { new TimeSpan(0, 0, 32), "S1_LATM_3.png" },
                   { new TimeSpan(0, 0, 49), "S1_LATM_4.png" },
                   { new TimeSpan(0, 1, 02), "S1_LATM_5.png" },
                   { new TimeSpan(0, 1, 35), "S1_LATM_6.png" },
                   { new TimeSpan(0, 1, 56), "S1_LATM_7.png" },
                   { new TimeSpan(0, 2, 30), "S1_LATM_4.png" }
                },
                AudioClip = "I1_IAS_IG.mp3"
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
                Name = "If A Shoe Wanted to be Car",
                Icon = "I1_IASW_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 1, 47),
                WordCount = 212,
                Description = "Imagine a shoe wanting to be like a car, and what a child might find in the home to help.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I1_IASW_1.jpg" },
                   { new TimeSpan(0, 0, 8), "I1_IASW_2.jpg" },
                   { new TimeSpan(0, 0, 43), "I1_IASW_3.jpg" },
                   { new TimeSpan(0, 1, 7), "I1_IASW_4.jpg" }
                },
                AudioClip = "I1_IAS_IG.mp3"
            });

            return imaginesListTemp;
        }
    }
}
