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
                ThinkAndDoName = "Test",
                AssociatedStory = "The Lion and the Mouse",
                ThinkAndDoAudioClip = "I7_NBTY_IG.mp3",
                Length = new TimeSpan(0, 2, 2)
            });
            ThinkAndDoListTemp.Add(new ThinkAndDo
            {
                ThinkAndDoName = "Test2",
                AssociatedStory = "The Lion and the Mouse",
                ThinkAndDoAudioClip = "I8_IAPOD_IG.mp3",
                Length = new TimeSpan(0, 2, 51)
            });

            return ThinkAndDoListTemp;
        }

        public ObservableCollection<ThinkAndDo> StoryThinkAndDos(String story)
        {
            ObservableCollection<ThinkAndDo> temp = new ObservableCollection<ThinkAndDo>();
            foreach (ThinkAndDo think in ThinkAndDoListTemp)
            {
                if (think.AssociatedStory.Equals(story))
                {
                    temp.Add(think);
                }
            }
            return temp;
        }
    }
}
