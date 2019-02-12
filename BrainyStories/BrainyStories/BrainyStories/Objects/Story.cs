﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using BrainyStories.Objects;

namespace BrainyStories
{
    public class AppealType
    {
        private AppealType(string value) { Value = value; }

        public string Value { get; set; }

        public static AppealType Male { get { return new AppealType("Male.png"); } }
        public static AppealType Female { get { return new AppealType("Female.png"); } }
        public static AppealType General { get { return new AppealType("General.png"); } }
        public static AppealType Animal { get { return new AppealType("Animal.png"); } }
    }

    public class Story {
        // Name of story/imagine
        public String Name { get; set; }

        // Image clip for icon
        public ImageSource Icon { get; set; }

        public TimeSpan Duration { get; set; }

        public int WordCount { get; set; }

        public String Description { get; set; }

        // Appeal type for colored dots
        public AppealType Appeal { get; set; }

        // Number of quizzes for story/imagine
        public int QuizNum { get; set; }

        // Number of think and do exercises
        public int ThinkDoNum { get; set; }

        // Dictionary of cues for quizzes to quizzes
        public Dictionary<TimeSpan, Quiz> QuizCues { get; set; }

        // Dictionary of cues for picture transition to pictures
        public Dictionary<TimeSpan, StoryPictures> PictureCues { get; set; }

        public ThinkAndDo[] ThinkAndDos { get; set; }

        //String for audio file
        public String AudioClip { get; set; }
    }
}