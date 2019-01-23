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
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Female,
                QuizNum = 2,
                ThinkDoNum = 2
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.General,
                QuizNum = 1,
                ThinkDoNum = 3
            });

            storyListTemp.Add(new Story { Name = "The Country and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 4,
                ThinkDoNum = 2
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 8,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Female,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Country Mouse and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.General,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Country and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Female,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.General,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Country and the City Mouse",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Dog and his Shadow",
                Icon = "giraffe.jpg",
                Appeal = AppealType.General,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            storyListTemp.Add(new Story { Name = "The Emperor's New Clothes",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            return storyListTemp;
        }
        
        //MANUAL LIST OF IMAGINES 
        public List<Story> generateImagines()
        {
            List<Story> imaginesListTemp = new List<Story>();

            imaginesListTemp.Add(new Story { Name = "Imagine 1",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 2",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 3",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 4",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 5",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 6",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 7",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 8",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 9",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            imaginesListTemp.Add(new Story { Name = "Imagine 10",
                Icon = "giraffe.jpg",
                Appeal = AppealType.Male,
                QuizNum = 1,
                ThinkDoNum = 1
            });

            return imaginesListTemp;
        }
    }
}
