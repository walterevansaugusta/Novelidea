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
                    AssociatedImage = "S1_LATM_1.jpg",
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
                    { 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                //Quiz Two
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Lion and the Mouse Quiz 2",
                    AssociatedImage = "S1_LATM_1.jpg",
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
                    { 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                //Quiz Three
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Lion and the Mouse Quiz 3",
                    AssociatedImage = "S1_LATM_1.jpg",
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
                    { 0, 0, 0, 0, 0},
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
                    AssociatedImage = "S2_LRH_0.jpg",
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
                    { 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Hen Quiz 2",
                    AssociatedImage = "S2_LRH_0.jpg",
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
                    { 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Hen Quiz 3",
                    AssociatedImage = "S2_LRH_0.jpg",
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
                    { 0, 0, 0, 0, 0},
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
                    AssociatedImage = "S3_TBWCW_1.jpg",
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
                    { 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Boy Who Cried Wolf Quiz 2",
                    AssociatedImage = "S3_TBWCW_1.jpg",
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
                    { 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Boy Who Cried Wolf Quiz 3",
                    AssociatedImage = "S3_TBWCW_1.jpg",
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
                    { 0, 0, 0, 0, 0},
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
                    AssociatedImage = "S4_TEATS_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: A cobbler is another name for a what?",
                            AnswerArray = new ObservableCollection<string>() { "a shoemaker", "a laundress", "a judge", "a hunter" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a shoemaker", false }, { "a laundress", false }, { "a judge", false }, { "a hunter", false} },
                            CorrectAnswer = "a shoemaker"
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
                    AssociatedImage = "S4_TEATS_1.jpg",
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
                    AssociatedImage = "S4_TEATS_1.jpg",
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
                    AssociatedImage = "S4_TEATS_1.jpg",
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
                    AssociatedImage = "S5_TLP_0.jpg",
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
                    { 0, 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 2",
                    AssociatedImage = "S5_TLP_0.jpg",
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
                    { 0, 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 3",
                    AssociatedImage = "S5_TLP_0.jpg",
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
                    { 0, 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                // Quiz 4
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 4",
                    AssociatedImage = "S5_TLP_0.jpg",
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
                    { 0, 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });

                // Quiz 5
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Little Pigs Quiz 5",
                    AssociatedImage = "S5_TLP_0.jpg",
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
                    { 0, 0, 0, 0, 0, 0},
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for The Three Billy Goats Gruff
            else if (storyName.Equals("The Three Billy Goats Gruff"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Billy Goats Gruff Quiz 1",
                    AssociatedImage = "S6_BGG_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The goats lived first in a pasture of alfalfa what?",
                            AnswerArray = new ObservableCollection<string>() { "straw", "grass", "bushes", "cat-tails" },
                            AnswerSelected = new Dictionary<string, bool>() { { "straw", false }, { "grass", false }, { "bushes", false }, { "cat-tails", false} },
                            CorrectAnswer = "grass"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The goats wanted to go to a meadow with delicious green what?",
                            AnswerArray =  new ObservableCollection<string>() { "clover", "oats", "wheat", "lettuce" },
                            AnswerSelected = new Dictionary<string, bool>() { { "clover", false }, { "oats", false }, { "wheat", false }, { "lettuce", false} },
                            CorrectAnswer = "clover"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Between the hill of alfalfa and the green meadow what was there to walk on?",
                            AnswerArray =  new ObservableCollection<string>() { "a tree", "a puddle", "a stone", "a bridge" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a tree", false }, { "a puddle", false }, { "a stone", false }, {"a bridge", false} },
                            CorrectAnswer = "a bridge"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Under the bridge was a mischievous what?",
                            AnswerArray =  new ObservableCollection<string>() { "chimp", "alligator", "troll", "girl" },
                            AnswerSelected = new Dictionary<string, bool>() { { "chimp", false }, { "alligator", false }, { "troll", false }, {"girl", false} },
                            CorrectAnswer = "troll"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Which Billy Goat Gruff was the first one to cross the bridge?",
                            AnswerArray =  new ObservableCollection<string>() { "Little", "Middle-sized", "Big", "None" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Little", false }, { "Middle-sized", false }, { "Big", false }, {"triangles", false} },
                            CorrectAnswer = "Little"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: Billy Goat Gruff made the clip-clop sound with his what?",
                            AnswerArray =  new ObservableCollection<string>() { "horns", "nose", "hoofs", "tail" },
                            AnswerSelected = new Dictionary<string, bool>() { { "horns", false }, { "nose", false }, { "hoofs", false }, {"tail", false} },
                            CorrectAnswer = "hoofs"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 30), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Billy Goats Gruff Quiz 2",
                    AssociatedImage = "S6_BGG_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The first part of the troll Little Billy Goat Gruff saw was the troll’s crooked, bumpy what?",
                            AnswerArray = new ObservableCollection<string>() { "nose", "finger", "toes", "tongue" },
                            AnswerSelected = new Dictionary<string, bool>() { { "nose", false }, { "finger", false }, { "toes", false }, { "tongues", false} },
                            CorrectAnswer = "finger"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The troll’s long hairy nose was what color?",
                            AnswerArray =  new ObservableCollection<string>() { "red", "yellow", "blue", "green" },
                            AnswerSelected = new Dictionary<string, bool>() { { "red", false }, { "yellow", false }, { "blue", false }, { "green", false} },
                            CorrectAnswer = "green"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The troll’s dirty black what smelled terribly foul?",
                            AnswerArray =  new ObservableCollection<string>() { "teeth", "hair", "feet", "ears" },
                            AnswerSelected = new Dictionary<string, bool>() { { "teeth", false }, { "hair", false }, { "feet", false }, {"ears", false} },
                            CorrectAnswer = "teeth"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Little Billy Goat Gruff says the troll should not eat him because he is so what?",
                            AnswerArray =  new ObservableCollection<string>() { "sour", "wet", "crunchy", "small" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sour", false }, { "wet", false }, { "crunchy", false }, {"small", false} },
                            CorrectAnswer = "small"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Little Billy Goat Gruff tells the troll to wait for which Billy Goat Gruff?",
                            AnswerArray =  new ObservableCollection<string>() { "Momma", "Middle-sized", "Big", "Poppa" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Momma", false }, { "Middle-sized", false }, { "Big", false }, {"Poppa", false} },
                            CorrectAnswer = "Middle-sized"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: When he speaks to the troll Little Billy Goat Gruff’s behavior is what?",
                            AnswerArray =  new ObservableCollection<string>() { "angry", "funny", "polite", "wild" },
                            AnswerSelected = new Dictionary<string, bool>() { { "angry", false }, { "funny", false }, { "polite", false }, {"wild", false} },
                            CorrectAnswer = "polite"
                        }
                    },
                    PlayTime = new TimeSpan(0, 2, 30), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Billy Goats Gruff Quiz 3",
                    AssociatedImage = "S6_BGG_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Little Billy Goat Gruff tells the troll that his brother is much what?",
                            AnswerArray = new ObservableCollection<string>() { "sweeter", "nicer", "bigger", "friendlier" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sweeter", false }, { "nicer", false }, { "bigger", false }, { "friendlier", false} },
                            CorrectAnswer = "bigger"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The troll agrees to eat Little Billy Goat Gruff when?",
                            AnswerArray =  new ObservableCollection<string>() { "now", "later", "never", "Christmas" },
                            AnswerSelected = new Dictionary<string, bool>() { { "now", false }, { "later", false }, { "never", false }, { "Christmas", false} },
                            CorrectAnswer = "later"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Which Billy Goat Gruff was the second Billy Goat Gruff to cross the bridge?",
                            AnswerArray =  new ObservableCollection<string>() { "Little", "Big", "Poppa", "Middle-sized" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Little", false }, { "Big", false }, { "Poppa", false }, {"Middle-sized", false} },
                            CorrectAnswer = "Middle-sized"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The troll had three long black hairs growing out of a what?",
                            AnswerArray =  new ObservableCollection<string>() { "mole", "ear", "toe", "nose" },
                            AnswerSelected = new Dictionary<string, bool>() { { "mole", false }, { "ear", false }, { "toe", false }, {"nose", false} },
                            CorrectAnswer = "mole"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The troll had big floppy what that made a shadow on the bridge?",
                            AnswerArray =  new ObservableCollection<string>() { "toenails", "eyes", "ears", "fingers" },
                            AnswerSelected = new Dictionary<string, bool>() { { "toenails", false }, { "eyes", false }, { "ears", false }, {"fingers", false} },
                            CorrectAnswer = "ears"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: The troll slobbered spit on what?",
                            AnswerArray =  new ObservableCollection<string>() { "tree", "bridge", "waterfall", "dunebuggy" },
                            AnswerSelected = new Dictionary<string, bool>() { { "tree", false }, { "bridge", false }, { "waterfall", false }, {"dunebuggy", false} },
                            CorrectAnswer = "bridge"
                        }
                    },
                    PlayTime = new TimeSpan(0, 3, 30), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 4
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Billy Goats Gruff Quiz 4",
                    AssociatedImage = "S6_BGG_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Middle-size Billy Goat Gruff tells the troll to wait for him to get what?",
                            AnswerArray = new ObservableCollection<string>() { "sweeter", "nicer", "tastier", "bigger" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sweeter", false }, { "nicer", false }, { "tastier", false }, { "bigger", false} },
                            CorrectAnswer = "bigger"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Middle-size Billy Goat Gruff says the troll should eat which Billy Goat Gruff now?",
                            AnswerArray =  new ObservableCollection<string>() { "Little", "Middle-sized", "Big", "none" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Little", false }, { "Middle-sized", false }, { "Big", false }, { "none", false} },
                            CorrectAnswer = "Big"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: What color was the troll’s face?",
                            AnswerArray =  new ObservableCollection<string>() { "blue", "green", "orange", "yellow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "blue", false }, { "green", false }, { "orange", false }, {"yellow", false} },
                            CorrectAnswer = "green"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: What color were the troll’s eyes?",
                            AnswerArray =  new ObservableCollection<string>() { "red", "blue", "brown", "yellow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "red", false }, { "blue", false }, { "brown", false }, {"yellow", false} },
                            CorrectAnswer = "red"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Which Billy Goat Gruff was the last Billy Goat Gruff to cross the bridge?",
                            AnswerArray =  new ObservableCollection<string>() { "Poppa", "Momma", "Middle-sized", "Big" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Poppa", false }, { "Momma", false }, { "Middle-sized", false }, {"Big", false} },
                            CorrectAnswer = "Big"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: Big Billy Goat Gruff says he is which brother?",
                            AnswerArray =  new ObservableCollection<string>() { "youngest", "middle", "eldest", "sweetest" },
                            AnswerSelected = new Dictionary<string, bool>() { { "youngest", false }, { "middle", false }, { "eldest", false }, {"sweetest", false} },
                            CorrectAnswer = "eldest"
                        }
                    },
                    PlayTime = new TimeSpan(0, 4, 30), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 5
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Three Billy Goats Gruff Quiz 5",
                    AssociatedImage = "S6_BGG_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The troll says he intends to do what to Big Billy Goat Gruff?",
                            AnswerArray = new ObservableCollection<string>() { "scold", "eat", "kiss", "hug" },
                            AnswerSelected = new Dictionary<string, bool>() { { "scold", false }, { "eat", false }, { "kiss", false }, { "hug", false} },
                            CorrectAnswer = "eat"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: What part of the troll curled in circles and scratched lines on the bridge?",
                            AnswerArray =  new ObservableCollection<string>() { "toenails", "horn", "nose", "knees" },
                            AnswerSelected = new Dictionary<string, bool>() { { "toenails", false }, { "horn", false }, { "nose", false }, { "knees", false} },
                            CorrectAnswer = "toenails"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Nasty weeds grew from dirt deep in the troll’s what?",
                            AnswerArray =  new ObservableCollection<string>() { "ears", "nose", "tummy-button", "mustache" },
                            AnswerSelected = new Dictionary<string, bool>() { { "ears", false }, { "nose", false }, { "tummy-button", false }, {"mustache", false} },
                            CorrectAnswer = "tummy-button"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: When the troll said he’d eat Big Billy Goat Gruff and his brothers what did Big Billy Goat Gruff say?",
                            AnswerArray =  new ObservableCollection<string>() { "yikes", "help", "wow", "nothing" },
                            AnswerSelected = new Dictionary<string, bool>() { { "yikes", false }, { "help", false }, { "wow", false }, {"nothing", false} },
                            CorrectAnswer = "nothing"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Big Billy Goat Gruff hit the troll with his curvy what?",
                            AnswerArray =  new ObservableCollection<string>() { "tongue", "horns", "hoofs", "tail" },
                            AnswerSelected = new Dictionary<string, bool>() { { "tongue", false }, { "horns", false }, { "hoofs", false }, {"tail", false} },
                            CorrectAnswer = "horns"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: Big Billy Goat Gruff blasted the troll to what?",
                            AnswerArray =  new ObservableCollection<string>() { "smithereens", "perdition", "Timbuktu", "tomorrow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "smithereens", false }, { "perdition", false }, { "Timbuktu", false }, {"tomorrow", false} },
                            CorrectAnswer = "smithereens"
                        }
                    },
                    PlayTime = new TimeSpan(0, 5, 30), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for The Tale of Peter Rabbit
            else if (storyName.Equals("The Tale of Peter Rabbit"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Tale of Peter Tabbit Quiz 1",
                    AssociatedImage = "S7_PR_0.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Peter’s sisters were named Flopsy, Mopsy, and what?",
                            AnswerArray = new ObservableCollection<string>() { "Thumper", "Etticoat", "Cottontail", "Pixie" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Thumper", false }, { "Etticoat", false }, { "Cottontail", false }, { "Pixie", false} },
                            CorrectAnswer = "Cottontail"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Their mother told them not to go into Mr. McGregor’s what?",
                            AnswerArray =  new ObservableCollection<string>() { "haystack", "garden", "firetruck", "kayak" },
                            AnswerSelected = new Dictionary<string, bool>() { { "haystack", false }, { "garden", false }, { "firetruck", false }, { "kayak", false} },
                            CorrectAnswer = "garden"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Their mother told them that Mrs. McGregor put their father into a what?",
                            AnswerArray =  new ObservableCollection<string>() { "pie", "tent", "wheelbarrow", "basket" },
                            AnswerSelected = new Dictionary<string, bool>() { { "pie", false }, { "tent", false }, { "wheelbarrow", false }, {"basket", false} },
                            CorrectAnswer = "pie"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: At the baker’s their mother bought a loaf of what color bread?",
                            AnswerArray =  new ObservableCollection<string>() { "red", "yellow", "orange", "brown" },
                            AnswerSelected = new Dictionary<string, bool>() { { "red", false }, { "yellow", false }, { "orange", false }, {"brown", false} },
                            CorrectAnswer = "brown"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: In the picture Peter’s mother carries a basket and a what?",
                            AnswerArray =  new ObservableCollection<string>() { "balloon", "clock", "umbrella", "frog" },
                            AnswerSelected = new Dictionary<string, bool>() { { "balloon", false }, { "clock", false }, { "umbrella", false }, {"frog", false} },
                            CorrectAnswer = "umbrella"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: Peter’s good little sisters went down the lane to gather what?",
                            AnswerArray =  new ObservableCollection<string>() { "worms", "blackberries", "eggs", "flowers" },
                            AnswerSelected = new Dictionary<string, bool>() { { "worms", false }, { "blackberries", false }, { "eggs", false }, {"flowers", false} },
                            CorrectAnswer = "blackberries"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 01), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Tale of Peter Tabbit Quiz 2",
                    AssociatedImage = "S7_PR_0.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Peter went to Mr. McGregor’s and squeezed under the what?",
                            AnswerArray = new ObservableCollection<string>() { "wheelbarrow", "bulldozer", "gate", "elephant" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wheelbarrow", false }, { "bulldozer", false }, { "gate", false }, { "elephant", false} },
                            CorrectAnswer = "gate"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: First Peter ate some what and some French Beans?",
                            AnswerArray =  new ObservableCollection<string>() { "lettuce", "watermelon", "onions", "bacon" },
                            AnswerSelected = new Dictionary<string, bool>() { { "lettuce", false }, { "watermelon", false }, { "onions", false }, { "bacon", false} },
                            CorrectAnswer = "lettuce"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: In the picture what sits on a shovel handle and looks down at Peter eating a carrot?",
                            AnswerArray =  new ObservableCollection<string>() { "lizard", "bird", "chimp", "octopus" },
                            AnswerSelected = new Dictionary<string, bool>() { { "lizard", false }, { "bird", false }, { "chimp", false }, {"octopus", false} },
                            CorrectAnswer = "bird"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Peter went to look for some parsley leaves because he felt what?",
                            AnswerArray =  new ObservableCollection<string>() { "thirsty", "forgetful", "sick", "clumsy" },
                            AnswerSelected = new Dictionary<string, bool>() { { "thirsty", false }, { "forgetful", false }, { "sick", false }, {"clumsy", false} },
                            CorrectAnswer = "sick"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Mr. McGregor waved a rake and called Peter a what?",
                            AnswerArray =  new ObservableCollection<string>() { "friend", "sillycat", "grumpybear", "thief" },
                            AnswerSelected = new Dictionary<string, bool>() { { "friend", false }, { "sillycat", false }, { "grumpybear", false }, {"thief", false} },
                            CorrectAnswer = "thief"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: What did Peter lose among the cabbages and potatoes?",
                            AnswerArray =  new ObservableCollection<string>() { "shoes", "skateboard", "hat", "rocket" },
                            AnswerSelected = new Dictionary<string, bool>() { { "shoes", false }, { "skateboard", false }, { "hat", false }, {"rocket", false} },
                            CorrectAnswer = "shoes"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 45), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Tale of Peter Tabbit Quiz 3",
                    AssociatedImage = "S7_PR_0.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: What color was Peter’s jacket?",
                            AnswerArray = new ObservableCollection<string>() { "red", "yellow", "blue", "brown" },
                            AnswerSelected = new Dictionary<string, bool>() { { "red", false }, { "yellow", false }, { "blue", false }, { "brown", false} },
                            CorrectAnswer = "blue"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Peter’s sobs were heard by some friendly what?",
                            AnswerArray =  new ObservableCollection<string>() { "pigs", "sparrows", "bones", "spiders" },
                            AnswerSelected = new Dictionary<string, bool>() { { "pigs", false }, { "sparrows", false }, { "bones", false }, { "spiders", false} },
                            CorrectAnswer = "sparrows"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Peter jumped into a can which had what in it?",
                            AnswerArray =  new ObservableCollection<string>() { "water", "straw", "cobwebs", "ice" },
                            AnswerSelected = new Dictionary<string, bool>() { { "water", false }, { "straw", false }, { "cobwebs", false }, {"ice", false} },
                            CorrectAnswer = "water"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: In the picture what part of Peter sticks out of the watering can?",
                            AnswerArray =  new ObservableCollection<string>() { "nose", "paws", "tail", "ears" },
                            AnswerSelected = new Dictionary<string, bool>() { { "nose", false }, { "paws", false }, { "tail", false }, {"ears", false} },
                            CorrectAnswer = "ears"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Mr. McGregor thought Peter might be hiding under a what?",
                            AnswerArray =  new ObservableCollection<string>() { "cup", "flower-pot", "wheelbarrow", "giraffe" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cup", false }, { "flower-pot", false }, { "wheelbarrow", false }, {"giraffe", false} },
                            CorrectAnswer = "flower-pot"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: What sound did Peter make when he sneezed?",
                            AnswerArray =  new ObservableCollection<string>() { "dickery", "jiggety", "kertyschoo", "burp" },
                            AnswerSelected = new Dictionary<string, bool>() { { "dickery", false }, { "jiggety", false }, { "kertyschoo", false }, {"burp", false} },
                            CorrectAnswer = "kertyschoo"
                        }
                    },
                    PlayTime = new TimeSpan(0, 3, 17), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 4
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Tale of Peter Tabbit Quiz 4",
                    AssociatedImage = "S7_PR_0.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: What animal did Peter see carrying peas and beans to her family in the wood?",
                            AnswerArray = new ObservableCollection<string>() { "tiger", "panda", "turtle", "mouse" },
                            AnswerSelected = new Dictionary<string, bool>() { { "tiger", false }, { "panda", false }, { "turtle", false }, { "mouse", false} },
                            CorrectAnswer = "mouse"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: When the mouse with the pea didn’t help him Peter began to do what?",
                            AnswerArray =  new ObservableCollection<string>() { "skip", "cry", "snort", "yell" },
                            AnswerSelected = new Dictionary<string, bool>() { { "skip", false }, { "cry", false }, { "snort", false }, { "yell", false} },
                            CorrectAnswer = "cry"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: What white animal was staring at some goldfish?",
                            AnswerArray =  new ObservableCollection<string>() { "cat", "spider", "calf", "squirrel" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cat", false }, { "spider", false }, { "calf", false }, {"squirrel", false} },
                            CorrectAnswer = "cat"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: What did Peter hear that made the noise:  scr-r-ritch, scratch, scratch, scritch?",
                            AnswerArray =  new ObservableCollection<string>() { "turtle", "fish", "hoe", "pixie" },
                            AnswerSelected = new Dictionary<string, bool>() { { "turtle", false }, { "fish", false }, { "hoe", false }, {"pixie", false} },
                            CorrectAnswer = "hoe"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Peter climbed on what and peeped over to see Mr. McGregor?",
                            AnswerArray =  new ObservableCollection<string>() { "calf", "hippo", "wheelbarrow", "refrigerator" },
                            AnswerSelected = new Dictionary<string, bool>() { { "calf", false }, { "hippo", false }, { "wheelbarrow", false }, {"refrigerator", false} },
                            CorrectAnswer = "wheelbarrow"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: Beyond Mr. McGregor Peter saw the what?",
                            AnswerArray =  new ObservableCollection<string>() { "broom", "gate", "boat", "guitar" },
                            AnswerSelected = new Dictionary<string, bool>() { { "broom", false }, { "gate", false }, { "boat", false }, {"guitar", false} },
                            CorrectAnswer = "gate"
                        }
                    },
                    PlayTime = new TimeSpan(0, 4, 42), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 5
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Tale of Peter Tabbit Quiz 5",
                    AssociatedImage = "S7_PR_0.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Peter ran fast as he could along a straight walk behind some blackcurrant what?",
                            AnswerArray = new ObservableCollection<string>() { "bushes", "pies", "dishes", "umbrellas" },
                            AnswerSelected = new Dictionary<string, bool>() { { "bushes", false }, { "pies", false }, { "dishes", false }, { "mouse", false} },
                            CorrectAnswer = "bushes"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Mr. McGregor hung up the little jacket and shoes to frighten whom?",
                            AnswerArray =  new ObservableCollection<string>() { "jellyfish", "giraffes", "blackbirds", "pelicans" },
                            AnswerSelected = new Dictionary<string, bool>() { { "jellyfish", false }, { "giraffes", false }, { "blackbirds", false }, { "pelicans", false} },
                            CorrectAnswer = "blackbirds"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: In the evening Peter’s mother made him go to what?",
                            AnswerArray =  new ObservableCollection<string>() { "the doctor", "bed", "a judge", "dance" },
                            AnswerSelected = new Dictionary<string, bool>() { { "the doctor", false }, { "bed", false }, { "a judge", false }, {"dance", false} },
                            CorrectAnswer = "bed"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: His mother made Peter take a dose of camomile what?",
                            AnswerArray =  new ObservableCollection<string>() { "water", "soup", "grass", "tea" },
                            AnswerSelected = new Dictionary<string, bool>() { { "water", false }, { "soup", false }, { "grass", false }, {"tea", false} },
                            CorrectAnswer = "tea"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5:  Flopsy, Mopsy and Cottontail had bread and milk and what for supper?",
                            AnswerArray =  new ObservableCollection<string>() { "lemons", "plums", "blackberries", "apricots" },
                            AnswerSelected = new Dictionary<string, bool>() { { "lemons", false }, { "plums", false }, { "blackberries", false }, {"apricots", false} },
                            CorrectAnswer = "blackberries"
                        },
                        new Question()
                        {
                            QuestionText = "Question 6: When Peter had to take a dose of camomile instead of getting milk and blackberries for supper he probably felt what?",
                            AnswerArray =  new ObservableCollection<string>() { "sorry", "happy", "frightened", "proud" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sorry", false }, { "happy", false }, { "frightened", false }, {"proud", false} },
                            CorrectAnswer = "sorry"
                        }
                    },
                    PlayTime = new TimeSpan(0, 6, 25), //TODO: might need to change time
                    NumQuestions = 6,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for The Gingerbread Man
            else if (storyName.Equals("The Gingerbread Man"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Gingerbread Man Quiz 1",
                    AssociatedImage = "S8_TGM_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Who baked the Gingerbread Man?",
                            AnswerArray = new ObservableCollection<string>() { "grandfather", "grandmother", "piper", "mouse" },
                            AnswerSelected = new Dictionary<string, bool>() { { "grandfather", false }, { "grandmother", false }, { "piper", false }, { "mouse", false} },
                            CorrectAnswer = "grandmother"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The Gingerbread Man had raisins for what?",
                            AnswerArray =  new ObservableCollection<string>() { "hands", "mouth", "eyes", "toes" },
                            AnswerSelected = new Dictionary<string, bool>() { { "hands", false }, { "mouth", false }, { "eyes", false }, { "toes", false} },
                            CorrectAnswer = "eyes"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: A mischievous pixie sprinkled magic pixie dust in the can that held the what?",
                            AnswerArray =  new ObservableCollection<string>() { "bacon", "ginger", "pudding", "grasshopper" },
                            AnswerSelected = new Dictionary<string, bool>() { { "bacon", false }, { "ginger", false }, { "pudding", false }, {"grasshopper", false} },
                            CorrectAnswer = "ginger"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The Gingerbread Man says, “You can’t do what to me”?",
                            AnswerArray =  new ObservableCollection<string>() { "help", "catch", "lie", "scold" },
                            AnswerSelected = new Dictionary<string, bool>() { { "help", false }, { "catch", false }, { "lie", false }, {"scold", false} },
                            CorrectAnswer = "catch"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Who first asks, “Please, let me have a nibble?”",
                            AnswerArray =  new ObservableCollection<string>() { "grandfather", "lion", "calf", "T-Rex" },
                            AnswerSelected = new Dictionary<string, bool>() { { "grandfather", false }, { "lion", false }, { "calf", false }, {"T-Rex", false} },
                            CorrectAnswer = "grandfather"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 07), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Gingerbread Man Quiz 2",
                    AssociatedImage = "S8_TGM_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Who was just behind the grandfather chasing the Gingerbread Man?",
                            AnswerArray = new ObservableCollection<string>() { "hog", "grandmother", "fisherman", "policewoman" },
                            AnswerSelected = new Dictionary<string, bool>() { { "hog", false }, { "grandmother", false }, { "fisherman", false }, { "policewoman", false} },
                            CorrectAnswer = "grandmother"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Who swatted at the Gingerbread Man and asked for one quick lick?",
                            AnswerArray =  new ObservableCollection<string>() { "judge", "sheep", "cat", "hippo" },
                            AnswerSelected = new Dictionary<string, bool>() { { "judge", false }, { "sheep", false }, { "cat", false }, { "hippo", false} },
                            CorrectAnswer = "cat"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The Gingerbread Man called the cat whisker-what?",
                            AnswerArray =  new ObservableCollection<string>() { "face", "tail", "toes", "tummy" },
                            AnswerSelected = new Dictionary<string, bool>() { { "face", false }, { "tail", false }, { "toes", false }, {"tummy", false} },
                            CorrectAnswer = "face"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The Gingerbread Man leapt and landed square in the middle of whose back?",
                            AnswerArray =  new ObservableCollection<string>() { "squirrel", "clown", "dog", "plumber" },
                            AnswerSelected = new Dictionary<string, bool>() { { "squirrel", false }, { "clown", false }, { "dog", false }, {"plumber", false} },
                            CorrectAnswer = "dog"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: What was the dog doing before the Gingerbread Man ran past?",
                            AnswerArray =  new ObservableCollection<string>() { "dancing", "washing", "tumbling", "sleeping" },
                            AnswerSelected = new Dictionary<string, bool>() { { "dancing", false }, { "washing", false }, { "tumbling", false }, {"sleeping", false} },
                            CorrectAnswer = "sleeping"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 47), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Gingerbread Man Quiz 3",
                    AssociatedImage = "S8_TGM_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The Gingerbread Man calls the dog a flea-bitten bag of what?",
                            AnswerArray = new ObservableCollection<string>() { "eggs", "balloons", "bones", "straw" },
                            AnswerSelected = new Dictionary<string, bool>() { { "eggs", false }, { "balloons", false }, { "bones", false }, { "straw", false} },
                            CorrectAnswer = "bones"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The Gingerbread Man made what kind of sound with his tongue and lips?",
                            AnswerArray =  new ObservableCollection<string>() { "sweet", "rude", "polite", "sad" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sweet", false }, { "rude", false }, { "polite", false }, { "sad", false} },
                            CorrectAnswer = "rude"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The Gingerbread Man says the dog is even slower than the what?",
                            AnswerArray =  new ObservableCollection<string>() { "cat", "rabbit", "calf", "rhinoceros" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cat", false }, { "rabbit", false }, { "calf", false }, {"rhinoceros", false} },
                            CorrectAnswer = "cat"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: At the barn what was drowsing and chewing its cud?",
                            AnswerArray =  new ObservableCollection<string>() { "spider", "turtle", "cow", "zebra" },
                            AnswerSelected = new Dictionary<string, bool>() { { "spider", false }, { "turtle", false }, { "cow", false }, {"zebra", false} },
                            CorrectAnswer = "cow"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: What animal is grazing in the pasture and gets called hay-breath?",
                            AnswerArray =  new ObservableCollection<string>() { "sheep", "horse", "lion", "rattlesnake" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sheep", false }, { "horse", false }, { "lion", false }, {"rattlesnake", false} },
                            CorrectAnswer = "horse"
                        }
                    },
                    PlayTime = new TimeSpan(0, 3, 27), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 4
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Gingerbread Man Quiz 4",
                    AssociatedImage = "S8_TGM_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: What boy does the Gingerbread Man call goofy-looking and flat-footed?",
                            AnswerArray = new ObservableCollection<string>() { "blacksmith", "cobbler", "shepherd", "munchkin" },
                            AnswerSelected = new Dictionary<string, bool>() { { "blacksmith", false }, { "cobbler", false }, { "shepherd", false }, { "munchkin", false} },
                            CorrectAnswer = "shepherd"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The Gingerbread Man halted when he came to a what?",
                            AnswerArray =  new ObservableCollection<string>() { "playground", "circuis", "tunnel", "river" },
                            AnswerSelected = new Dictionary<string, bool>() { { "playground", false }, { "circuis", false }, { "tunnel", false }, { "river", false} },
                            CorrectAnswer = "river"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The Gingerbread Man knew he couldn’t do what?",
                            AnswerArray =  new ObservableCollection<string>() { "skip", "swim", "see-saw", "spell" },
                            AnswerSelected = new Dictionary<string, bool>() { { "skip", false }, { "swim", false }, { "see-saw", false }, {"spell", false} },
                            CorrectAnswer = "swim"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: What animal did the Gingerbread Man see by a blackberry bush?",
                            AnswerArray =  new ObservableCollection<string>() { "crocodile", "fox", "beaver", "robin" },
                            AnswerSelected = new Dictionary<string, bool>() { { "crocodile", false }, { "fox", false }, { "beaver", false }, {"robin", false} },
                            CorrectAnswer = "fox"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The Gingerbread Man thought about racing to look for a what?",
                            AnswerArray =  new ObservableCollection<string>() { "wheelbarrow", "oven", "bridge", "garden" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wheelbarrow", false }, { "oven", false }, { "bridge", false }, {"garden", false} },
                            CorrectAnswer = "bridge"
                        }
                    },
                    PlayTime = new TimeSpan(0, 4, 55), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 5
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Gingerbread Man Quiz 5",
                    AssociatedImage = "S8_TGM_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The fox said he’d just dined on a fine fat what?",
                            AnswerArray = new ObservableCollection<string>() { "bone", "rabbit", "taco", "sandwich" },
                            AnswerSelected = new Dictionary<string, bool>() { { "bone", false }, { "rabbit", false }, { "taco", false }, { "sandwich", false} },
                            CorrectAnswer = "rabbit"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The fox said for the Gingerbread Man to hop on the fox’s what?",
                            AnswerArray =  new ObservableCollection<string>() { "tail", "shoulder", "rump", "paw" },
                            AnswerSelected = new Dictionary<string, bool>() { { "tail", false }, { "shoulder", false }, { "rump", false }, { "paw", false} },
                            CorrectAnswer = "tail"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The fox said he would do what to cross the river?",
                            AnswerArray =  new ObservableCollection<string>() { "skate", "swim", "sail", "jump" },
                            AnswerSelected = new Dictionary<string, bool>() { { "skate", false }, { "swim", false }, { "sail", false }, {"jump", false} },
                            CorrectAnswer = "swim"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The fox said he would lift the Gingerbread Man above the what?",
                            AnswerArray =  new ObservableCollection<string>() { "boat", "stone", "water", "bridge" },
                            AnswerSelected = new Dictionary<string, bool>() { { "boat", false }, { "stone", false }, { "water", false }, {"bridge", false} },
                            CorrectAnswer = "water"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The Gingerbread Man told the fox, no what?",
                            AnswerArray =  new ObservableCollection<string>() { "money", "crying", "dancing", "tricks" },
                            AnswerSelected = new Dictionary<string, bool>() { { "money", false }, { "crying", false }, { "dancing", false }, {"tricks", false} },
                            CorrectAnswer = "tricks"
                        }
                    },
                    PlayTime = new TimeSpan(0, 5, 30), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 6
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Gingerbread Man Quiz 6",
                    AssociatedImage = "S8_TGM_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The fox said hop on his back because what was getting wet and sinking?",
                            AnswerArray =  new ObservableCollection<string>() { "tail", "shoulder", "whiskers", "leg" },
                            AnswerSelected = new Dictionary<string, bool>() { { "tail", false }, { "shoulder", false }, { "whiskers", false }, { "leg", false} },
                            CorrectAnswer = "tail"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The fox told the Gingerbread Man to hop on the tip of his what?",
                            AnswerArray =  new ObservableCollection<string>() { "ear", "nose", "rump", "paw" },
                            AnswerSelected = new Dictionary<string, bool>() { { "ear", false }, { "nose", false }, { "rump", false }, { "paw", false} },
                            CorrectAnswer = "nose"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Who was rude and impolite to almost everybody else in the story?",
                            AnswerArray =  new ObservableCollection<string>() { "dog", "grandmother", "cow", "Gingerbead Man" },
                            AnswerSelected = new Dictionary<string, bool>() { { "dog", false }, { "grandmother", false }, { "cow", false }, {"Gingerbread Man", false} },
                            CorrectAnswer = "Gingerbread Man"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Who was quicker than everyone else in the story?",
                            AnswerArray =  new ObservableCollection<string>() { "grandfather", "fox", "cat", "Gingerbread Man" },
                            AnswerSelected = new Dictionary<string, bool>() { { "grandfather", false }, { "fox", false }, { "cat", false }, {"Gingerbread Man", false} },
                            CorrectAnswer = "fox"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Who was the trickiest one of all in the story?",
                            AnswerArray =  new ObservableCollection<string>() { "horse", "Gingerbread Man", "fox", "cat" },
                            AnswerSelected = new Dictionary<string, bool>() { { "horse", false }, { "Gingerbread Man", false }, { "fox", false }, {"cat", false} },
                            CorrectAnswer = "fox"
                        }
                    },
                    PlayTime = new TimeSpan(0, 7, 23), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for Rumplestiltskin
            else if (storyName.Equals("Rumplestiltskin"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "Rumplestiltskin Quiz 1",
                    AssociatedImage = "S9_R_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: What turned the big wooden wheel found in the mill?",
                            AnswerArray =  new ObservableCollection<string>() { "a horse", "a cow", "water", "wind" },
                            AnswerSelected = new Dictionary<string, bool>() { { "a horse", false }, { "a cow", false }, { "water", false }, { "wind", false} },
                            CorrectAnswer = "water"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The mill ground wheat into flour powder for people to cook and make their what?",
                            AnswerArray =  new ObservableCollection<string>() { "tea", "bread", "pudding", "soup" },
                            AnswerSelected = new Dictionary<string, bool>() { { "tea", false }, { "bread", false }, { "pudding", false }, { "soup", false} },
                            CorrectAnswer = "bread"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3:The miller said his daughter could spin gold out of what?",
                            AnswerArray =  new ObservableCollection<string>() { "straw", "cobwebs", "sticks", "ribbons" },
                            AnswerSelected = new Dictionary<string, bool>() { { "straw", false }, { "cobwebs", false }, { "sticks", false }, {"ribbons", false} },
                            CorrectAnswer = "straw"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The miller bragged to whom that his daughter could spin gold?",
                            AnswerArray =  new ObservableCollection<string>() { "robber", "hunter", "doctor", "king" },
                            AnswerSelected = new Dictionary<string, bool>() { { "robber", false }, { "hunter", false }, { "doctor", false }, {"king", false} },
                            CorrectAnswer = "king"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: In the king’s chamber there was straw and a big wooden spinning what?",
                            AnswerArray =  new ObservableCollection<string>() { "wheel", "top", "merry-go-round", "button" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wheel", false }, { "top", false }, { "merry-go-round", false }, {"button", false} },
                            CorrectAnswer = "wheel"
                        }
                    },
                    PlayTime = new TimeSpan(0, 0, 32), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "Rumplestiltskin Quiz 2",
                    AssociatedImage = "S9_R_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The king said if the girl didn’t spin straw into gold she would lose her what?",
                            AnswerArray =  new ObservableCollection<string>() { "lamb", "pancakes", "hearing", "life" },
                            AnswerSelected = new Dictionary<string, bool>() { { "lamb", false }, { "pancakes", false }, { "hearing", false }, { "life", false} },
                            CorrectAnswer = "life"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: It didn’t help when the girl said her father had only been what?",
                            AnswerArray =  new ObservableCollection<string>() { "whistling", "rude", "bragging", "polite" },
                            AnswerSelected = new Dictionary<string, bool>() { { "whistling", false }, { "rude", false }, { "bragging", false }, { "polite", false} },
                            CorrectAnswer = "bragging"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The girl promised to give the little man what if he helped her?",
                            AnswerArray =  new ObservableCollection<string>() { "pie", "necklace", "pennies", "candlestick" },
                            AnswerSelected = new Dictionary<string, bool>() { { "pie", false }, { "necklace", false }, { "pennies", false }, {"candlestick", false} },
                            CorrectAnswer = "necklace"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: While he worked the little man whistled and did what?",
                            AnswerArray =  new ObservableCollection<string>() { "sing", "dance", "read", "tumble" },
                            AnswerSelected = new Dictionary<string, bool>() { { "sing", false }, { "dance", false }, { "read", false }, {"tumble", false} },
                            CorrectAnswer = "sing"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: What word rhymes with behold?",
                            AnswerArray =  new ObservableCollection<string>() { "straw", "gold", "spin", "sillycat" },
                            AnswerSelected = new Dictionary<string, bool>() { { "straw", false }, { "gold", false }, { "spin", false }, {"sillycat", false} },
                            CorrectAnswer = "gold"
                        }
                    },
                    PlayTime = new TimeSpan(0, 1, 42), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "Rumplestiltskin Quiz 3",
                    AssociatedImage = "S9_R_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Whose heart was greedy for gold?",
                            AnswerArray =  new ObservableCollection<string>() { "king", "grandmother", "miller", "dwarf" },
                            AnswerSelected = new Dictionary<string, bool>() { { "king", false }, { "grandmother", false }, { "miller", false }, { "dwarf", false} },
                            CorrectAnswer = "king"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: What did the girl promise the dwarf man the second time?",
                            AnswerArray =  new ObservableCollection<string>() { "candy", "toys", "bees", "ring" },
                            AnswerSelected = new Dictionary<string, bool>() { { "candy", false }, { "toys", false }, { "bees", false }, { "ring", false} },
                            CorrectAnswer = "ring"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The king said if the girl spun more gold he would make her what?",
                            AnswerArray =  new ObservableCollection<string>() { "judge", "queen", "doctor", "dancer" },
                            AnswerSelected = new Dictionary<string, bool>() { { "judge", false }, { "queen", false }, { "doctor", false }, {"dancer", false} },
                            CorrectAnswer = "queen"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The third time what does the girl say she has left to give the dwarf man?",
                            AnswerArray =  new ObservableCollection<string>() { "boat", "robot", "nothing", "marionette" },
                            AnswerSelected = new Dictionary<string, bool>() { { "boat", false }, { "robot", false }, { "nothing", false }, {"marionette", false} },
                            CorrectAnswer = "nothing"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The dwarf man says the girl must give him her first little what?",
                            AnswerArray =  new ObservableCollection<string>() { "kitten", "puppy", "child", "doll" },
                            AnswerSelected = new Dictionary<string, bool>() { { "kitten", false }, { "puppy", false }, { "child", false }, {"doll", false} },
                            CorrectAnswer = "child"
                        }
                    },
                    PlayTime = new TimeSpan(0, 3, 20), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 4
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "Rumplestiltskin Quiz 4",
                    AssociatedImage = "S9_R_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The miller’s daughter really did become what?",
                            AnswerArray =  new ObservableCollection<string>() { "judge", "doctor", "queen", "dancer" },
                            AnswerSelected = new Dictionary<string, bool>() { { "judge", false }, { "doctor", false }, { "queen", false }, { "dancer", false} },
                            CorrectAnswer = "queen"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: When her first child was born, the girl forgot the promise she made to what person?",
                            AnswerArray =  new ObservableCollection<string>() { "dwarf", "king", "miller", "grandmother" },
                            AnswerSelected = new Dictionary<string, bool>() { { "dwarf", false }, { "king", false }, { "miller", false }, {"grandmother", false} },
                            CorrectAnswer = "dwarf"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: When the dwarf man came back how did the girl feel?",
                            AnswerArray =  new ObservableCollection<string>() { "cold", "hungry", "proud", "sad" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cold", false }, { "hungry", false }, { "proud", false }, {"sad", false} },
                            CorrectAnswer = "sad"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The dwarf man gave the girl how many days to wait?",
                            AnswerArray =  new ObservableCollection<string>() { "3", "6", "9", "12" },
                            AnswerSelected = new Dictionary<string, bool>() { { "3", false }, { "6", false }, { "9", false }, {"12", false} },
                            CorrectAnswer = "3"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The dwarf man said she could keep the child if she could tell the dwarf man his what?",
                            AnswerArray =  new ObservableCollection<string>() { "story", "rhyme", "pets", "name" },
                            AnswerSelected = new Dictionary<string, bool>() { { "story", false }, { "rhyme", false }, { "pets", false }, {"name", false} },
                            CorrectAnswer = "name"
                        }
                    },
                    PlayTime = new TimeSpan(0, 4, 52), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 5
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "Rumplestiltskin Quiz 5",
                    AssociatedImage = "S9_R_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Which time did the queen guess the names Timothy, Ichabod, Benjamin, Jeremiah?",
                            AnswerArray =  new ObservableCollection<string>() { "first", "third", "last", "never" },
                            AnswerSelected = new Dictionary<string, bool>() { { "first", false }, { "third", false }, { "last", false }, { "never", false} },
                            CorrectAnswer = "first"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Which time did the queen guess the names Bowlegs, Numbskull, Goofball?",
                            AnswerArray =  new ObservableCollection<string>() { "first", "second", "last", "never" },
                            AnswerSelected = new Dictionary<string, bool>() { { "first", false }, { "second", false }, { "last", false }, { "never", false} },
                            CorrectAnswer = "second"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The messenger saw a man in front of a little what that was made of thorn sticks and branches?",
                            AnswerArray =  new ObservableCollection<string>() { "see-saw", "gate", "hut", "tower" },
                            AnswerSelected = new Dictionary<string, bool>() { { "see-saw", false }, { "gate", false }, { "hut", false }, {"tower", false} },
                            CorrectAnswer = "hut"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The dwarf man was dancing round about a what?",
                            AnswerArray =  new ObservableCollection<string>() { "bicycle", "clown", "fire", "grasshopper" },
                            AnswerSelected = new Dictionary<string, bool>() { { "bicycle", false }, { "clown", false }, { "fire", false }, {"grasshopper", false} },
                            CorrectAnswer = "fire"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The dwarf man sang that his name was what?",
                            AnswerArray =  new ObservableCollection<string>() { "Sillycat", "Rumplestiltskin", "Grumpybear", "Kertyschoo" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Sillycat", false }, { "Rumplestiltskin", false }, { "Grumpybear", false }, {"Kertyschoo", false} },
                            CorrectAnswer = "Rumplestiltskin"
                        }
                    },
                    PlayTime = new TimeSpan(0, 6, 22), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 6
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "Rumplestiltskin Quiz 6",
                    AssociatedImage = "S9_R_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: When the dwarf man came the third time the girl sat on her what?",
                            AnswerArray =  new ObservableCollection<string>() { "bed", "blanket", "throne", "tricycle" },
                            AnswerSelected = new Dictionary<string, bool>() { { "bed", false }, { "blanket", false }, { "throne", false }, { "tricycle", false} },
                            CorrectAnswer = "throne"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: On the last day the queen’s first guess was?",
                            AnswerArray =  new ObservableCollection<string>() { "Sunil", "Luis", "Khalid", "John" },
                            AnswerSelected = new Dictionary<string, bool>() { { "Sunil", false }, { "Luis", false }, { "Khalid", false }, { "John", false} },
                            CorrectAnswer = "John"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Rumplestiltskin said what kind of person told the girl his name?",
                            AnswerArray =  new ObservableCollection<string>() { "laundress", "witch", "mermaid", "fairy" },
                            AnswerSelected = new Dictionary<string, bool>() { { "laundress", false }, { "witch", false }, { "mermaid", false }, {"fairy", false} },
                            CorrectAnswer = "witch"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Rumplestiltskin slammed what part of his body deep into the floor?",
                            AnswerArray =  new ObservableCollection<string>() { "nose", "tongue", "foot", "elbow" },
                            AnswerSelected = new Dictionary<string, bool>() { { "nose", false }, { "tongue", false }, { "foot", false }, {"elbow", false} },
                            CorrectAnswer = "foot"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Who in the story disappeared and was never seen again?",
                            AnswerArray =  new ObservableCollection<string>() { "king", "Rumplestiltskin", "queen", "baby" },
                            AnswerSelected = new Dictionary<string, bool>() { { "king", false }, { "Rumplestiltskin", false }, { "queen", false }, {"baby", false} },
                            CorrectAnswer = "Rumplestiltskin"
                        }
                    },
                    PlayTime = new TimeSpan(0, 7, 34), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }

            // Quizzes for the Little Red Riding Hood
            else if (storyName.Equals("Little Red Riding Hood"))
            {
                // Quiz 1
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Riding Hood Quiz 1",
                    AssociatedImage = "S10_LRRH_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Who gave the little girl a red cape and hood?",
                            AnswerArray =  new ObservableCollection<string>() { "wolf", "grandmother", "pixie", "elf" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wolf", false }, { "grandmother", false }, { "pixie", false }, { "elf", false} },
                            CorrectAnswer = "grandmother"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Her mother asked the girl to take the grandmother some milk and a piece of what?",
                            AnswerArray =  new ObservableCollection<string>() { "cake", "pumpkin", "cheese", "ribbon" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cake", false }, { "pumpkin", false }, { "cheese", false }, { "ribbon", false} },
                            CorrectAnswer = "cake"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The grandmother was feeling what?",
                            AnswerArray =  new ObservableCollection<string>() { "ticklish", "clumsy", "sick", "forgetful" },
                            AnswerSelected = new Dictionary<string, bool>() { { "ticklish", false }, { "clumsy", false }, { "sick", false }, {"forgetful", false} },
                            CorrectAnswer = "sick"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The mother told the girl not to run off the what?",
                            AnswerArray =  new ObservableCollection<string>() { "bridge", "ice", "waterfall", "path" },
                            AnswerSelected = new Dictionary<string, bool>() { { "bridge", false }, { "ice", false }, { "waterfall", false }, {"path", false} },
                            CorrectAnswer = "path"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The little girl promised her mother to be what?",
                            AnswerArray =  new ObservableCollection<string>() { "careful", "rude", "funny", "quiet" },
                            AnswerSelected = new Dictionary<string, bool>() { { "careful", false }, { "rude", false }, { "funny", false }, {"quiet", false} },
                            CorrectAnswer = "careful"
                        }
                    },
                    PlayTime = new TimeSpan(0, 0, 32), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 2
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Riding Hood Quiz 2",
                    AssociatedImage = "S10_LRRH_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Little Red Riding Hood met the wolf when she entered the what?",
                            AnswerArray =  new ObservableCollection<string>() { "town", "barn", "wood", "playground" },
                            AnswerSelected = new Dictionary<string, bool>() { { "town", false }, { "barn", false }, { "wood", false }, { "playground", false} },
                            CorrectAnswer = "wood"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: Little Red Riding Hood wasn’t afraid of the wolf because she didn’t know the wolf was what?",
                            AnswerArray =  new ObservableCollection<string>() { "funny", "bored", "sweet", "wicked" },
                            AnswerSelected = new Dictionary<string, bool>() { { "funny", false }, { "bored", false }, { "sweet", false }, { "wicked", false} },
                            CorrectAnswer = "wicked"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The grandmother’s house stands near three large what?",
                            AnswerArray =  new ObservableCollection<string>() { "trees", "swings", "puddles", "ditches" },
                            AnswerSelected = new Dictionary<string, bool>() { { "trees", false }, { "swings", false }, { "puddles", false }, {"ditches", false} },
                            CorrectAnswer = "trees"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The wolf thought who would be especially delicious?",
                            AnswerArray =  new ObservableCollection<string>() { "grandmother", "cat", "Red Riding Hood", "huntsman" },
                            AnswerSelected = new Dictionary<string, bool>() { { "grandmother", false }, { "cat", false }, { "Red Riding Hood", false }, {"huntsman", false} },
                            CorrectAnswer = "Red Riding Hood"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The wolf decided he must be very crafty and what?",
                            AnswerArray =  new ObservableCollection<string>() { "simple", "sweet", "rude", "sneaky" },
                            AnswerSelected = new Dictionary<string, bool>() { { "simple", false }, { "sweet", false }, { "rude", false }, {"sneaky", false} },
                            CorrectAnswer = "sneaky"
                        }
                    },
                    PlayTime = new TimeSpan(0, 3, 00), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 3
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Riding Hood Quiz 3",
                    AssociatedImage = "S10_LRRH_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: The wolf told Little Red Riding Hood to look at the pretty what?",
                            AnswerArray =  new ObservableCollection<string>() { "flowers", "balloon", "moon", "necklace" },
                            AnswerSelected = new Dictionary<string, bool>() { { "flowers", false }, { "balloon", false }, { "moon", false }, { "necklace", false} },
                            CorrectAnswer = "flowers"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The wolf told Little Red Riding Hood what animals were singing sweetly?",
                            AnswerArray =  new ObservableCollection<string>() { "alligators", "giraffes", "birds", "worms" },
                            AnswerSelected = new Dictionary<string, bool>() { { "alligators", false }, { "giraffes", false }, { "birds", false }, { "worms", false} },
                            CorrectAnswer = "birds"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Little Red Riding Hood decided to gather what for her mother?",
                            AnswerArray =  new ObservableCollection<string>() { "plums", "flowers", "blueberries", "bees" },
                            AnswerSelected = new Dictionary<string, bool>() { { "plums", false }, { "flowers", false }, { "blueberries", false }, {"bees", false} },
                            CorrectAnswer = "flowers"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Little Red Riding Hood ran off the what into the woods?",
                            AnswerArray =  new ObservableCollection<string>() { "mountain", "playground", "path", "stepladder" },
                            AnswerSelected = new Dictionary<string, bool>() { { "mountain", false }, { "playground", false }, { "path", false }, {"stepladder", false} },
                            CorrectAnswer = "path"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: The wolf told the grandmother that he was what person?",
                            AnswerArray =  new ObservableCollection<string>() { "wolf", "king", "huntsman", "Red Riding Hood" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wolf", false }, { "king", false }, { "huntsman", false }, {"Red Riding Hood", false} },
                            CorrectAnswer = "Red Riding Hood"
                        }
                    },
                    PlayTime = new TimeSpan(0, 4, 13), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 4
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Riding Hood Quiz 4",
                    AssociatedImage = "S10_LRRH_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: Who did the wolf first devour and eat up completely?",
                            AnswerArray =  new ObservableCollection<string>() { "grandmother", "cat", "queen", "huntsman" },
                            AnswerSelected = new Dictionary<string, bool>() { { "grandmother", false }, { "cat", false }, { "queen", false }, { "huntsman", false} },
                            CorrectAnswer = "grandmother"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The curtains went completely around the grandmother’s what?",
                            AnswerArray =  new ObservableCollection<string>() { "table", "bed", "oven", "chimney" },
                            AnswerSelected = new Dictionary<string, bool>() { { "table", false }, { "bed", false }, { "oven", false }, { "chimney", false} },
                            CorrectAnswer = "bed"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: The wolf put on the grandmother’s cap and what?",
                            AnswerArray =  new ObservableCollection<string>() { "backpack", "sunglasses", "mittens", "nightgown" },
                            AnswerSelected = new Dictionary<string, bool>() { { "backpack", false }, { "sunglasses", false }, { "mittens", false }, {"nightgown", false} },
                            CorrectAnswer = "nightgown"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: Little Red Riding Hood was surprised to find the cottage-door what?",
                            AnswerArray =  new ObservableCollection<string>() { "wet", "painted", "open", "whistling" },
                            AnswerSelected = new Dictionary<string, bool>() { { "wet", false }, { "painted", false }, { "open", false }, {"whistling", false} },
                            CorrectAnswer = "open"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Little Red Riding Hood first said grandmother had big what?",
                            AnswerArray =  new ObservableCollection<string>() { "whiskers", "paws", "ears", "horns" },
                            AnswerSelected = new Dictionary<string, bool>() { { "whiskers", false }, { "paws", false }, { "ears", false }, {"horns", false} },
                            CorrectAnswer = "ears"
                        }
                    },
                    PlayTime = new TimeSpan(0, 5, 30), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 5
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Riding Hood Quiz 5",
                    AssociatedImage = "S10_LRRH_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: After ears, Little Red Riding Hood next said grandmother had big what?",
                            AnswerArray =  new ObservableCollection<string>() { "whiskers", "legs", "eyes", "flippers" },
                            AnswerSelected = new Dictionary<string, bool>() { { "whiskers", false }, { "legs", false }, { "eyes", false }, {"flippers", false} },
                            CorrectAnswer = "eyes"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The wolf said that his big hairy hands were all the better to do what with?",
                            AnswerArray =  new ObservableCollection<string>() { "hug", "scratch", "tease", "trick" },
                            AnswerSelected = new Dictionary<string, bool>() { { "hug", false }, { "scratch", false }, { "tease", false }, { "trick", false} },
                            CorrectAnswer = "hug"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: After hands,  Little Red Riding Hood next said grandmother had a big what?",
                            AnswerArray =  new ObservableCollection<string>() { "tummy", "tail", "rump", "mouth" },
                            AnswerSelected = new Dictionary<string, bool>() { { "tummy", false }, { "tail", false }, { "rump", false }, {"mouth", false} },
                            CorrectAnswer = "mouth"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: The wolf went to sleep and began to make what noise?",
                            AnswerArray =  new ObservableCollection<string>() { "whistle", "cry", "snore", "burp" },
                            AnswerSelected = new Dictionary<string, bool>() { { "whistle", false }, { "cry", false }, { "snore", false }, {"burp", false} },
                            CorrectAnswer = "snore"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Who found the wolf sleeping in grandmother’s bed?",
                            AnswerArray =  new ObservableCollection<string>() { "judge", "huntsman", "grandfather", "queen" },
                            AnswerSelected = new Dictionary<string, bool>() { { "judge", false }, { "huntsman", false }, { "grandfather", false }, {"queen", false} },
                            CorrectAnswer = "huntsman"
                        }
                    },
                    PlayTime = new TimeSpan(0, 6, 50), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });

                // Quiz 6
                QuizTemp.Add(new Quiz()
                {
                    QuizName = "The Little Red Riding Hood Quiz 6",
                    AssociatedImage = "S10_LRRH_1.jpg",
                    Score = 0,
                    Questions = new ObservableCollection<Question>()
                    {
                        new Question()
                        {
                            QuestionText = "Question 1: What did the Huntsman have but not use to kill the wolf?",
                            AnswerArray =  new ObservableCollection<string>() { "rope", "gun", "knife", "stone" },
                            AnswerSelected = new Dictionary<string, bool>() { { "rope", false }, { "gun", false }, { "knife", false }, {"stone", false} },
                            CorrectAnswer = "gun"
                        },
                        new Question()
                        {
                            QuestionText = "Question 2: The Huntsman used the grandmother’s what to cut open the wolf?",
                            AnswerArray =  new ObservableCollection<string>() { "scissors", "clippers", "fingernails", "saw" },
                            AnswerSelected = new Dictionary<string, bool>() { { "scissors", false }, { "clippers", false }, { "fingernails", false }, { "saw", false} },
                            CorrectAnswer = "scissors"
                        },
                        new Question()
                        {
                            QuestionText = "Question 3: Little Red Riding Hood fetched great what to put in the wolf’s belly?",
                            AnswerArray =  new ObservableCollection<string>() { "cucumbers", "jellyfish", "stones", "onions" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cucumbers", false }, { "jellyfish", false }, { "stones", false }, {"onions", false} },
                            CorrectAnswer = "stones"
                        },
                        new Question()
                        {
                            QuestionText = "Question 4: When the Huntsman didn’t just shoot the wolf, but thought maybe someone might be saved inside the wolf’s tummy, the Huntsman was being what?",
                            AnswerArray =  new ObservableCollection<string>() { "cranky", "forgetful", "clumsy", "smart" },
                            AnswerSelected = new Dictionary<string, bool>() { { "cranky", false }, { "forgetful", false }, { "clumsy", false }, {"smart", false} },
                            CorrectAnswer = "smart"
                        },
                        new Question()
                        {
                            QuestionText = "Question 5: Little Red Riding Hood got into trouble because she disobeyed her mother and left the what?",
                            AnswerArray =  new ObservableCollection<string>() { "garden", "playground", "bridge", "path" },
                            AnswerSelected = new Dictionary<string, bool>() { { "garden", false }, { "playground", false }, { "bridge", false }, {"path", false} },
                            CorrectAnswer = "path"
                        }
                    },
                    PlayTime = new TimeSpan(0, 8, 34), //TODO: might need to change time
                    NumQuestions = 5,
                    NumAttempts = new ObservableCollection<int>()
                    { 0, 0, 0, 0, 0 },
                    NumAttemptsQuiz = 0
                });
            }
            return QuizTemp;
        }
    }
}
