using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BrainyStories.Objects
{
    class User
    {
        public string name { get; } = "Your child";
        public int storiesCompleted { get; } = 12;
        public int quizzesCompleted { get; } = 10;
        public int thinkAndDosCompleted { get; } = 23;
        public string lastStory { get; } = "The Lion and the Mouse";
        public int lastQuizScore { get; } = 80;
        public Dictionary<String, int> rewardsRecieved { get; } = new Dictionary<String, int>() { { "Gold", 3 }, { "Silver", 8 }, { "Bronze", 55 } };
        public static string Name { get; } = "Your child";
        public static List<Story> StoriesRead { get; set; } = new List<Story>();
        public static List<Quiz> QuizzesCompleted { get; set; } = new List<Quiz>();
        public static List<ThinkAndDo> ThinkAndDosCompleted { get; set; } = new List<ThinkAndDo>();

        public static int StoryCount { get { return StoriesRead.Count; } }
        public static int QuizCount { get { return QuizzesCompleted.Count; } }
        public static int ThinkAndDoCount { get { return ThinkAndDosCompleted.Count; } }
    }
}
