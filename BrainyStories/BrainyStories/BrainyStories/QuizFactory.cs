using BrainyStories.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BrainyStories
{
    public class QuizFactory
    {
        public ObservableCollection<Quiz> GenerateQuizzes(String storyName)
        {
            ObservableCollection<Quiz> QuizTemp = new ObservableCollection<Quiz>();

            // Quizzes for The Lion and the Mouse 
            if (storyName.Equals("The Lion and the Mouse"))
            {
               // Quiz 1
               QuizTemp.Add( new Quiz()
                {
                    QuizName = "The Lion and the Mouse Quiz 1",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: After a big meal the lion felt drowsy and what?",
                            AnswerArray = new ObservableCollection<string>() { "lazy", "angry", "forgetful", "sick" },
                            AnswerSelected = new Dictionary<string, bool>() { { "lazy", false }, { "angry", false }, { "forgetful", false }, { "sick", false} },
                            CorrectAnswer = "lazy"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: What part of the mouse does the lion put his paw on to trap him?",
                            AnswerArray =  new ObservableCollection<string>() { "ear", "foot", "nose", "tail" },
                            AnswerSelected = new Dictionary<string, bool>() { { "ear", false }, { "foot", false }, { "nose", false }, { "tail", false} },
                            CorrectAnswer = "tail"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The lion said the mouse ruined his what?",
                            AnswerArray =  new ObservableCollection<string>() { "nap", "work", "hunt", "dance" },
                            AnswerSelected = new Dictionary<string, bool>() { { "nap", false }, { "work", false }, { "hunt", false }, {"dance", false} },
                            CorrectAnswer = "nap"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The lion told the mouse: Now you get to be my what?",
                            AnswerArray =  new ObservableCollection<string>() { "teacher", "dessert", "toy", "pillow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "teacher", false }, { "dessert", false }, { "toy", false }, {"pillow", false} },
                            CorrectAnswer = "dessert"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: How did the mouse feel when the huge lion’s eyes glared at him?",
                            AnswerArray =  new ObservableCollection<string>() { "happy", "sleepy", "afraid", "sad" },
                            AnswerSelected = new Dictionary<string, bool>() { { "happy", false }, { "sleepy", false }, { "afraid", false }, {"sad", false} },
                            CorrectAnswer = "afraid"
                        }
                    },
                    PlayTime = new TimeSpan(0, 0, 49),
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                //Quiz Two
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Lion and the Mouse Quiz 2",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The lion said he was the great what of beasts?",
                            AnswerArray = new ObservableCollection<string>() { "Sillicat", "King", "Uncle", "Grumpybear" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Sillicat", false }, { "King", false }, { "Uncle", false }, { "Grumpybear", false} },
                            CorrectAnswer = "King"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The lion said, You’re too small even for a good what?",
                            AnswerArray =  new ObservableCollection<string>() { "snack", "kitten", "toy", "baby" },
                            AnswerSelected = new Dictionary<string, bool>() { { "snack", false }, { "kitten", false }, { "toy", false }, { "baby", false} },
                            CorrectAnswer = "snack"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Hunters trapped the lion in a big what?",
                            AnswerArray =  new ObservableCollection<string>() { "barn", "puddle", "net", "sandbox" },
                            AnswerSelected = new Dictionary<string, bool>() { { "barn", false }, { "puddle", false }, { "net", false }, {"sandbox", false} },
                            CorrectAnswer = "net"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: What did the hunters hang the lion from?",
                            AnswerArray =  new ObservableCollection<string>() { "windmill", "bridge", "chimney", "tree" },
                            AnswerSelected = new Dictionary<string, bool>() { { "windmill", false }, { "bridge", false }, { "chimney", false }, {"tree", false} },
                            CorrectAnswer = "tree"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The lion asked how a tiny little nobody could do a what for him?",
                            AnswerArray =  new ObservableCollection<string>() { "cartwheel", "favor", "dance", "juggle" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cartwheel", false }, { "favor", false }, { "dance", false }, {"juggle", false} },
                            CorrectAnswer = "favor"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 02),
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                //Quiz Three
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Lion and the Mouse Quiz 3",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: What did the mouse hear the lion do?",
                            AnswerArray = new ObservableCollection<string>() { "roar", "whistle", "sing", "burp" },
                            AnswerSelected = new Dictionary<string, bool>() { { "roar", false }, { "whistle", false }, { "sing", false }, { "burp", false} },
                            CorrectAnswer = "roar"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The mouse hopped onto what part of the lion?",
                            AnswerArray =  new ObservableCollection<string>() { "tail", "shoulder", "head", "rump" },
                            AnswerSelected = new Dictionary<string, bool>() { { "tail", false }, { "shoulder", false }, { "head", false }, { "rump", false} },
                            CorrectAnswer = "head"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The mouse chewed and nipped away until what snapped?",
                            AnswerArray =  new ObservableCollection<string>() { "rope", "tail", "tent", "cobweb" },
                            AnswerSelected = new Dictionary<string, bool>() { { "rope", false }, { "tail", false }, { "tent", false }, {"cobweb", false} },
                            CorrectAnswer = "rope"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Right after he helped the lion, how did the mouse probably feel?",
                            AnswerArray =  new ObservableCollection<string>() { "proud", "sad", "sleepy", "bored" },
                            AnswerSelected = new Dictionary<string, bool>() { { "proud", false }, { "sad", false }, { "sleepy", false }, {"bored", false} },
                            CorrectAnswer = "proud"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: How did the mouse and the lion feel at the end of the story?",
                            AnswerArray =  new ObservableCollection<string>() { "angry", "afraid", "hungry", "friendly" },
                            AnswerSelected = new Dictionary<string, bool>() { { "angry", false }, { "afraid", false }, { "hungry", false }, {"friendly", false} },
                            CorrectAnswer = "friendly"
                        }
                    },
                    PlayTime = new TimeSpan(0, 2, 30),
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }
            else if (storyName.Equals("The Little Red Hen"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Hen Quiz 1",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: After a big meal the lion felt drowsy and what?",
                            AnswerArray = new ObservableCollection<string>() { "lazy", "angry", "forgetful", "sick" },
                            AnswerSelected = new Dictionary<string, bool>() { { "lazy", false }, { "angry", false }, { "forgetful", false }, { "sick", false} },
                            CorrectAnswer = "lazy"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: What part of the mouse does the lion put his paw on to trap him?",
                            AnswerArray =  new ObservableCollection<string>() { "ear", "foot", "nose", "tail" },
                            AnswerSelected = new Dictionary<string, bool>() { { "ear", false }, { "foot", false }, { "nose", false }, { "tail", false} },
                            CorrectAnswer = "tail"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The lion said the mouse ruined his what?",
                            AnswerArray =  new ObservableCollection<string>() { "nap", "work", "hunt", "dance" },
                            AnswerSelected = new Dictionary<string, bool>() { { "nap", false }, { "work", false }, { "hunt", false }, {"dance", false} },
                            CorrectAnswer = "nap"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The lion told the mouse: Now you get to be my what?",
                            AnswerArray =  new ObservableCollection<string>() { "teacher", "dessert", "toy", "pillow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "teacher", false }, { "dessert", false }, { "toy", false }, {"pillow", false} },
                            CorrectAnswer = "dessert"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: How did the mouse feel when the huge lion’s eyes glared at him?",
                            AnswerArray =  new ObservableCollection<string>() { "happy", "sleepy", "afraid", "sad" },
                            AnswerSelected = new Dictionary<string, bool>() { { "happy", false }, { "sleepy", false }, { "afraid", false }, {"sad", false} },
                            CorrectAnswer = "afraid"
                        }
                    },
                    PlayTime = new TimeSpan(0, 0, 49),
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }
            else if (storyName.Equals("The Boy Who Cried Wolf"))
            {
               
            }
            else if (storyName.Equals("The Elves and Shoemaker"))
            {
               
            }
            else if (storyName.Equals("The Three Little Pigs"))
            {
                
            }
            else if (storyName.Equals("The Three Billy Goats Gruff"))
            {
                
            }
            else if (storyName.Equals("The Tale of Peter Rabbit"))
            {
                
            }
            else if (storyName.Equals("The Gingerbread Man"))
            {
               
            }
            else if (storyName.Equals("Rumplestiltskin"))
            {
                
            }
            else if (storyName.Equals("Little Red Riding Hood"))
            {
                
            }
            return QuizTemp;
        }
    }
}
