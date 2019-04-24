using System;
using System.Collections.Generic;
using System.Text;

namespace BrainyStories.Objects {

    // Class for the ThinkAndDo activities
    public class ThinkAndDo {

        // String of the icon used for ThinkAndDos in the table of contents
        public static String Icon { get; } = "ThinkAndDoIcon.png";

        // String for Name
        public String ThinkAndDoName { get; set; }

        // String for Associated Story
        public String AssociatedImage { get; set; }

        // String for audio file
        public String ThinkAndDoAudioClip { get; set; }

        // Timespan for audio file
        public TimeSpan Length { get; set; }

        // Boolean of if the ThinkAndDo was completed or not
        public bool Completed { get; set; } = false;

        public String Text { get; set; }
    }
}
