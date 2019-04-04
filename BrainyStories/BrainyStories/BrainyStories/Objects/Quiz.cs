using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BrainyStories.Objects {
    public class Question
    {
        // The text of the question
        public string QuestionText { get; set; }

        // the array of answers 
        public ObservableCollection <String> AnswerArray { get; set; }

        // the dictonary of which number of answer and if the child has slected it (keys same as answer array)
        public Dictionary<String, bool> AnswerSelected { get; set; }

        //the index of the correct answer in the array
        public String CorrectAnswer { get; set; }

    }
    public class Quiz {
        public static string Icon { get; } = "QuizzesIcon.png";

        // The name of th quiz
        public string QuizName { get; set; }

        //String for Associated Story
        public String AssociatedImage { get; set; }

        // the score for the quiz
        public double Score { get; set; }

        // the list of questions
        public ObservableCollection<Question> Questions { get; set; }

        // the time the quiz should be played
        public TimeSpan PlayTime { get; set; }

        // The number of questions
        public int NumQuestions { get; set; }

        // Number of attempts for each question
        public ObservableCollection<int> NumAttempts { get; set; }

        // Number of attempts on the entire quiz
        public int NumAttemptsQuiz { get; set; }
    }
}
