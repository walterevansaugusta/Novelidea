# NovelIdea
- A children's app where children can read or listen to stories and increase their reading comprehension skills.
- Stories taken from hearatale.org

Release Notes Brainy Stories 1.0 /n
    NEW FEATURES \n
        Ability to read and listen to children’s stories \n
        Ability to take quizzes based on the readings \n
        Ability to do short activities for each stories \n
        A rewards system for getting quiz questions correct \n
        A progress page that tracks different data throughout the app \n
    BUG FIXES \n
        This is the first release \n
    KNOWN BUGS \n
        On the iOS build, some of the audio tracks do not play but others do play. This is not an issue for android. \n
        The app does not persist between sessions. \n \n

Install Guide Brainy Stories 1.0 \n
    PREREQUISITES \n
        For hardware, an Android or iOS device is required. For software, Android 5.0 at minimum is required. \n
    DEPENDENT LIBRARIES THAT MUSTS BE INSTALLED \n
        None since it is a mobile app. \n
    DOWNLOAD INSTRUCTIONS \n
        Download like a normal app from either the Google Play Store, Amazon Store, or Apple App Store. \n
    INSTALLATION OF ACTUAL APPLICATION \n
        Nothing is required other than downloading from the appropriate store. \n
    RUNNING APPLICATION \n
        Nothing is required other than clicking on the app. \n
    TROUBLESHOOTING \n
        There are not any expected errors that should occur while the user is running the app. \n


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
    
