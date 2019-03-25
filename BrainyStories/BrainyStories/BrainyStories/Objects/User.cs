using System;
using System.Collections.Generic;
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

        public static List<Story> Stories { get; set; } = new List<Story>();
    }
}
