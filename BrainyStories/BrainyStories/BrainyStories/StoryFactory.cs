using BrainyStories.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BrainyStories {


    public class StoryFactory {

        private ThinkAndDoFactory thinkAndDoFactory = new ThinkAndDoFactory();

        //MANUAL LIST OF STORIES
        public ObservableCollection<Story> generateStories()
        {
            ObservableCollection<Story> storyListTemp = new ObservableCollection<Story>();

            //STORY 1
            storyListTemp.Add(new Story
            {
                Name = "The Lion and the Mouse",
                Icon = "S1_LATM_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 51),
                WordCount = 395,
                Description = "A lion releases a mouse, believing it’s too small and weak ever to return the favor, " +
                    "but when the lion is trapped in a net the mouse gnaws the threads and releases the lion.",
                ListOfIcons = CreateStoryActivitiesStack(3, 1, AppealType.Animal),
            });

            //STORY 2
            storyListTemp.Add(new Story
            {
                Name = "The Little Red Hen",
                Icon = "S2_LRH_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 4,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 3, 14),
                WordCount = 477,
                Description = "Lazy animals refuse to help the hen plant the seed, harvest the grain, or bake the " +
                    "bread, so the hen refuses to share the baked bread with the lazy animals.",
                ListOfIcons = CreateStoryActivitiesStack(4, 1, AppealType.Animal)
            });

            //STORY 3
            storyListTemp.Add(new Story
            {
                Name = "The Boy Who Cried Wolf",
                Icon = "S3_TBWCW_1.jpg",
                Appeal = AppealType.Male,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 4, 37),
                WordCount = 722,
                Description = "Bored watching over the sheep, a boy causes excitement by lying that a wolf " +
                    "threatens; when a real wolf attacks, the people think the boy’s lying and won’t come to help him.",
                ListOfIcons = CreateStoryActivitiesStack(3, 1, AppealType.Male)
            });

            //STORY 4
            storyListTemp.Add(new Story
            {
                Name = "The Elves and Shoemaker",
                Icon = "S4_TEATS_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 06),
                WordCount = 830,
                Description = "By secretly making shoes, two elves save a poor shoemaker and his wife; " +
                    "the man and wife make clothes to reward the elves, who leave when their help is no longer needed.",
                ListOfIcons = CreateStoryActivitiesStack(3, 1, AppealType.Animal)
            });

            //STORY 5
            storyListTemp.Add(new Story
            {
                Name = "The Three Little Pigs",
                Icon = "S5_TLP_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 34),
                WordCount = 986,
                Description = "Two pigs squander their money and build shabby houses; their smarter brother " +
                    "saves and works hard to build a brick house which protects them all from the big bad wolf.",
                ListOfIcons = CreateStoryActivitiesStack(5, 1, AppealType.Animal)
            });

            //STORY 6
            storyListTemp.Add(new Story
            {
                Name = "The Three Billy Goats Gruff",
                Icon = "S6_BGG_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 3, //TODO: DON'T KNOW HOW MANY QUIZZES
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 38),
                WordCount = 891,
                Description = "Two billy goats trick a mean troll into waiting for their brother; " +
                    "with his horns the big brother knocks the troll off the bridge.",
                ListOfIcons = CreateStoryActivitiesStack(3, 1, AppealType.Animal)
            });

            //STORY 7
            storyListTemp.Add(new Story
            {
                Name = "The Tale of Peter Rabbit",
                Icon = "S7_PR_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 7, 29),
                WordCount = 933,
                Description = "Peter disobeys his mother and enters Mr. MacGregor’s garden, where he is almost " +
                    "captured and put into a pie; Peter escapes and returns to his mother who scolds him.",
                ListOfIcons = CreateStoryActivitiesStack(5, 1, AppealType.Animal)
            });

            //STORY 8
            storyListTemp.Add(new Story
            {
                Name = "The Gingerbread Man",
                Icon = "S8_TGM_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 7, 39),
                WordCount = 1095,
                Description = "The Gingerbread Man speaks rudely, brags, and outruns all the people " +
                    "and animals until the fox’s help, is tricked and swallowed.",
                ListOfIcons = CreateStoryActivitiesStack(5, 1, AppealType.General)
            });

            //STORY 9
            storyListTemp.Add(new Story
            {
                Name = "Rumplestiltskin",
                Icon = "S9_R_1.jpg",
                Appeal = AppealType.Female,
                QuizNum = 6,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 8, 18),
                WordCount = 1344,
                Description = "A cruel man spins straw into gold to save a girl’s life, demanding her " +
                    "first child in payment; when she’s queen she saves her child by learning the man’s secret name.",
                ListOfIcons = CreateStoryActivitiesStack(6, 1, AppealType.Female)
            });

            //STORY 10
            storyListTemp.Add(new Story
            {
                Name = "Little Red Riding Hood",
                Icon = "S10_LRRH_1.jpg",
                Appeal = AppealType.Female,
                QuizNum = 6,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 8, 47),
                WordCount = 1243,
                Description = "A girl speaks to a wolf and leaves the proper path; the wolf swallows the grandmother" +
                              " and girl, but a huntsman kills the wolf, opens the wolf’s belly, and rescues both of them.",
                ListOfIcons = CreateStoryActivitiesStack(6, 1, AppealType.Female)
            });

            return storyListTemp;
        }
        //END OF STORIES


        //MANUAL LIST OF IMAGINES 
        public ObservableCollection<Story> generateImagines()
        {
            ObservableCollection<Story> imaginesListTemp = new ObservableCollection<Story>();

            //IMAGINE 1
            imaginesListTemp.Add(new Story
            {
                Name = "If A Shoe Wanted to be Car",
                Icon = "I1_IASW_1.jpg",
                Appeal = AppealType.General,
                Duration = new TimeSpan(0, 1, 47),
                WordCount = 212,
                Description = "Imagine a shoe wanting to be like a car, and what a child might find in the home to help.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 2
            imaginesListTemp.Add(new Story
            {
                Name = "Do you pump your legs when you swing?",
                Icon = "I2_DYPYL_1.jpg",
                Appeal = AppealType.Male,
                Duration = new TimeSpan(0, 1, 48),
                WordCount = 206,
                Description = "Imagine swinging as high as trees, birds, clouds, or even higher, what it might feel like, what you might see.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 3
            imaginesListTemp.Add(new Story
            {
                Name = "Upside Down Windows",
                Icon = "I3_TUDW_1.jpg",
                Appeal = AppealType.Female,
                Duration = new TimeSpan(0, 1, 59),
                WordCount = 248,
                Description = "Imagine wandering into a world where everything is upside down and backwards.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 4
            imaginesListTemp.Add(new Story
            {
                Name = "The Special One-Eye Blink",
                Icon = "I4_TSOEB_1.jpg",
                Appeal = AppealType.Female,
                Duration = new TimeSpan(0, 2, 06),
                WordCount = 304,
                Description = "Imagine blinking to become very tiny and what you might be able to do if you were very, very small.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 5
            imaginesListTemp.Add(new Story
            {
                Name = "If a Naughty Angel",
                Icon = "I5_IANA_1.jpg",
                Appeal = AppealType.General,
                Duration = new TimeSpan(0, 2, 32),
                WordCount = 399,
                Description = "Imagine what you’d say if a little angel asked your advice on how to be a tiny bit mischievous.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 6
            imaginesListTemp.Add(new Story
            {
                Name = "If You Decide to be a Kitten",
                Icon = "I6_DTBAK_1.jpg",
                Appeal = AppealType.General,
                Duration = new TimeSpan(0, 2, 40),
                WordCount = 326,
                Description = "Imagine what it might be like to be a kitten.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 7
            imaginesListTemp.Add(new Story
            {
                Name = "Nobody's Better than You",
                Icon = "I7_NBTY_1.jpg",
                Appeal = AppealType.General,
                Duration = new TimeSpan(0, 2, 40),
                WordCount = 352,
                Description = "Always remember, nobody’s better than you.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 8
            imaginesListTemp.Add(new Story
            {
                Name = "If a Piece of Dirt...",
                Icon = "I8_IAPOD_1.jpg",
                Appeal = AppealType.General,
                Duration = new TimeSpan(0, 2, 45),
                WordCount = 350,
                Description = "Imagine some of the things you might help a sad, lonely, bored piece of dirt become.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 9
            imaginesListTemp.Add(new Story
            {
                Name = "The Imaginary Fairy Palace",
                Icon = "I9_IFP_1.jpg",
                Appeal = AppealType.General,
                Duration = new TimeSpan(0, 3, 44),
                WordCount = 396,
                Description = "Imagine the kind of home fairies might create for themselves if they wanted.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            //IMAGINE 10
            imaginesListTemp.Add(new Story
            {
                Name = "Do You Like Bubbles",
                Icon = "I10_DYLB_1.jpg",
                Appeal = AppealType.General,
                Duration = new TimeSpan(0, 2, 30),
                WordCount = 344,
                Description = "Imagine blowing bubbles in a sink or bathtub.",
                ListOfIcons = CreateStoryActivitiesStack(0, 0, null)
            });

            return imaginesListTemp;
        }
        private ObservableCollection<String> CreateStoryActivitiesStack(int quizNum, int thinkAndDoNum, AppealType type)
        {
            ObservableCollection<String> images = new ObservableCollection<String>();
            if (type != null)
            {
                images.Add(type.Value);
            }
            for (int i = 0; i < quizNum; i++)
            {
                images.Add( "QuizzesIcon.png");
            }
            for (int i = 0; i < thinkAndDoNum; i++)
            {
                images.Add("ThinkAndDoIcon.png");
            }
            return images;
        }

        public Story playedStory(String storyName)
        {
            Story chosen = new Story();
            ObservableCollection<ThinkAndDo> ThinkAndDoTemp = new ObservableCollection<ThinkAndDo>();
            ThinkAndDoTemp = thinkAndDoFactory.generateThinkAndDos();

            if (storyName.Equals("The Lion and the Mouse"))
            {
                chosen = new Story
                {
                    Name = "The Lion and the Mouse",
                    Icon = "S1_LATM_1.jpg",
                    Appeal = AppealType.Animal,
                    QuizNum = 3,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 2, 51),
                    WordCount = 395,
                    Description = "A lion releases a mouse, believing it’s too small and weak ever to return the favor, " +
                    "but when the lion is trapped in a net the mouse gnaws the threads and releases the lion.",
                    ListOfIcons = CreateStoryActivitiesStack(3, 1, AppealType.Animal),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S1_LATM_1.jpg" },
                   { new TimeSpan(0, 0, 5), "S1_LATM_2.jpg" },
                   { new TimeSpan(0, 0, 32), "S1_LATM_3.jpg" },
                   { new TimeSpan(0, 0, 49), "S1_LATM_4.jpg" },
                   { new TimeSpan(0, 1, 02), "S1_LATM_5.jpg" },
                   { new TimeSpan(0, 1, 35), "S1_LATM_6.jpg" },
                   { new TimeSpan(0, 1, 56), "S1_LATM_7.jpg" },
                   { new TimeSpan(0, 2, 30), "S1_LATM_8.jpg" }
                },
                    AudioClip = "S1_TLATM_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("The Lion and the Mouse")
                };
            }
            else if (storyName.Equals("The Little Red Hen"))
            {
                chosen = new Story
                {
                    Name = "The Little Red Hen",
                    Icon = "S2_LRH_1.jpg",
                    Appeal = AppealType.Animal,
                    QuizNum = 4,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 3, 14),
                    WordCount = 477,
                    Description = "Lazy animals refuse to help the hen plant the seed, harvest the grain, or bake the " +
                    "bread, so the hen refuses to share the baked bread with the lazy animals.",
                    ListOfIcons = CreateStoryActivitiesStack(4, 1, AppealType.Animal),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S2_LRH_1.jpg" },
                   { new TimeSpan(0, 0, 5), "S2_LRH_2.jpg" },
                   { new TimeSpan(0, 0, 32), "S2_LRH_3.jpg" },
                   { new TimeSpan(0, 0, 49), "S2_LRH_4.jpg" },
                   { new TimeSpan(0, 1, 02), "S2_LRH_5.jpg" },
                   { new TimeSpan(0, 1, 35), "S2_LRH_6.jpg" },
                   { new TimeSpan(0, 1, 56), "S2_LRH_7.jpg" }
                },
                    AudioClip = "S2_LRH_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("Little Red Hen")
                };
            }
            else if (storyName.Equals("The Boy Who Cried Wolf"))
            {
                chosen = new Story
                {
                    Name = "The Boy Who Cried Wolf",
                    Icon = "S3_TBWCW_1.jpg",
                    Appeal = AppealType.Male,
                    QuizNum = 3,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 4, 37),
                    WordCount = 722,
                    Description = "Bored watching over the sheep, a boy causes excitement by lying that a wolf " +
                    "threatens; when a real wolf attacks, the people think the boy’s lying and won’t come to help him.",
                    ListOfIcons = CreateStoryActivitiesStack(3, 1, AppealType.Male),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S3_TBWCW_1.jpg" },
                   { new TimeSpan(0, 0, 2), "S3_TBWCW_2.jpg" },
                   { new TimeSpan(0, 0, 34), "S3_TBWCW_3.jpg" },
                   { new TimeSpan(0, 1, 17), "S3_TBWCW_4.jpg" },
                   { new TimeSpan(0, 1, 45), "S3_TBWCW_5.jpg" },
                   { new TimeSpan(0, 2, 21), "S3_TBWCW_6.jpg" },
                   { new TimeSpan(0, 2, 59), "S3_TBWCW_7.jpg" },
                   { new TimeSpan(0, 3, 29), "S3_TBWCW_8.jpg" },
                   { new TimeSpan(0, 3, 43), "S3_TBWCW_9.jpg" }
                },
                    AudioClip = "S3_BWCW_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("Boy Who Cried Wolf")
                };
            }
            else if (storyName.Equals("The Elves and Shoemaker"))
            {
                chosen = new Story
                {
                    Name = "The Elves and Shoemaker",
                    Icon = "S4_TEATS_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 3,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 6, 06),
                    WordCount = 830,
                    Description = "By secretly making shoes, two elves save a poor shoemaker and his wife; " +
                    "the man and wife make clothes to reward the elves, who leave when their help is no longer needed.",
                    ListOfIcons = CreateStoryActivitiesStack(3, 1, AppealType.General),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S4_TEATS_1.jpg" },
                   { new TimeSpan(0, 0, 4), "S4_TEATS_2.jpg" },
                   { new TimeSpan(0, 1, 06), "S4_TEATS_3.jpg" },
                   { new TimeSpan(0, 1, 40), "S4_TEATS_4.jpg" },
                   { new TimeSpan(0, 2, 11), "S4_TEATS_5.jpg" },
                   { new TimeSpan(0, 2, 32), "S4_TEATS_6.jpg" },
                   { new TimeSpan(0, 3, 33), "S4_TEATS_7.jpg" },
                   { new TimeSpan(0, 4, 57), "S4_TEATS_8.jpg" }
                },
                    AudioClip = "S4_TEATS_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("Elves and the Shoemaker")
                };
            }
            else if (storyName.Equals("The Three Little Pigs"))
            {
                chosen = new Story
                {
                    Name = "The Three Little Pigs",
                    Icon = "S5_TLP_1.jpg",
                    Appeal = AppealType.Animal,
                    QuizNum = 5,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 6, 34),
                    WordCount = 986,
                    Description = "Two pigs squander their money and build shabby houses; their smarter brother " +
                     "saves and works hard to build a brick house which protects them all from the big bad wolf.",
                    ListOfIcons = CreateStoryActivitiesStack(5, 1, AppealType.Animal),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S5_TLP_1.jpg" }, //TODO: TRANSITIONS ARE WRONG FOR STORY 5
                   { new TimeSpan(0, 0, 27), "S5_TLP_2.jpg" },
                   { new TimeSpan(0, 1, 05), "S5_TLP_3.jpg" },
                   { new TimeSpan(0, 2, 19), "S5_TLP_4.jpg" },
                   { new TimeSpan(0, 2, 41), "S5_TLP_5.jpg" },
                   { new TimeSpan(0, 3, 12), "S5_TLP_6.jpg" },
                   { new TimeSpan(0, 3, 57), "S5_TLP_7.jpg" },
                   { new TimeSpan(0, 4, 20), "S5_TLP_8.jpg" },
                   { new TimeSpan(0, 4, 49), "S5_TLP_9.jpg" },
                   { new TimeSpan(0, 5, 58), "S5_TLP_10.jpg" },
                   { new TimeSpan(0, 6, 11), "S5_TLP_11.jpg" },
                   { new TimeSpan(0, 6, 30), "S5_TLP_12.jpg" },
                   { new TimeSpan(0, 6, 31), "S5_TLP_13.jpg" }
                },
                    AudioClip = "S5_TLP_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("Three Little Pigs")
                };
            }
            else if (storyName.Equals("The Three Billy Goats Gruff"))
            {
                chosen = new Story
                {
                    Name = "The Three Billy Goats Gruff",
                    Icon = "S6_BGG_1.jpg",
                    Appeal = AppealType.Animal,
                    QuizNum = 3, //TODO: DON'T KNOW HOW MANY QUIZZES
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 6, 38),
                    WordCount = 891,
                    Description = "Two billy goats trick a mean troll into waiting for their brother; " +
                    "with his horns the big brother knocks the troll off the bridge.",
                    ListOfIcons = CreateStoryActivitiesStack(3, 1, AppealType.Animal),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S6_BGG_1.jpg" }, //TODO: TRANSITIONS ARE WRONG FOR STORY 6
                   { new TimeSpan(0, 0, 30), "S6_BGG_2.jpg" },
                   { new TimeSpan(0, 0, 40), "S6_BGG_3.jpg" },
                   { new TimeSpan(0, 0, 50), "S6_BGG_4.jpg" },
                   { new TimeSpan(0, 1, 00), "S6_BGG_5.jpg" },
                   { new TimeSpan(0, 1, 30), "S6_BGG_6.jpg" },
                   { new TimeSpan(0, 1, 40), "S6_BGG_7.jpg" },
                   { new TimeSpan(0, 1, 50), "S6_BGG_8.jpg" },
                   { new TimeSpan(0, 2, 00), "S6_BGG_9.jpg" },
                   { new TimeSpan(0, 2, 30), "S6_BGG_10.jpg" },
                   { new TimeSpan(0, 2, 40), "S6_BGG_11.jpg" },
                   { new TimeSpan(0, 2, 50), "S6_BGG_12.jpg" },
                   { new TimeSpan(0, 3, 00), "S6_BGG_13.jpg" },
                   { new TimeSpan(0, 3, 30), "S6_BGG_14.jpg" }
                },
                    AudioClip = "S6_BGG_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("Three Billy Goats Gruff")
                };
            }
            else if (storyName.Equals("The Tale of Peter Rabbit"))
            {
                chosen = new Story
                {
                    Name = "The Tale of Peter Rabbit",
                    Icon = "S7_PR_1.jpg",
                    Appeal = AppealType.Animal,
                    QuizNum = 5,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 7, 29),
                    WordCount = 933,
                    Description = "Peter disobeys his mother and enters Mr. MacGregor’s garden, where he is almost " +
                    "captured and put into a pie; Peter escapes and returns to his mother who scolds him.",
                    ListOfIcons = CreateStoryActivitiesStack(5, 1, AppealType.Animal),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S7_PR_1.jpg" },
                   { new TimeSpan(0, 0, 19), "S7_PR_2.jpg" },
                   { new TimeSpan(0, 0, 42), "S7_PR_3.jpg" },
                   { new TimeSpan(0, 0, 53), "S7_PR_4.jpg" },
                   { new TimeSpan(0, 1, 01), "S7_PR_5.jpg" },
                   { new TimeSpan(0, 1, 09), "S7_PR_6.jpg" },
                   { new TimeSpan(0, 1, 20), "S7_PR_7.jpg" },
                   { new TimeSpan(0, 1, 27), "S7_PR_8.jpg" },
                   { new TimeSpan(0, 1, 34), "S7_PR_9.jpg" },
                   { new TimeSpan(0, 1, 45), "S7_PR_10.jpg" },
                   { new TimeSpan(0, 1, 58), "S7_PR_11.jpg" },
                   { new TimeSpan(0, 2, 18), "S7_PR_12.jpg" },
                   { new TimeSpan(0, 2, 32), "S7_PR_13.jpg" },
                   { new TimeSpan(0, 2, 40), "S7_PR_14.jpg" },
                   { new TimeSpan(0, 2, 52), "S7_PR_15.jpg" },
                   { new TimeSpan(0, 3, 05), "S7_PR_16.jpg" },
                   { new TimeSpan(0, 3, 17), "S7_PR_17.jpg" },
                   { new TimeSpan(0, 3, 32), "S7_PR_18.jpg" },
                   { new TimeSpan(0, 4, 10), "S7_PR_19.jpg" },
                   { new TimeSpan(0, 4, 42), "S7_PR_20.jpg" },
                   { new TimeSpan(0, 5, 12), "S7_PR_21.jpg" },
                   { new TimeSpan(0, 5, 35), "S7_PR_22.jpg" },
                   { new TimeSpan(0, 5, 41), "S7_PR_23.jpg" },
                   { new TimeSpan(0, 6, 09), "S7_PR_24.jpg" },
                   { new TimeSpan(0, 6, 25), "S7_PR_25.jpg" }
                },
                    AudioClip = "S7_PR_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("Tale of Peter Rabbit")
                };
            }
            else if (storyName.Equals("The Gingerbread Man"))
            {
                chosen = new Story
                {
                    Name = "The Gingerbread Man",
                    Icon = "S8_TGM_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 5,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 7, 39),
                    WordCount = 1095,
                    Description = "The Gingerbread Man speaks rudely, brags, and outruns all the people " +
                    "and animals until the fox’s help, is tricked and swallowed.",
                    ListOfIcons = CreateStoryActivitiesStack(5, 1, AppealType.General),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S8_TGM_1.jpg" },
                   { new TimeSpan(0, 0, 03), "S8_TGM_2.jpg" },
                   { new TimeSpan(0, 1, 07), "S8_TGM_3.jpg" },
                   { new TimeSpan(0, 1, 47), "S8_TGM_4.jpg" },
                   { new TimeSpan(0, 2, 26), "S8_TGM_5.jpg" },
                   { new TimeSpan(0, 3, 27), "S8_TGM_6.jpg" },
                   { new TimeSpan(0, 4, 15), "S8_TGM_7.jpg" },
                   { new TimeSpan(0, 4, 55), "S8_TGM_8.jpg" },
                   { new TimeSpan(0, 5, 30), "S8_TGM_9.jpg" },
                   { new TimeSpan(0, 6, 25), "S8_TGM_10.jpg" },
                   { new TimeSpan(0, 7, 23), "S8_TGM_11.jpg" }
                },
                    AudioClip = "S8_TGM_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("The Gingerbread Man")
                };
            }
            else if (storyName.Equals("Rumplestiltskin"))
            {
                chosen = new Story
                {
                    Name = "Rumplestiltskin",
                    Icon = "S9_R_1.jpg",
                    Appeal = AppealType.Female,
                    QuizNum = 6,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 8, 18),
                    WordCount = 1344,
                    Description = "A cruel man spins straw into gold to save a girl’s life, demanding her " +
                    "first child in payment; when she’s queen she saves her child by learning the man’s secret name.",
                    ListOfIcons = CreateStoryActivitiesStack(6, 1, AppealType.Female),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S9_R_1.jpg" },
                   { new TimeSpan(0, 0, 05), "S9_R_2.jpg" },
                   { new TimeSpan(0, 0, 32), "S9_R_3.jpg" },
                   { new TimeSpan(0, 1, 12), "S9_R_4.jpg" },
                   { new TimeSpan(0, 1, 42), "S9_R_5.jpg" },
                   { new TimeSpan(0, 2, 29), "S9_R_6.jpg" },
                   { new TimeSpan(0, 2, 52), "S9_R_7.jpg" },
                   { new TimeSpan(0, 3, 20), "S9_R_8.jpg" },
                   { new TimeSpan(0, 3, 52), "S9_R_9.jpg" },
                   { new TimeSpan(0, 4, 23), "S9_R_10.jpg" },
                   { new TimeSpan(0, 4, 52), "S9_R_11.jpg" },
                   { new TimeSpan(0, 5, 25), "S9_R_12.jpg" },
                   { new TimeSpan(0, 5, 42), "S9_R_13.jpg" },
                   { new TimeSpan(0, 5, 59), "S9_R_14.jpg" },
                   { new TimeSpan(0, 6, 22), "S9_R_15.jpg" },
                   { new TimeSpan(0, 6, 42), "S9_R_16.jpg" },
                   { new TimeSpan(0, 7, 08), "S9_R_17.jpg" },
                   { new TimeSpan(0, 7, 34), "S9_R_18.jpg" },
                   { new TimeSpan(0, 8, 06), "S9_R_19.jpg" }
                },
                    AudioClip = "S9_R_Story.mp3",
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("Rumplestiltskin")
                };
            }
            else if (storyName.Equals("Little Red Riding Hood"))
            {
                chosen = new Story
                {
                    Name = "Little Red Riding Hood",
                    Icon = "S10_LRRH_1.jpg",
                    Appeal = AppealType.Female,
                    QuizNum = 6,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 8, 47),
                    WordCount = 1243,
                    Description = "A girl speaks to a wolf and leaves the proper path; the wolf swallows the grandmother" +
                              " and girl, but a huntsman kills the wolf, opens the wolf’s belly, and rescues both of them.",
                    ListOfIcons = CreateStoryActivitiesStack(6, 1, AppealType.Female),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S10_LRRH_1.jpg" },
                   { new TimeSpan(0, 0, 05), "S10_LRRH_2.jpg" },
                   { new TimeSpan(0, 0, 32), "S10_LRRH_3.jpg" },
                   { new TimeSpan(0, 1, 07), "S10_LRRH_4.jpg" },
                   { new TimeSpan(0, 1, 13), "S10_LRRH_5.jpg" },
                   { new TimeSpan(0, 1, 57), "S10_LRRH_6.jpg" },
                   { new TimeSpan(0, 3, 00), "S10_LRRH_7.jpg" },
                   { new TimeSpan(0, 3, 42), "S10_LRRH_8.jpg" },
                   { new TimeSpan(0, 4, 13), "S10_LRRH_9.jpg" },
                   { new TimeSpan(0, 4, 38), "S10_LRRH_10.jpg" },
                   { new TimeSpan(0, 5, 30), "S10_LRRH_11.jpg" },
                   { new TimeSpan(0, 6, 13), "S10_LRRH_12.jpg" },
                   { new TimeSpan(0, 6, 50), "S10_LRRH_13.jpg" },
                   { new TimeSpan(0, 7, 32), "S10_LRRH_14.jpg" },
                   { new TimeSpan(0, 7, 55), "S10_LRRH_15.jpg" },
                   { new TimeSpan(0, 8, 34), "S10_LRRH_16.jpg" }
                },
                    AudioClip = "S9_R_Story.mp3", //TODO: NEED TO GET STORY 10 (LRRH) AUDIO
                    ThinkAndDos = thinkAndDoFactory.StoryThinkAndDos("Little Red Riding Hood")
                };
            }
            else if (storyName.Equals("If A Shoe Wanted to be Car"))
            {
                chosen = new Story
                {
                    Name = "If A Shoe Wanted to be Car",
                    Icon = "I1_IASW_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 1, 47),
                    WordCount = 212,
                    Description = "Imagine a shoe wanting to be like a car, and what a child might find in the home to help.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I1_IASW_1.jpg" },
                   { new TimeSpan(0, 0, 8), "I1_IASW_2.jpg" },
                   { new TimeSpan(0, 0, 43), "I1_IASW_3.jpg" },
                   { new TimeSpan(0, 1, 7), "I1_IASW_4.jpg" },
                   { new TimeSpan(0, 1, 26), "I1_IASW_5.jpg" }
                },
                    AudioClip = "I1_IAS_IG.mp3"
                };
            }
            else if (storyName.Equals("Do you pump your legs when you swing?"))
            {
                chosen = new Story
                {
                    Name = "Do you pump your legs when you swing?",
                    Icon = "I2_DYPYL_1.jpg",
                    Appeal = AppealType.Male,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 1, 48),
                    WordCount = 206,
                    Description = "Imagine swinging as high as trees, birds, clouds, or even higher, what it might feel like, what you might see.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I2_DYPYL_1.jpg" },
                   { new TimeSpan(0, 0, 4), "I2_DYPYL_2.jpg" },
                   { new TimeSpan(0, 0, 31), "I2_DYPYL_3.jpg" },
                   { new TimeSpan(0, 0, 55), "I2_DYPYL_4.jpg" },
                   { new TimeSpan(0, 1, 6), "I2_DYPYL_5.jpg" },
                   { new TimeSpan(0, 1, 11), "I2_DYPYL_6.jpg" },
                   { new TimeSpan(0, 1, 38), "I2_DYPYL_7.jpg" },
                },
                    AudioClip = "I2_DYPYL_IG.mp3"
                };
            }
            else if (storyName.Equals("Upside Down Windows"))
            {
                chosen = new Story
                {
                    Name = "Upside Down Windows",
                    Icon = "I3_TUDW_1.jpg",
                    Appeal = AppealType.Female,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 1, 59),
                    WordCount = 248,
                    Description = "Imagine wandering into a world where everything is upside down and backwards.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I3_TUDW_1.jpg" },
                   { new TimeSpan(0, 0, 5), "I3_TUDW_2.jpg" },
                   { new TimeSpan(0, 0, 34), "I3_TUDW_3.jpg" },
                   { new TimeSpan(0, 0, 59), "I3_TUDW_4.jpg" },
                   { new TimeSpan(0, 1, 26), "I3_TUDW_5.jpg" },
                   { new TimeSpan(0, 1, 48), "I3_TUDW_6.jpg" }
                },
                    AudioClip = "I3_UW_IG.mp3"
                };
            }
            else if (storyName.Equals("The Special One-Eye Blink"))
            {
                chosen = new Story
                {
                    Name = "The Special One-Eye Blink",
                    Icon = "I4_TSOEB_1.jpg",
                    Appeal = AppealType.Female,
                    Duration = new TimeSpan(0, 2, 06),
                    WordCount = 304,
                    Description = "Imagine blinking to become very tiny and what you might be able to do if you were very, very small.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I5_IANA_1.jpg" },
                   { new TimeSpan(0, 0, 3), "I5_IANA_2.jpg" },
                   { new TimeSpan(0, 0, 45), "I5_IANA_3.jpg" },
                   { new TimeSpan(0, 1, 4), "I5_IANA_4.jpg" },
                   { new TimeSpan(0, 1, 37), "I5_IANA_5.jpg" },
                   { new TimeSpan(0, 2, 12), "I5_IANA_6.jpg" }
                    },
                    AudioClip = "I5_IANA_IG.mp3",
                };
            }
            else if (storyName.Equals("If a Naughty Angel"))
            {
                chosen = new Story
                {
                    Name = "If a Naughty Angel",
                    Icon = "I5_IANA_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 2, 32),
                    WordCount = 399,
                    Description = "Imagine what you’d say if a little angel asked your advice on how to be a tiny bit mischievous.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I5_IANA_1.jpg" },
                   { new TimeSpan(0, 0, 3), "I5_IANA_2.jpg" },
                   { new TimeSpan(0, 0, 45), "I5_IANA_3.jpg" },
                   { new TimeSpan(0, 1, 4), "I5_IANA_4.jpg" },
                   { new TimeSpan(0, 1, 37), "I5_IANA_5.jpg" },
                   { new TimeSpan(0, 2, 12), "I5_IANA_6.jpg" }
                },
                    AudioClip = "I5_IANA_IG.mp3"
                };
            }
            else if (storyName.Equals("If You Decide to be a Kitten"))
            {
                chosen = new Story
                {
                    Name = "If You Decide to be a Kitten",
                    Icon = "I6_DTBAK_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 2, 40),
                    WordCount = 326,
                    Description = "Imagine what it might be like to be a kitten.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I6_DTBAK_1.jpg" },
                   { new TimeSpan(0, 0, 2), "I6_DTBAK_2.jpg" },
                   { new TimeSpan(0, 0, 20), "I6_DTBAK_3.jpg" },
                   { new TimeSpan(0, 0, 39), "I6_DTBAK_4.jpg" },
                   { new TimeSpan(0, 0, 49), "I6_DTBAK_5.jpg" },
                   { new TimeSpan(0, 1, 1), "I6_DTBAK_6.jpg" },
                   { new TimeSpan(0, 1, 18), "I6_DTBAK_7.jpg" },
                   { new TimeSpan(0, 1, 37), "I6_DTBAK_8.jpg" },
                   { new TimeSpan(0, 1, 52), "I6_DTBAK_9.jpg" },
                   { new TimeSpan(0, 2, 0), "I6_DTBAK_10.jpg" },
                   { new TimeSpan(0, 2, 20), "I6_DTBAK_11.jpg" }
                },
                    AudioClip = "I6_DTBK_IG.mp3"
                };
            }
            else if (storyName.Equals("Nobody's Better than You"))
            {
                chosen = new Story
                {
                    Name = "Nobody's Better than You",
                    Icon = "I7_NBTY_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 2, 40),
                    WordCount = 352,
                    Description = "Always remember, nobody’s better than you.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                 { new TimeSpan(0, 0, 0), "I7_NBTY_1.jpg" },
                   { new TimeSpan(0, 0, 3), "I7_NBTY_2.jpg" },
                   { new TimeSpan(0, 0, 12), "I7_NBTY_3.jpg" },
                   { new TimeSpan(0, 0, 18), "I7_NBTY_4.jpg" },
                   { new TimeSpan(0, 0, 31), "I7_NBTY_5.jpg" },
                   { new TimeSpan(0, 0, 37), "I7_NBTY_6.jpg" },
                   { new TimeSpan(0, 0, 46), "I7_NBTY_7.jpg" },
                   { new TimeSpan(0, 0, 50), "I7_NBTY_8.jpg" },
                   { new TimeSpan(0, 0, 57), "I7_NBTY_9.jpg" },
                   { new TimeSpan(0, 1, 18), "I7_NBTY_10.jpg" },
                   { new TimeSpan(0, 1, 28), "I7_NBTY_11.jpg" },
                   { new TimeSpan(0, 1, 46), "I7_NBTY_12.jpg" },
                   { new TimeSpan(0, 1, 56), "I7_NBTY_13.jpg" },
                   { new TimeSpan(0, 2, 20), "I7_NBTY_14.jpg" }
                },
                    AudioClip = "I7_NBTY_IG.mp3"
                };
            }
            else if (storyName.Equals("If a Piece of Dirt..."))
            {
                chosen = new Story
                {
                    Name = "If a Piece of Dirt...",
                    Icon = "I8_IAPOD_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 2, 45),
                    WordCount = 350,
                    Description = "Imagine some of the things you might help a sad, lonely, bored piece of dirt become.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I8_IAPOD_1.jpg" },
                   { new TimeSpan(0, 0, 5), "I8_IAPOD_2.jpg" },
                   { new TimeSpan(0, 0, 25), "I8_IAPOD_3.jpg" },
                   { new TimeSpan(0, 0, 50), "I8_IAPOD_4.jpg" },
                   { new TimeSpan(0, 1, 5), "I8_IAPOD_5.jpg" },
                   { new TimeSpan(0, 1, 35), "I8_IAPOD_6.jpg" },
                   { new TimeSpan(0, 2, 16), "I8_IAPOD_7.jpg" }
                },
                    AudioClip = "I8_IAPOD_IG.mp3"
                };
            }
            else if (storyName.Equals("The Imaginary Fairy Palace"))
            {
                chosen = new Story
                {
                    Name = "The Imaginary Fairy Palace",
                    Icon = "I9_IFP_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 3, 44),
                    WordCount = 396,
                    Description = "Imagine the kind of home fairies might create for themselves if they wanted.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I9_IFP_1.jpg" },
                   { new TimeSpan(0, 0, 6), "I9_IFP_2.jpg" },
                   { new TimeSpan(0, 0, 47), "I9_IFP_3.jpg" },
                   { new TimeSpan(0, 1, 32), "I9_IFP_4.jpg" },
                   { new TimeSpan(0, 1, 53), "I9_IFP_5.jpg" },
                   { new TimeSpan(0, 2, 30), "I9_IFP_6.jpg" },
                   { new TimeSpan(0, 3, 9), "I9_IFP_1.jpg" },
                   { new TimeSpan(0, 3, 32), "I9_IFP_1.jpg" } //TODO: check images for imagine 9
                },
                    AudioClip = "I9_IFP_IG.mp3"
                };
            }
            else if (storyName.Equals("Do You Like Bubbles"))
            {
                chosen = new Story
                {
                    Name = "Do You Like Bubbles",
                    Icon = "I10_DYLB_1.jpg",
                    Appeal = AppealType.General,
                    QuizNum = 0,
                    ThinkDoNum = 1,
                    Duration = new TimeSpan(0, 2, 30),
                    WordCount = 344,
                    Description = "Imagine blowing bubbles in a sink or bathtub.",
                    ListOfIcons = CreateStoryActivitiesStack(0, 0, null),
                    PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I10_DYLB_1.jpg" },
                   { new TimeSpan(0, 0, 2), "I10_DYLB_2.jpg" },
                   { new TimeSpan(0, 0, 12), "I10_DYLB_3.jpg" },
                   { new TimeSpan(0, 0, 39), "I10_DYLB_4.jpg" },
                   { new TimeSpan(0, 1, 5), "I10_DYLB_5.jpg" },
                   { new TimeSpan(0, 1, 42), "I10_DYLB_6.jpg" },
                   { new TimeSpan(0, 2, 1), "I10_DYLB_7.jpg" },
                   { new TimeSpan(0, 2, 10), "I10_DYLB_8.jpg" },
                   { new TimeSpan(0, 2, 20), "I10_DYLB_9.jpg" }  //TODO: not enough images
                },
                    AudioClip = "I1_IAS_IG.mp3" //TODO: NEED TO CHANGE TO IMAGINES 10 AUDIO
                };
            }
            return chosen;
        }
    }
    //END OF IMAGINES
}
