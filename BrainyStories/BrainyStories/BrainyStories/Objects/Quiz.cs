using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyStories.Objects {
    public class Question
    {
        // The text of the question
        public string QuestionText { get; set; }

        // the array of answers
        public string[] AnswerArray { get; set; }

        //the index of the correct answer in the array
        public int CorrectAnswer { get; set; }

    }
    public class Quiz {

        // the score for the quiz
        public int Score { get; set; }

        // the list of questions
        public Question[] Questions { get; set; }
    }
}
