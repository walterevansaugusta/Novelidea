# NovelIdea
- A children's app where children can read or listen to stories and increase their reading comprehension skills.
- Stories taken from hearatale.org

## Release Notes Brainy Stories 1.0
#### NEW FEATURES
   - Ability to read and listen to children’s stories
   - Ability to take quizzes based on the readings
   - Ability to do short activities for each stories
   - A rewards system for getting quiz questions correct
   - A progress page that tracks different data throughout the app
#### BUG FIXES
   - This is the first release
#### KNOWN BUGS
   - On the iOS build, some of the audio tracks do not play but others do play. This is not an issue for android.
   - The app does not persist between sessions.

## Install Guide Brainy Stories 1.0
#### PREREQUISITES
For hardware, an Android or iOS device is required. For software, Android 5.0 at minimum is required.
#### DEPENDENT LIBRARIES THAT MUSTS BE INSTALLED
None since it is a mobile app.
#### DOWNLOAD INSTRUCTIONS
Download like a normal app from either the Google Play Store, Amazon Store, or Apple App Store.
#### INSTALLATION OF ACTUAL APPLICATION
Nothing is required other than downloading from the appropriate store.
#### RUNNING APPLICATION
Nothing is required other than clicking on the app.
#### TROUBLESHOOTING
There are not any expected errors that should occur while the user is running the app.


# Basic Navigation Flow
- Main Page.xaml
    - TableOfContents.xaml
      - StoryPage.xaml
        - EndOfStory.xaml
          - ThinkAndDoPopup.xaml
          - QuizPage.xaml
    - RewardsPage.xaml
    - ThinkAndDoList.xaml
      -ThinkAndDoPopup.xaml
    - ProgressPage.xaml
      - IndividualProgressPage.xaml
      - ProgressSummaryPage.xaml
      - ProgressOverallPage.xaml
    - QuizList.xaml
      - QuizPage.xaml
- All pages have home button leading to MainPage.xaml, back button leading to previous page, and settings button leading to Settings.xaml
    
