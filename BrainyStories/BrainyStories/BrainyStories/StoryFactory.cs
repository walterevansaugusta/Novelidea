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
                Icon = "S1_LATM_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 51),
                WordCount = 395,
                Description = "A lion releases a mouse, believing it’s too small and weak ever to return the favor, " +
                    "but when the lion is trapped in a net the mouse gnaws the threads and releases the lion."
            });

            //STORY 2
            storyListTemp.Add(new Story {
                Name = "The Little Red Hen",
                Icon = "S2_LRH_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 4,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 3, 14),
                WordCount = 477,
                Description = "Lazy animals refuse to help the hen plant the seed, harvest the grain, or bake the " +
                    "bread, so the hen refuses to share the baked bread with the lazy animals."
            });

            //STORY 3
            storyListTemp.Add(new Story { 
                Name = "The Boy Who Cried Wolf",
                Icon = "S3_TBWCW_1.jpg",
                Appeal = AppealType.Male,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 4, 37),
                WordCount = 722,
                Description = "Bored watching over the sheep, a boy causes excitement by lying that a wolf " +
                    "threatens; when a real wolf attacks, the people think the boy’s lying and won’t come to help him."
            });

            //STORY 4
            storyListTemp.Add(new Story {
                Name = "The Elves and Shoemaker",
                Icon = "S4_TEATS_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 3,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 06),
                WordCount = 830,
                Description = "By secretly making shoes, two elves save a poor shoemaker and his wife; " +
                    "the man and wife make clothes to reward the elves, who leave when their help is no longer needed."
            });

            //STORY 5
            storyListTemp.Add(new Story { 
                Name = "The Three Little Pigs",
                Icon = "S5_TLP_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 34),
                WordCount = 986,
                Description = "Two pigs squander their money and build shabby houses; their smarter brother " +
                    "saves and works hard to build a brick house which protects them all from the big bad wolf."
            });

            //STORY 6
            storyListTemp.Add(new Story {
                Name = "The Three Billy Goats Gruff",
                Icon = "S6_BGG_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 3, //TODO: DON'T KNOW HOW MANY QUIZZES
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 6, 38),
                WordCount = 891,
                Description = "Two billy goats trick a mean troll into waiting for their brother; " +
                    "with his horns the big brother knocks the troll off the bridge."
            });

            //STORY 7
            storyListTemp.Add(new Story {
                Name = "The Tale of Peter Rabbit",
                Icon = "S7_PR_1.jpg",
                Appeal = AppealType.Animal,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 7, 29),
                WordCount = 933,
                Description = "Peter disobeys his mother and enters Mr. MacGregor’s garden, where he is almost " +
                    "captured and put into a pie; Peter escapes and returns to his mother who scolds him."
            });

            //STORY 8
            storyListTemp.Add(new Story {
                Name = "The Gingerbread Man",
                Icon = "S8_TGM_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 5,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 7, 39),
                WordCount = 1095,
                Description = "The Gingerbread Man speaks rudely, brags, and outruns all the people " +
                    "and animals until the fox’s help, is tricked and swallowed."
            });

            //STORY 9
            storyListTemp.Add(new Story {
                Name = "Rumplestiltskin",
                Icon = "S9_R_1.jpg",
                Appeal = AppealType.Female,
                QuizNum = 6,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 8, 18),
                WordCount = 1344,
                Description = "A cruel man spins straw into gold to save a girl’s life, demanding her " +
                    "first child in payment; when she’s queen she saves her child by learning the man’s secret name."
            });

            //STORY 10
            storyListTemp.Add(new Story {
                Name = "Little Red Riding Hood",
                Icon = "S10_LRRH_1.jpg",
                Appeal = AppealType.Female,
                QuizNum = 6,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 8, 47),
                WordCount = 1243,
                Description = "A girl speaks to a wolf and leaves the proper path; the wolf swallows the grandmother" +
                              " and girl, but a huntsman kills the wolf, opens the wolf’s belly, and rescues both of them."
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
                Icon = "I1_IASW_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 1, 47),
                WordCount = 212,
                Description = "Imagine a shoe wanting to be like a car, and what a child might find in the home to help.",
                PictureCues = new Dictionary<TimeSpan, string> {
                   { new TimeSpan(0, 0, 0), "I1_IASW_1.jpg" },
                   { new TimeSpan(0, 0, 8), "I1_IASW_2.jpg" },
                   { new TimeSpan(0, 0, 43), "I1_IASW_3.jpg" },
                   { new TimeSpan(0, 1, 7), "I1_IASW_4.jpg" },
                   { new TimeSpan(0, 1, 26), "I1_IASW_5.jpg" }
                },
                AudioClip = "I1_IAS_IG.mp3"
            });

            //IMAGINE 2
            imaginesListTemp.Add(new Story
            {
                Name = "Do you pump your legs when you swing?",
                Icon = "I2_DYPYL_1.jpg",
                Appeal = AppealType.Male,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 1, 48),
                WordCount = 206,
                Description = "Imagine swinging as high as trees, birds, clouds, or even higher, what it might feel like, what you might see."
            });

            //IMAGINE 3
            imaginesListTemp.Add(new Story
            {
                Name = "Upside Down Windows",
                Icon = "I3_TUDW_1.jpg",
                Appeal = AppealType.Female,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 1, 59),
                WordCount = 248,
                Description = "Imagine wandering into a world where everything is upside down and backwards."
            });

            //IMAGINE 4
            imaginesListTemp.Add(new Story
            {
                Name = "The Special One-Eye Blink",
                Icon = "I4_TSOEB_1.jpg",
                Appeal = AppealType.Female,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 06),
                WordCount = 304,
                Description = "Imagine blinking to become very tiny and what you might be able to do if you were very, very small."
            });

            //IMAGINE 5
            imaginesListTemp.Add(new Story
            {
                Name = "If a Naughty Angel",
                Icon = "I5_IANA_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 32),
                WordCount = 399,
                Description = "Imagine what you’d say if a little angel asked your advice on how to be a tiny bit mischievous."
            });

            //IMAGINE 6
            imaginesListTemp.Add(new Story
            {
                Name = "If You Decide to be a Kitten",
                Icon = "I6_DTBAK_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 40),
                WordCount = 326,
                Description = "Imagine what it might be like to be a kitten."
            });

            //IMAGINE 7
            imaginesListTemp.Add(new Story
            {
                Name = "Nobody's Better than You",
                Icon = "I7_NBTY_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 40),
                WordCount = 352,
                Description = "Always remember, nobody’s better than you."
            });

            //IMAGINE 8
            imaginesListTemp.Add(new Story
            {
                Name = "If a Piece of Dirt...",
                Icon = "I8_IAPOD_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 45),
                WordCount = 350,
                Description = "Imagine some of the things you might help a sad, lonely, bored piece of dirt become."
            });

            //IMAGINE 9
            imaginesListTemp.Add(new Story
            {
                Name = "The Imaginary Fairy Palace",
                Icon = "I9_IFP_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 3, 44),
                WordCount = 396,
                Description = "Imagine the kind of home fairies might create for themselves if they wanted."
            });

            //IMAGINE 10
            imaginesListTemp.Add(new Story
            {
                Name = "Do You Like Bubbles",
                Icon = "I10_DYLB_1.jpg",
                Appeal = AppealType.General,
                QuizNum = 0,
                ThinkDoNum = 1,
                Duration = new TimeSpan(0, 2, 30),
                WordCount = 344,
                Description = "Imagine blowing bubbles in a sink or bathtub."
            });

            return imaginesListTemp;
        }
    }
    //END OF IMAGINES
}
