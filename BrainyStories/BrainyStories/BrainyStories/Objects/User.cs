using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace BrainyStories.Objects
{
    class User
    {
        private static User INSTANCE = null;
        private User()
        { }
        public static User Instance {
            get {
                if (INSTANCE == null)
                    INSTANCE = new User();
                return INSTANCE;
            }
        }


        public Dictionary<String, int> RewardsRecieved { get; } = new Dictionary<String, int>() { { "Gold", 3 }, { "Silver", 8 }, { "Bronze", 55 } };
        public string Name { get; } = "Your child";
        public ObservableCollection<Story> StoriesRead { get; set; } = new ObservableCollection<Story>();
        public ObservableCollection<Quiz> QuizzesCompleted { get; set; } = new ObservableCollection<Quiz>();
        public ObservableCollection<ThinkAndDo> ThinkAndDosCompleted { get; set; } = new ObservableCollection<ThinkAndDo>();

        public int StoryCount { get { return StoriesRead.Count; } }
        public int QuizCount { get { return QuizzesCompleted.Count; } }
        public int ThinkAndDoCount { get { return ThinkAndDosCompleted.Count; } }

        public void SaveToDisk()
        {
            string output = JsonConvert.SerializeObject(this);
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "save.json");
            File.WriteAllText(fileName, output);
        }
    }
}
