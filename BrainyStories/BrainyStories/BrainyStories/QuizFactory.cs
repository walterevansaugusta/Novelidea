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
                    PlayTime = new TimeSpan(0, 0, 49), //TODO: might need to change time
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
                    PlayTime = new TimeSpan(0, 1, 02), // TODO: might need to change time
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
                    PlayTime = new TimeSpan(0, 2, 30), // TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for The Little Red Hen
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
                            QuestionText = "Question 1: What kind of fat grain did the little red hen find when she scratched in the yard?",
                            AnswerArray = new ObservableCollection<string>() { "wheat", "popcorn", "wild rice", "oats" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wheat", false }, { "popcorn", false }, { "wild rice", false }, { "oats", false} },
                            CorrectAnswer = "wheat"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: When the hen found the grain she thought, I won’t eat it—I’ll do what to it?",
                            AnswerArray =  new ObservableCollection<string>() { "burn", "hug", "plant", "throw" },
                            AnswerSelected = new Dictionary<string, bool>() { { "burn", false }, { "hug", false }, { "plant", false }, { "throw", false} },
                            CorrectAnswer = "plant"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: What animal liked to swim?",
                            AnswerArray =  new ObservableCollection<string>() { "cat", "duck", "dog", "hen" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cat", false }, { "duck", false }, { "dog", false }, {"hen", false} },
                            CorrectAnswer = "duck"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: What animal liked to tease other animals?",
                            AnswerArray =  new ObservableCollection<string>() { "duck", "dog", "cat", "hen" },
                            AnswerSelected = new Dictionary<string, bool>() { { "duck", false }, { "dog", false }, { "cat", false }, {"hen", false} },
                            CorrectAnswer = "cat"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: What animal liked to nap?",
                            AnswerArray =  new ObservableCollection<string>() { "cat", "dog", "hen", "duck" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cat", false }, { "dog", false }, { "hen", false }, {"duck", false} },
                            CorrectAnswer = "dog"
                        }
                    },
                    PlayTime = new TimeSpan(0, 0, 24), // TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Hen Quiz 2",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The grain of wheat grew into a green stalk that then turned what color?",
                            AnswerArray = new ObservableCollection<string>() { "black", "purple", "blue", "yellow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "black", false }, { "purple", false }, { "blue", false }, { "yellow", false} },
                            CorrectAnswer = "yellow"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: What did the hen first do to the grains when they grew fat and golden yellow?",
                            AnswerArray =  new ObservableCollection<string>() { "harvest", "paint", "hide", "kiss" },
                            AnswerSelected = new Dictionary<string, bool>() { { "harvest", false }, { "paint", false }, { "hide", false }, { "kiss", false} },
                            CorrectAnswer = "harvest"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The cat wanted to tease the rat and also what birds?",
                            AnswerArray =  new ObservableCollection<string>() { "ducks", "sparrows", "geese", "seagulls" },
                            AnswerSelected = new Dictionary<string, bool>() { { "ducks", false }, { "sparrows", false }, { "geese", false }, {"seagulls", false} },
                            CorrectAnswer = "sparrows"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Who helped the hen take the wheat grains to be ground into white powder called 	flour?",
                            AnswerArray =  new ObservableCollection<string>() { "duck", "dog", "cat", "nobody" },
                            AnswerSelected = new Dictionary<string, bool>() { { "duck", false }, { "dog", false }, { "cat", false }, {"nobody", false} },
                            CorrectAnswer = "nobody"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Where did the hen take the wheat grains to be ground into smooth white flour?",
                            AnswerArray =  new ObservableCollection<string>() { "throne", "moon", "mill", "town" },
                            AnswerSelected = new Dictionary<string, bool>() { { "throne", false }, { "moon", false }, { "mill", false }, {"town", false} },
                            CorrectAnswer = "mill"
                        }
                    },
                    PlayTime = new TimeSpan(0, 0, 55), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Hen Quiz 3",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Who helped the hen in the story?",
                            AnswerArray = new ObservableCollection<string>() { "duck", "cat", "dog", "nobody" },
                            AnswerSelected = new Dictionary<string, bool>() { { "duck", false }, { "cat", false }, { "dog", false }, { "nobody", false} },
                            CorrectAnswer = "nobody"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Who ate the bread in the end?",
                            AnswerArray =  new ObservableCollection<string>() { "duck", "cat", "hen", "dog" },
                            AnswerSelected = new Dictionary<string, bool>() { { "duck", false }, { "cat", false }, { "hen", false }, { "dog", false} },
                            CorrectAnswer = "hen"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: How did the hen probably feel about all that she had done?",
                            AnswerArray =  new ObservableCollection<string>() { "sad", "proud", "frightened", "sorry" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sad", false }, { "proud", false }, { "frightened", false }, {"sorry", false} },
                            CorrectAnswer = "proud"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: How did the duck, cat, and dog probably feel about what they had done?",
                            AnswerArray =  new ObservableCollection<string>() { "proud", "frightened", "sorry", "happy" },
                            AnswerSelected = new Dictionary<string, bool>() { { "proud", false }, { "frightened", false }, { "sorry", false }, {"happy", false} },
                            CorrectAnswer = "sorry"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The hen could eat the bread because she did what that the other animals didn’t do?",
                            AnswerArray =  new ObservableCollection<string>() { "work", "nap", "dance", "juggle" },
                            AnswerSelected = new Dictionary<string, bool>() { { "work", false }, { "nap", false }, { "dance", false }, {"juggle", false} },
                            CorrectAnswer = "work"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 36), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for The Boy Who Cried Wolf
            else if (storyName.Equals("The Boy Who Cried Wolf"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Boy Who Cried Wolf Quiz 1",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: What kind of animals did the boy watch over?",
                            AnswerArray = new ObservableCollection<string>() { "pigs", "sheep", "ducks", "horses" },
                            AnswerSelected = new Dictionary<string, bool>() { { "pigs", false }, { "sheep", false }, { "ducks", false }, { "horses", false} },
                            CorrectAnswer = "sheep"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: How did the boy feel when he was watching the sheep?",
                            AnswerArray =  new ObservableCollection<string>() { "bored", "angry", "sad", "hungry" },
                            AnswerSelected = new Dictionary<string, bool>() { { "bored", false }, { "angry", false }, { "sad", false }, { "hungry", false} },
                            CorrectAnswer = "bored"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: To get the people to come, the boy cried wolf and what did he blow?",
                            AnswerArray =  new ObservableCollection<string>() { "balloon", "cobweb", "fire", "horn" },
                            AnswerSelected = new Dictionary<string, bool>() { { "balloon", false }, { "cobweb", false }, { "fire", false }, {"horn", false} },
                            CorrectAnswer = "horn"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4:  How did the people feel the first time when they saw the wolf had not come?",
                            AnswerArray =  new ObservableCollection<string>() { "bored", "frightened", "angry", "hungry" },
                            AnswerSelected = new Dictionary<string, bool>() { { "bored", false }, { "frightened", false }, { "angry", false }, {"hungry", false} },
                            CorrectAnswer = "angry"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The boy felt embarrassed and what after the people saw the wolf had not come?",
                            AnswerArray =  new ObservableCollection<string>() { "angry", "hungry", "afraid", "ashamed" },
                            AnswerSelected = new Dictionary<string, bool>() { { "angry", false }, { "hungry", false }, { "afraid", false }, {"ashamed", false} },
                            CorrectAnswer = "ashamed"
                        }
                    },
                    PlayTime = new TimeSpan(0, 0, 34), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Boy Who Cried Wolf Quiz 2",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: When the boy saw a shadow in the bushes, what did he hope it was?",
                            AnswerArray = new ObservableCollection<string>() { "wolf", "lamb", "duck", "dog" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wolf", false }, { "lamb", false }, { "duck", false }, { "dog", false} },
                            CorrectAnswer = "wolf"
                        },
                        new Question() //TODO: Change question to make sense - ask Walter?
                        {
                            QuestionText = "Question 2: The second time the people saw that the wolf had not come they did some things, but what did they not do to the boy?",
                            AnswerArray =  new ObservableCollection<string>() { "hide", "hug", "lick", "scold" },
                            AnswerSelected = new Dictionary<string, bool>() { { "hide", false }, { "hug", false }, { "lick", false }, { "scold", false} },
                            CorrectAnswer = "scold"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: When the wolf leapt from the rock what did he attack?",
                            AnswerArray =  new ObservableCollection<string>() { "boy", "lamb", "piglet", "bunny" },
                            AnswerSelected = new Dictionary<string, bool>() { { "boy", false }, { "lamb", false }, { "piglet", false }, {"bunny", false} },
                            CorrectAnswer = "lamb"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The wolf dragged a lamb into the what?",
                            AnswerArray =  new ObservableCollection<string>() { "haystack", "forest", "tent", "bushes" },
                            AnswerSelected = new Dictionary<string, bool>() { { "haystack", false }, { "forest", false }, { "tent", false }, {"bushes", false} },
                            CorrectAnswer = "bushes"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: When the boy called the people the third time who came?",
                            AnswerArray =  new ObservableCollection<string>() { "everyone", "nobody", "men", "women" },
                            AnswerSelected = new Dictionary<string, bool>() { { "everyone", false }, { "nobody", false }, { "men", false }, {"women", false} },
                            CorrectAnswer = "nobody"
                        }
                    },
                    PlayTime = new TimeSpan(0, 2, 59), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Boy Who Cried Wolf Quiz 3",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The third time he cried wolf, people didn’t come until they saw that the boy was what?",
                            AnswerArray = new ObservableCollection<string>() { "afraid", "angry", "happy", "hungry" },
                            AnswerSelected = new Dictionary<string, bool>() { { "afraid", false }, { "angry", false }, { "happy", false }, { "hungry", false} },
                            CorrectAnswer = "afraid"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Who tells the boy that the people wouldn’t believe him because he lied the first two times?",
                            AnswerArray =  new ObservableCollection<string>() { "a hunter", "a king", "a boy", "a woman" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a hunter", false }, { "a king", false }, { "a boy", false }, { "a woman", false} },
                            CorrectAnswer = "a woman"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The boy learned it’s a bad idea to do what?",
                            AnswerArray =  new ObservableCollection<string>() { "steal", "hit", "lie", "hide" },
                            AnswerSelected = new Dictionary<string, bool>() { { "steal", false }, { "hit", false }, { "lie", false }, {"hide", false} },
                            CorrectAnswer = "lie"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: When he grew older, because no one would believe him, the boy did what?",
                            AnswerArray =  new ObservableCollection<string>() { "fight", "move", "cry", "yawn" },
                            AnswerSelected = new Dictionary<string, bool>() { { "fight", false }, { "move", false }, { "cry", false }, {"yawn", false} },
                            CorrectAnswer = "move"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: How did the people probably feel about the boy?",
                            AnswerArray =  new ObservableCollection<string>() { "disappointed", "proud", "happy", "afraid" },
                            AnswerSelected = new Dictionary<string, bool>() { { "disappointed", false }, { "proud", false }, { "happy", false }, {"afraid", false} },
                            CorrectAnswer = "disappointed"
                        }
                    },
                    PlayTime = new TimeSpan(0, 3, 43), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for The Elves and the Shoemaker
            else if (storyName.Equals("The Elves and Shoemaker"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Elves and the Shoemaker Quiz 1",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: A cobbler is another name for a what?",
                            AnswerArray = new ObservableCollection<string>() { "a shoemaker", "a laundress", "a judge", "a hunter" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a shoemaker", false }, { "a laundress", false }, { "a judge", false }, { "a hunter", false} },
                            CorrectAnswer = "shoemaker"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The shoemaker cut what to make shoes?",
                            AnswerArray =  new ObservableCollection<string>() { "wool", "hay", "leather", "trees" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wool", false }, { "hay", false }, { "leather", false }, { "trees", false} },
                            CorrectAnswer = "leather"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: At first the shoemaker only had enough to make how many pairs of shoes?",
                            AnswerArray =  new ObservableCollection<string>() { "1", "3", "5", "7" },
                            AnswerSelected = new Dictionary<string, bool>() { { "1", false }, { "3", false }, { "5", false }, {"7", false} },
                            CorrectAnswer = "1"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: On the first morning what was the shoemaker surprised to find on his work table?",
                            AnswerArray =  new ObservableCollection<string>() { "coffee", "shoes", "bread", "robin" },
                            AnswerSelected = new Dictionary<string, bool>() { { "coffee", false }, { "shoes", false }, { "bread", false }, {"robin", false} },
                            CorrectAnswer = "shoes"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 40), //TODO: might need to change time
                    NumQuestions = 4,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Elves and the Shoemaker Quiz 2",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: After selling the very first pair of shoes to a customer the shoemaker bought enough leather to make how many new pairs?",
                            AnswerArray = new ObservableCollection<string>() { "2", "6", "9", "12" },
                            AnswerSelected = new Dictionary<string, bool>() { { "2", false }, { "6", false }, { "9", false }, { "12", false} },
                            CorrectAnswer = "2"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2:  The shoemaker wanted to watch to see who did his work for him one evening about what holiday time?",
                            AnswerArray =  new ObservableCollection<string>() { "Easter", "Thanksgiving", "Halloween", "Christmas" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Easter", false }, { "Thanksgiving", false }, { "Halloween", false }, { "Christmas", false} },
                            CorrectAnswer = "Christmas"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Who hides with the shoemaker to watch who makes the shoes?",
                            AnswerArray =  new ObservableCollection<string>() { "a customer", "the elves", "his wife", "nobody" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a customer", false }, { "the elves", false }, { "his wife", false }, {"nobody", false} },
                            CorrectAnswer = "his wife"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: How many elves come to make shoes in the night?",
                            AnswerArray =  new ObservableCollection<string>() { "2", "4", "7", "9" },
                            AnswerSelected = new Dictionary<string, bool>() { { "2", false }, { "4", false }, { "7", false }, {"9", false} },
                            CorrectAnswer = "shoes"
                        }
                    },
                    PlayTime = new TimeSpan(0, 3, 33), //TODO: might need to change time
                    NumQuestions = 4,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Elves and the Shoemaker Quiz 3",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: What do the elves wear when they make the shoes?",
                            AnswerArray = new ObservableCollection<string>() { "mittens", "wigs", "nothing", "cobwebs" },
                            AnswerSelected = new Dictionary<string, bool>() { { "mittens", false }, { "wigs", false }, { "nothing", false }, { "cobwebs", false} },
                            CorrectAnswer = "nothing"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Who first has the idea to do a good deed for the elves?",
                            AnswerArray =  new ObservableCollection<string>() { "a customer", "his wife", "the elves", "nobody" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a customer", false }, { "his wife", false }, { "the elves", false }, { "nobody", false} },
                            CorrectAnswer = "his wife"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Who makes little shoes for the elves?",
                            AnswerArray =  new ObservableCollection<string>() { "nobody", "the elves", "his wife", "the shoemaker" },
                            AnswerSelected = new Dictionary<string, bool>() { { "nobody", false }, { "the elves", false }, { "his wife", false }, {"the shoemaker", false} },
                            CorrectAnswer = "the shoemaker"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Who makes a shirt, coat, vest, and pants for the elves?",
                            AnswerArray =  new ObservableCollection<string>() { "nobody", "the elves", "his wife", "the shoemaker" },
                            AnswerSelected = new Dictionary<string, bool>() { { "nobody", false }, { "the elves", false }, { "his wife", false }, {"the shoemaker", false} },
                            CorrectAnswer = "his wife"
                        }
                    },
                    PlayTime = new TimeSpan(0, 4, 00), //TODO: might need to change time
                    NumQuestions = 4,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 4
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Elves and the Shoemaker Quiz 4",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Because the elves helped them, the shoemaker and his wife became what?",
                            AnswerArray = new ObservableCollection<string>() { "wild", "rich", "sick", "hungry" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wild", false }, { "rich", false }, { "sick", false }, { "hungry", false} },
                            CorrectAnswer = "rich"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The shoemaker and his wife probably made gifts for the elves because the shoemaker and his wife were both what?",
                            AnswerArray =  new ObservableCollection<string>() { "clumsy", "forgetful", "thankful", "sick" },
                            AnswerSelected = new Dictionary<string, bool>() { { "clumsy", false }, { "forgetful", false }, { "thankful", false }, { "sick", false} },
                            CorrectAnswer = "thankful"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The elves probably decided to help the shoemaker and his wife because they knew the couple were what?",
                            AnswerArray =  new ObservableCollection<string>() { "good", "wild", "angry", "sick" },
                            AnswerSelected = new Dictionary<string, bool>() { { "good", false }, { "wild", false }, { "angry", false }, {"sick", false} },
                            CorrectAnswer = "good"
                        }
                    },
                    PlayTime = new TimeSpan(0, 4, 57), //TODO: might need to change time
                    NumQuestions = 4,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for The Three Little Pigs 
            else if (storyName.Equals("The Three Little Pigs"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 1",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: In the beginning the pigs lived in the forest with their what?",
                            AnswerArray = new ObservableCollection<string>() { "a farmer", "a mother", "a grandfather", "a queen" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a farmer", false }, { "a mother", false }, { "a grandfather", false }, { "a queen", false} },
                            CorrectAnswer = "a mother"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2:  Each pig was handed a bag of what when he left home?",
                            AnswerArray =  new ObservableCollection<string>() { "cookies", "candy", "pennies", "toys" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cookies", false }, { "candy", false }, { "pennies", false }, { "toys", false} },
                            CorrectAnswer = "pennies"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: At first the pigs came to a woman selling what?",
                            AnswerArray =  new ObservableCollection<string>() { "candy", "toys", "balloons", "pets" },
                            AnswerSelected = new Dictionary<string, bool>() { { "candy", false }, { "toys", false }, { "balloons", false }, {"pets", false} },
                            CorrectAnswer = "candy"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The first pig spent all his money on candy except how many pennies?",
                            AnswerArray =  new ObservableCollection<string>() { "3", "7", "10", "12" },
                            AnswerSelected = new Dictionary<string, bool>() { { "3", false }, { "7", false }, { "10", false }, {"12", false} },
                            CorrectAnswer = "3"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The second pig spent how many of his pennies on candy?",
                            AnswerArray =  new ObservableCollection<string>() { "none", "all", "10", "half" },
                            AnswerSelected = new Dictionary<string, bool>() { { "none", false }, { "all", false }, { "10", false }, {"half", false} },
                            CorrectAnswer = "half"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: The third pig spent how many of his pennies on candy?",
                            AnswerArray =  new ObservableCollection<string>() { "10", "all", "none", "half" },
                            AnswerSelected = new Dictionary<string, bool>() { { "10", false }, { "all", false }, { "none", false }, {"half", false} },
                            CorrectAnswer = "none"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 05), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 2",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The first man the pigs met had a load of what on his back?",
                            AnswerArray = new ObservableCollection<string>() { "toys", "straw", "bricks", "cupcakes" },
                            AnswerSelected = new Dictionary<string, bool>() { { "toys", false }, { "straw", false }, { "bricks", false }, { "cupcakes", false} },
                            CorrectAnswer = "straw"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The first pig gave the man how many pennies for straw?",
                            AnswerArray =  new ObservableCollection<string>() { "none", "3", "5", "10" },
                            AnswerSelected = new Dictionary<string, bool>() { { "none", false }, { "3", false }, { "5", false }, { "10", false} },
                            CorrectAnswer = "10"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The first pig built a house of straw because he knew it would be what?",
                            AnswerArray =  new ObservableCollection<string>() { "easy", "hard", "safe", "strong" },
                            AnswerSelected = new Dictionary<string, bool>() { { "easy", false }, { "hard", false }, { "safe", false }, {"strong", false} },
                            CorrectAnswer = "easy"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The second man the pigs met had a load of what in his wheelbarrow?",
                            AnswerArray =  new ObservableCollection<string>() { "straw", "toys", "bricks", "sticks" },
                            AnswerSelected = new Dictionary<string, bool>() { { "straw", false }, { "toys", false }, { "bricks", false }, {"sticks", false} },
                            CorrectAnswer = "sticks"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The second pig pays how many of a bag of pennies for the sticks?",
                            AnswerArray =  new ObservableCollection<string>() { "none", "5", "10", "half" },
                            AnswerSelected = new Dictionary<string, bool>() { { "none", false }, { "5", false }, { "10", false }, {"half", false} },
                            CorrectAnswer = "half"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: The first pig and the second pig both built their house by the side of the what?",
                            AnswerArray =  new ObservableCollection<string>() { "garden", "volcano", "road", "hill" },
                            AnswerSelected = new Dictionary<string, bool>() { { "garden", false }, { "volcano", false }, { "road", false }, {"hill", false} },
                            CorrectAnswer = "none"
                        }
                    },
                    PlayTime = new TimeSpan(0, 2, 19), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 3",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The third pig meets a man with a wagon-load of what?",
                            AnswerArray = new ObservableCollection<string>() { "sticks", "straw", "bricks", "berries" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sticks", false }, { "straw", false }, { "bricks", false }, { "berries", false} },
                            CorrectAnswer = "bricks"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The third pig gave how many of a bag of pennies to the man with the wagon?",
                            AnswerArray =  new ObservableCollection<string>() { "none", "all", "half", "10" },
                            AnswerSelected = new Dictionary<string, bool>() { { "none", false }, { "all", false }, { "half", false }, { "10", false} },
                            CorrectAnswer = "all"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The third pig built a house of bricks because he knew it would be what?",
                            AnswerArray =  new ObservableCollection<string>() { "pretty", "tall", "weak", "strong" },
                            AnswerSelected = new Dictionary<string, bool>() { { "pretty", false }, { "tall", false }, { "weak", false }, {"strong", false} },
                            CorrectAnswer = "strong"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Who knocks on the first pig’s door and says let me come in?",
                            AnswerArray =  new ObservableCollection<string>() { "wolf", "pig", "duck", "bigfoot" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wolf", false }, { "pig", false }, { "duck", false }, {"bigfoot", false} },
                            CorrectAnswer = "wolf"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The first pig answers, not by the WHAT of my chinny chin chin?",
                            AnswerArray =  new ObservableCollection<string>() { "earlobe", "toenails", "hair", "horns" },
                            AnswerSelected = new Dictionary<string, bool>() { { "earlobe", false }, { "toenails", false }, { "hair", false }, {"horns", false} },
                            CorrectAnswer = "hair"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: The wolf says he will huff and puff and what the house in?",
                            AnswerArray =  new ObservableCollection<string>() { "lick", "blow", "drink", "hop" },
                            AnswerSelected = new Dictionary<string, bool>() { { "lick", false }, { "blow", false }, { "drink", false }, {"hop", false} },
                            CorrectAnswer = "blow"
                        }
                    },
                    PlayTime = new TimeSpan(0, 3, 12), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 4
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 4",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: When the straw house blows down the first pig runs to the brother who built a house of what?",
                            AnswerArray = new ObservableCollection<string>() { "sticks", "bones", "toys", "candy" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sticks", false }, { "bones", false }, { "toys", false }, { "candy", false} },
                            CorrectAnswer = "sticks"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The first time the wolf huffs and puffs, the stick house doesn’t fall like the straw house, because the stick house was what?",
                            AnswerArray =  new ObservableCollection<string>() { "silly", "dark", "stronger", "yellow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "silly", false }, { "dark", false }, { "stronger", false }, { "yellow", false} },
                            CorrectAnswer = "stronger"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: When the stick house blows down the two pigs run to the brother who built a house of what?",
                            AnswerArray =  new ObservableCollection<string>() { "straw", "shoes", "pumpkins", "bricks" },
                            AnswerSelected = new Dictionary<string, bool>() { { "straw", false }, { "shoes", false }, { "pumpkins", false }, {"bricks", false} },
                            CorrectAnswer = "bricks"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The pig in the picture looks like he’s doing what?",
                            AnswerArray =  new ObservableCollection<string>() { "dancing", "resting", "washing", "shaving" },
                            AnswerSelected = new Dictionary<string, bool>() { { "dancing", false }, { "resting", false }, { "washing", false }, {"shaving", false} },
                            CorrectAnswer = "resting"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The pig in the picture looks at what outside his window?",
                            AnswerArray =  new ObservableCollection<string>() { "wolf", "dragon", "airplane", "robot" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wolf", false }, { "dragon", false }, { "airplane", false }, {"robot", false} },
                            CorrectAnswer = "wolf"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: The pig in the picture holds a what?",
                            AnswerArray =  new ObservableCollection<string>() { "cup", "pot", "spoon", "skateboard" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cup", false }, { "pot", false }, { "spoon", false }, {"skateboard", false} },
                            CorrectAnswer = "spoon"
                        }
                    },
                    PlayTime = new TimeSpan(0, 5, 58), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 5
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 5",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The wolf couldn’t blow down the house made of what?",
                            AnswerArray = new ObservableCollection<string>() { "sticks", "bricks", "cupcakes", "candy" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sticks", false }, { "bricks", false }, { "cupcakes", false }, { "candy", false} },
                            CorrectAnswer = "bricks"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The wolf jumped down the what?",
                            AnswerArray =  new ObservableCollection<string>() { "chimney", "waterfall", "haystack", "volcano" },
                            AnswerSelected = new Dictionary<string, bool>() { { "chimney", false }, { "waterfall", false }, { "haystack", false }, { "volcano", false} },
                            CorrectAnswer = "chimney"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: After he jumped the wolf landed in a what?",
                            AnswerArray =  new ObservableCollection<string>() { "a cradle", "a pot", "a pillow", "a wheelbarrow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a cradle", false }, { "a pot", false }, { "a pillow", false }, {"a wheelbarrow", false} },
                            CorrectAnswer = "a pot"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The wolf wanted to eat the pigs but he became the pigs’ what?",
                            AnswerArray =  new ObservableCollection<string>() { "go-kart", "brother", "dinner", "shoemaker" },
                            AnswerSelected = new Dictionary<string, bool>() { { "go-kart", false }, { "brother", false }, { "dinner", false }, {"shoemaker", false} },
                            CorrectAnswer = "dinner"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The first two pigs should not have spent so many pennies to buy what?",
                            AnswerArray =  new ObservableCollection<string>() { "frogs", "candy", "eyebrows", "triangles" },
                            AnswerSelected = new Dictionary<string, bool>() { { "frogs", false }, { "candy", false }, { "eyebrows", false }, {"triangles", false} },
                            CorrectAnswer = "candy"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: The pig who bought bricks instead of candy was what?",
                            AnswerArray =  new ObservableCollection<string>() { "sleepy", "hungry", "smart", "silly" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sleepy", false }, { "hungry", false }, { "smart", false }, {"silly", false} },
                            CorrectAnswer = "smart"
                        }
                    },
                    PlayTime = new TimeSpan(0, 6, 11), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
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
