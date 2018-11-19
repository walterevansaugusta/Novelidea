using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BrainyStories
{
    
    class TableOfContentsModel
    {
        private Story _oldStory;

        public ObservableCollection<Story> Stories { get; set; }
        public TableOfContentsModel()
        {
            Stories = new ObservableCollection<Story>
            {
                new Story
                {
                    Name = "The Country Mouse and the City Mouse",
                    CanRead = false
          
                },

                new Story
                {
                    Name = "The Dog and his Shadow",
                    CanRead = false
                },

                new Story
                {
                    Name = "The Emperor's New Clothes",
                    CanRead = false
                }
            };
        }

        internal void HideShowRead(Story story)
        {
            if (_oldStory == story)
            {
                // click twice on the same object to hide the buttons
                story.CanRead =! story.CanRead;
                UpdateStory(story);
            } else
            {
                if (_oldStory != null)
                {
                    // hide previously selected story
                    _oldStory.CanRead = false;
                    UpdateStory(_oldStory);
                }

                //show selected item
                story.CanRead = true;
                UpdateStory(story);
            }
            _oldStory = story;
        }

        private void UpdateStory(Story story)
        {
            var index = Stories.IndexOf(story);
            Stories.Remove(story);
            Stories.Insert(index, story);
        }
    }
}
