using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyStories
{
    

    public class StoryFactory
    {
        // MANUAL LIST OF STORIES
        public List<Story> generateStories()
        {
            List<Story> storyListTemp = new List<Story>();

            //STORY 1
            storyListTemp.Add(new Story {
                Name = "The Lion and the Mouse",
                Icon = "S1_LATM_1.png",
                Appeal = AppealType.Animal,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 51),
                WordCount = 395,
                Description = "A lion releases a mouse, believing it’s too small and weak ever to return the favor, " +
                    "but when the lion is trapped in a net the mouse gnaws the threads and releases the lion.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S1_LATM_1.png" },
                   { new TimeSpan(0, 0, 5), "S1_LATM_2.png" },
                   { new TimeSpan(0, 0, 32), "S1_LATM_3.png" },
                   { new TimeSpan(0, 0, 49), "S1_LATM_4.png" },
                   { new TimeSpan(0, 1, 02), "S1_LATM_5.png" },
                   { new TimeSpan(0, 1, 35), "S1_LATM_6.png" },
                   { new TimeSpan(0, 1, 56), "S1_LATM_7.png" },
                   { new TimeSpan(0, 2, 30), "S1_LATM_8.png" }
                },
                AudioClip = "S1_TLATM_Story.mp3"
            });

            //STORY 2
            storyListTemp.Add(new Story {
                Name = "The Little Red Hen",
                Icon = "S2_LRH_1.png",
                Appeal = AppealType.Animal,
                QuizNum = 4,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 3, 14),
                WordCount = 477,
                Description = "Lazy animals refuse to help the hen plant the seed, harvest the grain, or bake the " +
                    "bread, so the hen refuses to share the baked bread with the lazy animals.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S2_LRH_1.png" },
                   { new TimeSpan(0, 0, 5), "S2_LRH_2.png" },
                   { new TimeSpan(0, 0, 32), "S2_LRH_3.png" },
                   { new TimeSpan(0, 0, 49), "S2_LRH_4.png" },
                   { new TimeSpan(0, 1, 02), "S2_LRH_5.png" },
                   { new TimeSpan(0, 1, 35), "S2_LRH_6.png" },
                   { new TimeSpan(0, 1, 56), "S2_LRH_7.png" }
                },
                AudioClip = "S2_LRH_Story.mp3"
            });

            //STORY 3
            storyListTemp.Add(new Story { 
                Name = "The Boy Who Cried Wolf",
                Icon = "S3_TBWCW_1.png",
                Appeal = AppealType.Male,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 4, 37),
                WordCount = 722,
                Description = "Bored watching over the sheep, a boy causes excitement by lying that a wolf " +
                    "threatens; when a real wolf attacks, the people think the boy’s lying and won’t come to help him.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S3_TBWCW_1.png" },
                   { new TimeSpan(0, 0, 2), "S3_TBWCW_2.png" },
                   { new TimeSpan(0, 0, 34), "S3_TBWCW_3.png" },
                   { new TimeSpan(0, 1, 17), "S3_TBWCW_4.png" },
                   { new TimeSpan(0, 1, 45), "S3_TBWCW_5.png" },
                   { new TimeSpan(0, 2, 21), "S3_TBWCW_6.png" },
                   { new TimeSpan(0, 2, 59), "S3_TBWCW_7.png" },
                   { new TimeSpan(0, 3, 29), "S3_TBWCW_8.png" },
                   { new TimeSpan(0, 3, 43), "S3_TBWCW_9.png" }
                },
                AudioClip = "S3_BWCW_Story.mp3"
            });

            //STORY 4
            storyListTemp.Add(new Story {
                Name = "The Elves and Shoemaker",
                Icon = "S4_TEATS_1.png",
                Appeal = AppealType.General,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 06),
                WordCount = 830,
                Description = "By secretly making shoes, two elves save a poor shoemaker and his wife; " +
                    "the man and wife make clothes to reward the elves, who leave when their help is no longer needed.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S4_TEATS_1.png" }, //TODO: TRANSITIONS ARE WRONG FOR STORY 4
                   { new TimeSpan(0, 0, 4), "S4_TEATS_2.png" },
                   { new TimeSpan(0, 1, 06), "S4_TEATS_3.png" },
                   { new TimeSpan(0, 1, 40), "S4_TEATS_4.png" },
                   { new TimeSpan(0, 2, 11), "S4_TEATS_5.png" },
                   { new TimeSpan(0, 2, 32), "S4_TEATS_6.png" },
                   { new TimeSpan(0, 3, 33), "S4_TEATS_7.png" },
                   { new TimeSpan(0, 4, 57), "S4_TEATS_8.png" }, 
                   { new TimeSpan(0, 5, 30), "S4_TEATS_9.png" }
                },
                AudioClip = "S4_TEATS_Story.mp3"
            });

            //STORY 5
            storyListTemp.Add(new Story { 
                Name = "The Three Little Pigs",
                Icon = "S5_TLP_1.png",
                Appeal = AppealType.Animal,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 34),
                WordCount = 986,
                Description = "Two pigs squander their money and build shabby houses; their smarter brother " +
                    "saves and works hard to build a brick house which protects them all from the big bad wolf.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S5_TLP_1.png" }, //TODO: TRANSITIONS ARE WRONG FOR STORY 5
                   { new TimeSpan(0, 0, 27), "S5_TLP_2.png" },
                   { new TimeSpan(0, 1, 05), "S5_TLP_3.png" },
                   { new TimeSpan(0, 2, 19), "S5_TLP_4.png" },
                   { new TimeSpan(0, 2, 41), "S5_TLP_5.png" },
                   { new TimeSpan(0, 3, 12), "S5_TLP_6.png" },
                   { new TimeSpan(0, 3, 57), "S5_TLP_7.png" },
                   { new TimeSpan(0, 4, 20), "S5_TLP_8.png" },
                   { new TimeSpan(0, 4, 49), "S5_TLP_9.png" },
                   { new TimeSpan(0, 5, 58), "S5_TLP_10.png" },
                   { new TimeSpan(0, 6, 11), "S5_TLP_11.png" },
                   { new TimeSpan(0, 6, 30), "S5_TLP_12.png" },
                   { new TimeSpan(0, 6, 31), "S5_TLP_13.png" }  
                },
                AudioClip = "S5_TLP_Story.mp3"
            });

            //STORY 6
            storyListTemp.Add(new Story {
                Name = "The Three Billy Goats Gruff",
                Icon = "S6_BGG_1.png",
                Appeal = AppealType.Animal,
                QuizNum = 3, //TODO: DON'T KNOW HOW MANY QUIZZES
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 38),
                WordCount = 891,
                Description = "Two billy goats trick a mean troll into waiting for their brother; " +
                    "with his horns the big brother knocks the troll off the bridge.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S6_BGG_1.png" }, //TODO: TRANSITIONS ARE WRONG FOR STORY 6
                   { new TimeSpan(0, 0, 30), "S6_BGG_2.png" },
                   { new TimeSpan(0, 0, 40), "S6_BGG_3.png" },
                   { new TimeSpan(0, 0, 50), "S6_BGG_4.png" },
                   { new TimeSpan(0, 1, 00), "S6_BGG_5.png" },
                   { new TimeSpan(0, 1, 30), "S6_BGG_6.png" },
                   { new TimeSpan(0, 1, 40), "S6_BGG_7.png" },
                   { new TimeSpan(0, 1, 50), "S6_BGG_8.png" },
                   { new TimeSpan(0, 2, 00), "S6_BGG_9.png" },
                   { new TimeSpan(0, 2, 30), "S6_BGG_10.png" },
                   { new TimeSpan(0, 2, 40), "S6_BGG_11.png" },
                   { new TimeSpan(0, 2, 50), "S6_BGG_12.png" },
                   { new TimeSpan(0, 3, 00), "S6_BGG_13.png" },
                   { new TimeSpan(0, 3, 30), "S6_BGG_14.png" }
                },
                AudioClip = "S6_BGG_Story.mp3"
            });

            //STORY 7
            storyListTemp.Add(new Story {
                Name = "The Tale of Peter Rabbit",
                Icon = "S7_PR_1.png",
                Appeal = AppealType.Animal,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 7, 29),
                WordCount = 933,
                Description = "Peter disobeys his mother and enters Mr. MacGregor’s garden, where he is almost " +
                    "captured and put into a pie; Peter escapes and returns to his mother who scolds him.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S7_PR_1.png" },
                   { new TimeSpan(0, 0, 19), "S7_PR_2.png" },
                   { new TimeSpan(0, 0, 42), "S7_PR_3.png" },
                   { new TimeSpan(0, 0, 53), "S7_PR_4.png" },
                   { new TimeSpan(0, 1, 01), "S7_PR_5.png" },
                   { new TimeSpan(0, 1, 09), "S7_PR_6.png" },
                   { new TimeSpan(0, 1, 20), "S7_PR_7.png" },
                   { new TimeSpan(0, 1, 27), "S7_PR_8.png" },
                   { new TimeSpan(0, 1, 34), "S7_PR_9.png" },
                   { new TimeSpan(0, 1, 45), "S7_PR_10.png" },
                   { new TimeSpan(0, 1, 58), "S7_PR_11.png" },
                   { new TimeSpan(0, 2, 18), "S7_PR_12.png" },
                   { new TimeSpan(0, 2, 32), "S7_PR_13.png" },
                   { new TimeSpan(0, 2, 40), "S7_PR_14.png" },
                   { new TimeSpan(0, 2, 52), "S7_PR_15.png" },
                   { new TimeSpan(0, 3, 05), "S7_PR_16.png" },
                   { new TimeSpan(0, 3, 17), "S7_PR_17.png" },
                   { new TimeSpan(0, 3, 32), "S7_PR_18.png" },
                   { new TimeSpan(0, 4, 10), "S7_PR_19.png" },
                   { new TimeSpan(0, 4, 42), "S7_PR_20.png" },
                   { new TimeSpan(0, 5, 12), "S7_PR_21.png" },
                   { new TimeSpan(0, 5, 35), "S7_PR_22.png" },
                   { new TimeSpan(0, 5, 41), "S7_PR_23.png" },
                   { new TimeSpan(0, 6, 09), "S7_PR_24.png" },
                   { new TimeSpan(0, 6, 25), "S7_PR_25.png" }
                },
                AudioClip = "S7_PR_Story.mp3"
            });

            //STORY 8
            storyListTemp.Add(new Story {
                Name = "The Gingerbread Man",
                Icon = "S8_TGM_1.png",
                Appeal = AppealType.General,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 7, 39),
                WordCount = 1095,
                Description = "The Gingerbread Man speaks rudely, brags, and outruns all the people " +
                    "and animals until the fox’s help, is tricked and swallowed.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S8_TGM_1.png" },
                   { new TimeSpan(0, 0, 03), "S8_TGM_2.png" },
                   { new TimeSpan(0, 1, 07), "S8_TGM_3.png" },
                   { new TimeSpan(0, 1, 47), "S8_TGM_4.png" },
                   { new TimeSpan(0, 2, 26), "S8_TGM_5.png" },
                   { new TimeSpan(0, 3, 27), "S8_TGM_6.png" },
                   { new TimeSpan(0, 4, 15), "S8_TGM_7.png" },
                   { new TimeSpan(0, 4, 55), "S8_TGM_8.png" },
                   { new TimeSpan(0, 5, 30), "S8_TGM_9.png" },
                   { new TimeSpan(0, 6, 25), "S8_TGM_10.png" },
                   { new TimeSpan(0, 7, 23), "S8_TGM_11.png" }
                },
                AudioClip = "S8_TGM_Story.mp3"
            });

            //STORY 9
            storyListTemp.Add(new Story {
                Name = "Rumplestiltskin",
                Icon = "S9_R_1.png",
                Appeal = AppealType.Female,
                QuizNum = 6,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 8, 18),
                WordCount = 1344,
                Description = "A cruel man spins straw into gold to save a girl’s life, demanding her " +
                    "first child in payment; when she’s queen she saves her child by learning the man’s secret name.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S9_R_1.png" },
                   { new TimeSpan(0, 0, 05), "S9_R_2.png" },
                   { new TimeSpan(0, 0, 32), "S9_R_3.png" },
                   { new TimeSpan(0, 1, 12), "S9_R_4.png" },
                   { new TimeSpan(0, 1, 42), "S9_R_5.png" },
                   { new TimeSpan(0, 2, 29), "S9_R_6.png" },
                   { new TimeSpan(0, 2, 52), "S9_R_7.png" },
                   { new TimeSpan(0, 3, 20), "S9_R_8.png" },
                   { new TimeSpan(0, 3, 52), "S9_R_9.png" },
                   { new TimeSpan(0, 4, 23), "S9_R_10.png" },
                   { new TimeSpan(0, 4, 52), "S9_R_11.png" },
                   { new TimeSpan(0, 5, 25), "S9_R_12.png" },
                   { new TimeSpan(0, 5, 42), "S9_R_13.png" },
                   { new TimeSpan(0, 5, 59), "S9_R_14.png" },
                   { new TimeSpan(0, 6, 22), "S9_R_15.png" },
                   { new TimeSpan(0, 6, 42), "S9_R_16.png" },
                   { new TimeSpan(0, 7, 08), "S9_R_17.png" },
                   { new TimeSpan(0, 7, 34), "S9_R_18.png" },
                   { new TimeSpan(0, 8, 06), "S9_R_19.png" }
                },
                AudioClip = "S9_R_Story.mp3"
            });

            //STORY 10
            storyListTemp.Add(new Story {
                Name = "Little Red Riding Hood",
                Icon = "S10_LRRH_1.png",
                Appeal = AppealType.Female,
                QuizNum = 6,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 8, 47),
                WordCount = 1243,
                Description = "A girl speaks to a wolf and leaves the proper path; the wolf swallows the grandmother" +
                              " and girl, but a huntsman kills the wolf, opens the wolf’s belly, and rescues both of them.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "S10_LRRH_1.png" },
                   { new TimeSpan(0, 0, 05), "S10_LRRH_2.png" },
                   { new TimeSpan(0, 0, 32), "S10_LRRH_3.png" },
                   { new TimeSpan(0, 1, 07), "S10_LRRH_4.png" },
                   { new TimeSpan(0, 1, 13), "S10_LRRH_5.png" },
                   { new TimeSpan(0, 1, 57), "S10_LRRH_6.png" },
                   { new TimeSpan(0, 3, 00), "S10_LRRH_7.png" },
                   { new TimeSpan(0, 3, 42), "S10_LRRH_8.png" },
                   { new TimeSpan(0, 4, 13), "S10_LRRH_9.png" },
                   { new TimeSpan(0, 4, 38), "S10_LRRH_10.png" },
                   { new TimeSpan(0, 5, 30), "S10_LRRH_11.png" },
                   { new TimeSpan(0, 6, 13), "S10_LRRH_12.png" },
                   { new TimeSpan(0, 6, 50), "S10_LRRH_13.png" },
                   { new TimeSpan(0, 7, 32), "S10_LRRH_14.png" },
                   { new TimeSpan(0, 7, 55), "S10_LRRH_15.png" },
                   { new TimeSpan(0, 8, 34), "S10_LRRH_16.png" }
                },
                AudioClip = "S9_R_Story.mp3" //TODO: NEED TO GET STORY 10 (LRRH) AUDIO
            });

            return storyListTemp;
        }
        //END OF STORIES
        

        //MANUAL LIST OF IMAGINES 
        public List<Story> generateImagines()
        {
            List<Story> imaginesListTemp = new List<Story>();

            //IMAGINE 1
            imaginesListTemp.Add(new Story
            {
                Name = "If A Shoe Wanted to be Car",
                Icon = "I1_IASW_1.png",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 1, 47),
                WordCount = 212,
                Description = "Imagine a shoe wanting to be like a car, and what a child might find in the home to help.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I1_IASW_1.png" },
                   { new TimeSpan(0, 0, 8), "I1_IASW_2.png" },
                   { new TimeSpan(0, 0, 43), "I1_IASW_3.png" },
                   { new TimeSpan(0, 1, 7), "I1_IASW_4.png" },
                   { new TimeSpan(0, 1, 26), "I1_IASW_5.png" }
                },
                AudioClip = "I1_IAS_IG.mp3"
            });

            //IMAGINE 2
            imaginesListTemp.Add(new Story
            {
                Name = "Do you pump your legs when you swing?",
                Icon = "I2_DYPYL_1.png",
                Appeal = AppealType.Male,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 1, 48),
                WordCount = 206,
                Description = "Imagine swinging as high as trees, birds, clouds, or even higher, what it might feel like, what you might see.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I2_DYPYL_1.png" },
                   { new TimeSpan(0, 0, 4), "I2_DYPYL_2.png" },
                   { new TimeSpan(0, 0, 31), "I2_DYPYL_3.png" },
                   { new TimeSpan(0, 0, 55), "I2_DYPYL_4.png" },
                   { new TimeSpan(0, 1, 6), "I2_DYPYL_5.png" },
                   { new TimeSpan(0, 1, 11), "I2_DYPYL_6.png" },
                   { new TimeSpan(0, 1, 38), "I2_DYPYL_7.png" },
                },
                AudioClip = "I2_DYPYL_IG.mp3"
            });

            //IMAGINE 3
            imaginesListTemp.Add(new Story
            {
                Name = "Upside Down Windows",
                Icon = "I3_TUDW_1.png",
                Appeal = AppealType.Female,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 1, 59),
                WordCount = 248,
                Description = "Imagine wandering into a world where everything is upside down and backwards.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I3_TUDW_1.png" },
                   { new TimeSpan(0, 0, 5), "I3_TUDW_2.png" },
                   { new TimeSpan(0, 0, 34), "I3_TUDW_3.png" },
                   { new TimeSpan(0, 0, 59), "I3_TUDW_4.png" },
                   { new TimeSpan(0, 1, 26), "I3_TUDW_5.png" },
                   { new TimeSpan(0, 1, 48), "I3_TUDW_6.png" }
                },
                AudioClip = "I3_UW_IG.mp3"
            });

            //IMAGINE 4
            imaginesListTemp.Add(new Story
            {
                Name = "The Special One-Eye Blink",
                Icon = "I4_TSOEB_1.png",
                Appeal = AppealType.Female,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 06),
                WordCount = 304,
                Description = "Imagine blinking to become very tiny and what you might be able to do if you were very, very small.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I4_TSOEB_1.png" },
                   { new TimeSpan(0, 0, 4), "I4_TSOEB_2.png" },
                   { new TimeSpan(0, 0, 35), "I4_TSOEB_3.png" },
                   { new TimeSpan(0, 0, 55), "I4_TSOEB_4.png" },
                   { new TimeSpan(0, 1, 19), "I4_TSOEB_5.png" },
                   { new TimeSpan(0, 1, 44), "I4_TSOEB_6.png" },
                   { new TimeSpan(0, 2, 1), "I4_TSOEB_7.png" },
                },
                AudioClip = "I4_SOEB_IG.mp3"
            });

            //IMAGINE 5
            imaginesListTemp.Add(new Story
            {
                Name = "If a Naughty Angel",
                Icon = "I5_IANA_1.png",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 32),
                WordCount = 399,
                Description = "Imagine what you’d say if a little angel asked your advice on how to be a tiny bit mischievous.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I5_IANA_1.png" },
                   { new TimeSpan(0, 0, 3), "I5_IANA_2.png" },
                   { new TimeSpan(0, 0, 45), "I5_IANA_3.png" },
                   { new TimeSpan(0, 1, 4), "I5_IANA_4.png" },
                   { new TimeSpan(0, 1, 37), "I5_IANA_5.png" },
                   { new TimeSpan(0, 2, 12), "I5_IANA_6.png" }
                },
                AudioClip = "I5_IANA_IG.mp3"
            });

            //IMAGINE 6
            imaginesListTemp.Add(new Story
            {
                Name = "If You Decide to be a Kitten",
                Icon = "I6_DTBAK_1.png",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 40),
                WordCount = 326,
                Description = "Imagine what it might be like to be a kitten.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I6_DTBAK_1.png" },
                   { new TimeSpan(0, 0, 2), "I6_DTBAK_2.png" },
                   { new TimeSpan(0, 0, 20), "I6_DTBAK_3.png" },
                   { new TimeSpan(0, 0, 39), "I6_DTBAK_4.png" },
                   { new TimeSpan(0, 0, 49), "I6_DTBAK_5.png" },
                   { new TimeSpan(0, 1, 1), "I6_DTBAK_6.png" },
                   { new TimeSpan(0, 1, 18), "I6_DTBAK_7.png" },
                   { new TimeSpan(0, 1, 37), "I6_DTBAK_8.png" },
                   { new TimeSpan(0, 1, 52), "I6_DTBAK_9.png" },
                   { new TimeSpan(0, 2, 0), "I6_DTBAK_10.png" },
                   { new TimeSpan(0, 2, 20), "I6_DTBAK_11.png" }
                },
                AudioClip = "I6_DTBK_IG.mp3"
            });

            //IMAGINE 7
            imaginesListTemp.Add(new Story
            {
                Name = "Nobody's Better than You",
                Icon = "I7_NBTY_1.png",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 40),
                WordCount = 352,
                Description = "Always remember, nobody’s better than you.",
                PictureCues = new Dictionary<TimeSpan, string> {
                 { new TimeSpan(0, 0, 0), "I7_NBTY_1.png" },
                   { new TimeSpan(0, 0, 3), "I7_NBTY_2.png" },
                   { new TimeSpan(0, 0, 12), "I7_NBTY_3.png" },
                   { new TimeSpan(0, 0, 18), "I7_NBTY_4.png" },
                   { new TimeSpan(0, 0, 31), "I7_NBTY_5.png" },
                   { new TimeSpan(0, 0, 37), "I7_NBTY_6.png" },
                   { new TimeSpan(0, 0, 46), "I7_NBTY_7.png" },
                   { new TimeSpan(0, 0, 50), "I7_NBTY_8.png" },
                   { new TimeSpan(0, 0, 57), "I7_NBTY_9.png" },
                   { new TimeSpan(0, 1, 18), "I7_NBTY_10.png" },
                   { new TimeSpan(0, 1, 28), "I7_NBTY_11.png" },
                   { new TimeSpan(0, 1, 46), "I7_NBTY_12.png" },
                   { new TimeSpan(0, 1, 56), "I7_NBTY_13.png" },
                   { new TimeSpan(0, 2, 20), "I7_NBTY_14.png" }
                },
                AudioClip = "I7_NBTY_IG.mp3"
            });

            //IMAGINE 8
            imaginesListTemp.Add(new Story
            {
                Name = "If a Piece of Dirt...",
                Icon = "I8_IAPOD_1.png",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 45),
                WordCount = 350,
                Description = "Imagine some of the things you might help a sad, lonely, bored piece of dirt become.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I8_IAPOD_1.png" },
                   { new TimeSpan(0, 0, 5), "I8_IAPOD_2.png" },
                   { new TimeSpan(0, 0, 25), "I8_IAPOD_3.png" },
                   { new TimeSpan(0, 0, 50), "I8_IAPOD_4.png" },
                   { new TimeSpan(0, 1, 5), "I8_IAPOD_5.png" },
                   { new TimeSpan(0, 1, 35), "I8_IAPOD_6.png" },
                   { new TimeSpan(0, 2, 16), "I8_IAPOD_7.png" }
                },
                AudioClip = "I8_IAPOD_IG.mp3"
            });

            //IMAGINE 9
            imaginesListTemp.Add(new Story
            {
                Name = "The Imaginary Fairy Palace",
                Icon = "I9_IFP_1.png",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 3, 44),
                WordCount = 396,
                Description = "Imagine the kind of home fairies might create for themselves if they wanted.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I9_IFP_1.png" },
                   { new TimeSpan(0, 0, 6), "I9_IFP_2.png" },
                   { new TimeSpan(0, 0, 47), "I9_IFP_3.png" },
                   { new TimeSpan(0, 1, 32), "I9_IFP_4.png" },
                   { new TimeSpan(0, 1, 53), "I9_IFP_5.png" },
                   { new TimeSpan(0, 2, 30), "I9_IFP_6.png" },
                   { new TimeSpan(0, 3, 9), "I9_IFP_1.png" },
                   { new TimeSpan(0, 3, 32), "I9_IFP_1.png" } //TODO: check images for imagine 9
                },
                AudioClip = "I9_IFP_IG.mp3"
            });

            //IMAGINE 10
            imaginesListTemp.Add(new Story
            {
                Name = "Do You Like Bubbles",
                Icon = "I10_DYLB_1.png",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 30),
                WordCount = 344,
                Description = "Imagine blowing bubbles in a sink or bathtub.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I10_DYLB_1.png" },
                   { new TimeSpan(0, 0, 2), "I10_DYLB_2.png" },
                   { new TimeSpan(0, 0, 12), "I10_DYLB_3.png" },
                   { new TimeSpan(0, 0, 39), "I10_DYLB_4.png" },
                   { new TimeSpan(0, 1, 5), "I10_DYLB_5.png" },
                   { new TimeSpan(0, 1, 42), "I10_DYLB_6.png" },
                   { new TimeSpan(0, 2, 1), "I10_DYLB_7.png" },
                   { new TimeSpan(0, 2, 10), "I10_DYLB_8.png" },
                   { new TimeSpan(0, 2, 20), "I10_DYLB_9.png" }  //TODO: not enough images
                },
                AudioClip = "I1_IAS_IG.mp3" //TODO: NEED TO CHANGE TO IMAGINES 10 AUDIO
            });

            return imaginesListTemp;
        }
    }
    //END OF IMAGINES
}
