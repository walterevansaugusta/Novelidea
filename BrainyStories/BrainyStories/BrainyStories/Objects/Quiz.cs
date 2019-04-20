using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BrainyStories.Objects {

    // Question class used by the Quiz Class
    public class Question
    {
        // String text of the question
        public string QuestionText { get; set; }

        // Observable Collection of the questions 
        public ObservableCollection <String> AnswerArray { get; set; }

        // Dictonary of which number of answer and if the child has slected it (keys same as answer array)
        public Dictionary<String, bool> AnswerSelected { get; set; }

        // String of the correct answer in the array
        public String CorrectAnswer { get; set; }

        // String of the question audio file
        public String Audio { get; set; }

    }

    // The Quiz Class
    public class Quiz {

        // String of the quiz icon used in the table of contents
        public static string Icon { get; } = "QuizzesIcon.png";

        // String of the name of the quiz
        public string QuizName { get; set; }

        // String for Associated Story
        public String AssociatedImage { get; set; }

        // Double of the score for the quiz
        public double Score { get; set; }

        // Observable Collection of the quiz questions
        public ObservableCollection<Question> Questions { get; set; }

        // Timespan for the quiz should be played
        public TimeSpan PlayTime { get; set; }

        // Int for the number of questions
        public int NumQuestions { get; set; }

        // Observable Collection of the number of attempts for each question
        public ObservableCollection<int> NumAttempts { get; set; }

        // Int of the number of attempts on the entire quiz
        public int NumAttemptsQuiz { get; set; }
    }
}
