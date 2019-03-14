using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using BrainyStories.Objects;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace BrainyStories
{
    public class AppealType
    {
        private AppealType(string value) { Value = value; }

        public string Value { get; set; }

        public static AppealType Male { get { return new AppealType("Male.png"); } }
        public static AppealType Female { get { return new AppealType("Female.png"); } }
        public static AppealType General { get { return new AppealType("General.png"); } }
        public static AppealType Animal { get { return new AppealType("Animal.png"); } }
    }

    public class Story {
        // Name of story/imagine

        public String Name { get; set; }

        // Image clip for icon
        public ImageSource Icon { get; set; }

        public TimeSpan Duration { get; set; }

        public int WordCount { get; set; }

        public String Description { get; set; }

        // Appeal type for colored dots
        public AppealType Appeal { get; set; }

        // Number of quizzes for story/imagine
        public int QuizNum { get; set; } = 0;

        // Number of think and do exercises
        public int ThinkDoNum { get; set; } = 0;

        // Dictionary of cues for quizzes to quizzes
        public Dictionary<TimeSpan, Quiz> QuizCues { get; set; }

        // Dictionary of cues for picture transition to pictures
        public Dictionary<TimeSpan, String> PictureCues { get; set; }

        // Think and do list
        public ObservableCollection<ThinkAndDo> ThinkAndDos { get; set; } = new ObservableCollection<ThinkAndDo>();

        // Number of think and do's that have been completed
        public int NumCompletedThinkAndDos { get { return ThinkAndDos.Count(t => t.Completed); } }

        // Quiz list
        public ObservableCollection<Quiz> Quizzes { get; set; } = new ObservableCollection<Quiz>();

        // Number of quizzes that have been completed
        public int NumCompletedQuizzes { get { return Quizzes.Count(q => q.NumAttemptsQuiz > 0); } }

        // Average score of completed quizzes, or 0 if there are no completed quizzes
        public double QuizAvgScore { get { return NumCompletedQuizzes > 0 ? Quizzes.Average(q => q.Score) : 0; } }

        //String for audio file
        public String AudioClip { get; set; }

        //List of Stories
        public static ObservableCollection<Story> ListOfStories { get; set; }

        //List of Icon Images
        public ObservableCollection<String> ListOfIcons { get; set; }
    }
}
