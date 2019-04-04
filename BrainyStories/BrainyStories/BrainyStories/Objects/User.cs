using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BrainyStories.Objects
{
    class User : INotifyPropertyChanged
    {
        public string name { get; } = "Your child";
        public int storiesCompleted { get; } = 12;
        public int quizzesCompleted { get; } = 10;
        public int thinkAndDosCompleted { get; } = 23;
        public string lastStory { get; } = "The Lion and the Mouse";
        public int lastQuizScore { get; } = 80;
        public static Dictionary<String, int> rewardsRecieved { get; } = new Dictionary<String, int>() { { "Gold", 3 }, { "Silver", 8 }, { "Bronze", 55 } };
        public static string Name { get; } = "Your child";
        public static ObservableCollection<Story> StoriesRead { get; set; } = new ObservableCollection<Story>();
        public static ObservableCollection<Quiz> QuizzesCompleted { get; set; } = new ObservableCollection<Quiz>();
        public static ObservableCollection<ThinkAndDo> ThinkAndDosCompleted { get; set; } = new ObservableCollection<ThinkAndDo> ();

        public static int StoryCount { get { return StoriesRead.Count; } }
        public static int QuizCount { get { return QuizzesCompleted.Count; } }
        public static int ThinkAndDoCount { get { return ThinkAndDosCompleted.Count; } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
