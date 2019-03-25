using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BrainyStories.Objects
{
    class User
    {
        public static string Name { get; } = "Your child";
        public static List<Story> StoriesRead { get; set; } = new List<Story>();
        public static List<Quiz> QuizzesCompleted { get; set; } = new List<Quiz>();
        public static List<ThinkAndDo> ThinkAndDosCompleted { get; set; } = new List<ThinkAndDo>();

        public static int StoryCount { get { return StoriesRead.Count; } }
        public static int QuizCount { get { return QuizzesCompleted.Count; } }
        public static int ThinkAndDoCount { get { return ThinkAndDosCompleted.Count; } }
    }
}
