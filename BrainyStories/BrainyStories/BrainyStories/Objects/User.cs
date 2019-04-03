using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace BrainyStories.Objects
{
    class User
    {
        [JsonIgnore]
        private static User INSTANCE = null;
        private User()
        { }
        [JsonConstructor]
        public User(Dictionary<String,int> RewardsRecieved, string Name, List<Story> StoriesRead, List<Quiz> QuizzesCompleted, List<ThinkAndDo> ThinkAndDosCompleted)
        {
            this.RewardsRecieved = RewardsRecieved;
            this.Name = Name;
            this.StoriesRead = StoriesRead;
            this.QuizzesCompleted = QuizzesCompleted;
            this.ThinkAndDosCompleted = ThinkAndDosCompleted;
        }
        public static User Instance {
            get {
                if (INSTANCE == null)
                    INSTANCE = new User();
                return INSTANCE;
            }
        }


        public Dictionary<String, int> RewardsRecieved { get; } = new Dictionary<String, int>() { { "Gold", 3 }, { "Silver", 8 }, { "Bronze", 55 } };
        public string Name { get; } = "Your child";
        public List<Story> StoriesRead { get; set; } = new List<Story>();
        public List<Quiz> QuizzesCompleted { get; set; } = new List<Quiz>();
        public List<ThinkAndDo> ThinkAndDosCompleted { get; set; } = new List<ThinkAndDo>();

        public int StoryCount { get { return StoriesRead.Count; } }
        public int QuizCount { get { return QuizzesCompleted.Count; } }
        public int ThinkAndDoCount { get { return ThinkAndDosCompleted.Count; } }

        public void SaveToDisk()
        {
            string output = JsonConvert.SerializeObject(this);
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "save.json");
            File.WriteAllText(fileName, output);
        }

        public void LoadFromDisk()
        {
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "save.json");
            if(File.Exists(fileName))
            {
                string input = File.ReadAllText(fileName);
                INSTANCE = JsonConvert.DeserializeObject<User>(input);
            }
        }
    }
}
