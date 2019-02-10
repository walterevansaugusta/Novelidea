using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;

namespace BrainyStories
{
    

    public class StoryFactory
    {
        public List<Story> generateStories()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(StoryFactory)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("BrainyStories.stories.json");
            Story[] stories;
            using(var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                stories = JsonConvert.DeserializeObject<Story[]>(json);
                //var test = JsonConvert.DeserializeObject(json);
            }
            stream.Close();
            return new List<Story>();
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
