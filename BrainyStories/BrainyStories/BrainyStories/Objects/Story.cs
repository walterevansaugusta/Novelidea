using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using BrainyStories.Objects;
using Newtonsoft.Json;

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

        public static implicit operator AppealType(string input)
        {
            input = input.ToLower();
            switch(input)
            {
                case "male":
                    return Male;
                case "female":
                    return Female;
                case "animal":
                    return Animal;
                case "general":
                default:
                    return General;
            }
        }
    }

    public class AppealConverter : JsonConverter<AppealType>
    {
        public override AppealType ReadJson(JsonReader reader, Type objectType, AppealType existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return (string)reader.Value;
        }

        public override void WriteJson(JsonWriter writer, AppealType value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

    public class Story {
        // Name of story/imagine
        [JsonProperty("name")]
        public string Name { get; set; }

        // Image clip for icon
        [JsonProperty("icon")]
        public ImageSource Icon { get; set; }

        [JsonProperty("timespan")]
        public TimeSpan Duration { get; set; }

        [JsonProperty("wordCount")]
        public int WordCount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        // Appeal type for colored dots
        [JsonConverter(typeof(AppealConverter))]
        public AppealType Appeal { get; set; }

        // Number of quizzes for story/imagine
        [JsonProperty("quizNum")]
        public int QuizNum { get; set; }

        // Number of think and do exercises
        [JsonProperty("thinkDoNum")]
        public int ThinkDoNum { get; set; }

        // Dictionary of cues for quizzes to quizzes
        [JsonProperty("quizzes")]
        public Dictionary<TimeSpan, Quiz> QuizCues { get; set; }

        // Dictionary of cues for picture transition to pictures
        [JsonProperty("pictureCues")]
        public Dictionary<TimeSpan, ImageSource> PictureCues { get; set; }

        [JsonProperty("thinkAndDos")]
        public ThinkAndDo[] ThinkAndDos { get; set; }

        //String for audio file
        [JsonProperty("audioClip")]
        public String AudioClip { get; set; }
    }
}
