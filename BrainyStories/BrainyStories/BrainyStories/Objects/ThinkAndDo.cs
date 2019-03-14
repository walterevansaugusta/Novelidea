using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyStories.Objects {
    public class ThinkAndDo {

        public static String Icon { get; } = "ThinkAndDoIcon.png";

        //String for Name
        public String ThinkAndDoName { get; set; }

        //String for Associated Story
        public String AssociatedImage { get; set; }

        //String for audio file
        public String ThinkAndDoAudioClip { get; set; }

        //String for audio file
        public TimeSpan Length { get; set; }

        public bool Completed { get; set; } = false;
    }
}
