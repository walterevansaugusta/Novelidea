# NovelIdea
A children's app where children can read or listen to stories and increase their reading comprehension skills \n
Stories taken from hearatale.org
# Critical Files to Review (for JD editors)
- all important files are in Novelidea/BrainyStories/BrainyStories/BrainyStories/ \n
- front end files are the .xaml files \n
- back end files are the .xaml.cs and the .cs files \n
- ignore the BrainyStories.csproj (it is auto generated) \n
- each .xaml.cs is associated with the corresponding .xaml file (they will have the same name)
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
    
