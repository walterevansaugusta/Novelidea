using BrainyStories.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BrainyStories
{
    public class ThinkAndDoFactory
    {
        private ObservableCollection<ThinkAndDo> ThinkAndDoListTemp;

        public ObservableCollection<ThinkAndDo> generateThinkAndDos()
        {
            ThinkAndDoListTemp = new ObservableCollection<ThinkAndDo>();
            ThinkAndDoListTemp.Add(new ThinkAndDo {
                ThinkAndDoName = "The Lion and the Mouse Think And Do 1",
                AssociatedImage = "S1_LATM_1.jpg",
                ThinkAndDoAudioClip = "S1_TLATM_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Lion and the Mouse Think And Do 2",
                AssociatedImage = "S1_LATM_1.jpg",
                ThinkAndDoAudioClip = "S1_TLATM_TAD2.mp3",
                Length = new TimeSpan(0, 2, 51)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Little Red Hen Think And Do 1",
                AssociatedImage = "S2_LRH_0.JPG",
                ThinkAndDoAudioClip = "S2_LRH_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Boy Who Cried Wolf Think And Do 1",
                AssociatedImage = "S3_TBWCW_1.jpg",
                ThinkAndDoAudioClip = "S3_BWCW_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Boy Who Cried Wolf Think And Do 2",
                AssociatedImage = "S3_TBWCW_1.jpg",
                ThinkAndDoAudioClip = "S3_BWCW_TAD2.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Elves and the Shoemaker Think And Do 1",
                AssociatedImage = "S4_TEATS_1.jpg",
                ThinkAndDoAudioClip = "S4_TEATS_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Elves and the Shoemaker Think And Do 2",
                AssociatedImage = "S4_TEATS_1.jpg",
                ThinkAndDoAudioClip = "S4_TEATS_TAD2.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Three Little Pigs Think And Do 1",
                AssociatedImage = "S5_TLP_0.jpg",
                ThinkAndDoAudioClip = "S5_TLP_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Three Little Pigs Think And Do 2",
                AssociatedImage = "S5_TLP_0.jpg",
                ThinkAndDoAudioClip = "S5_TLP_TAD2.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Three Billy Goats Gruff Think And Do 1",
                AssociatedImage = "S6_BGG_1.jpg",
                ThinkAndDoAudioClip = "S6_BGG_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Three Billy Goats Gruff Think And Do 2",
                AssociatedImage = "S6_BGG_1.jpg",
                ThinkAndDoAudioClip = "S6_BGG_TAD2.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Tales of Peter Rabbit Think And Do 1",
                AssociatedImage = "S7_PR_0.jpg",
                ThinkAndDoAudioClip = "S7_PR_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Tales of Peter Rabbit Think And Do 2",
                AssociatedImage = "S7_PR_0.jpg",
                ThinkAndDoAudioClip = "S7_PR_TAD2.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Gingerbread Man Think And Do 1",
                AssociatedImage = "S8_TGM_1.jpg",
                ThinkAndDoAudioClip = "S8_TGM_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "The Gingerbread Man Think And Do 2",
                AssociatedImage = "S8_TGM_1.jpg",
                ThinkAndDoAudioClip = "S8_TGM_TAD2.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "Rumplestiltskin Think And Do 1",
                AssociatedImage = "S9_R_1.jpg",
                ThinkAndDoAudioClip = "S9_R_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "Rumplestiltskin Think And Do 2",
                AssociatedImage = "S9_R_1.jpg",
                ThinkAndDoAudioClip = "S9_R_TAD2.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "Little Red Riding Hood Think And Do 1",
                AssociatedImage = "S10_LRRH_1.jpg",
                ThinkAndDoAudioClip = "S10_LRRH_TAD1.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "Little Red Riding Hood Think And Do 2",
                AssociatedImage = "S10_LRRH_1.jpg",
                ThinkAndDoAudioClip = "S10_LRRH_TAD2.mp3",
                Length = new TimeSpan(0, 2, 2)
            });

            return ThinkAndDoListTemp;
        }

        public ObservableCollection<ThinkAndDo> StoryThinkAndDos(String story)
        {
            ObservableCollection<ThinkAndDo> temp = new ObservableCollection<ThinkAndDo>();
            foreach (ThinkAndDo think in ThinkAndDoListTemp)
            {
                if (think.ThinkAndDoName.ToLower().Contains(story.ToLower()))
                {
                    temp.Add(think);
                }
            }
            return temp;
        }
    }
}
