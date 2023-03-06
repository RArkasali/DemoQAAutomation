# How to import project in Visual Studio?

  -- Open Visual Studio.
  -- Go to File->Open->Project and Solutions
  -- Go to the folder where project is placed 
  -- Select the DemoQAAutomation.csproj file and click on Open button
  -- It will open import the project in Visual Study.

# Important ponts about the framework.
```
  -- Framework has total 5 folders.
  -- Data folder consists of two folder in which one folder is used to download the files from application and second is used to upload the files.
  -- Feature folder consist of all the Specflow/feature file which we want to run.
  -- Page folder consist of all the page wise code like find elements for particular page and calling methonds for particular page
  -- Step Definitions folder consists of implementation of all the feature file steps on page the level.
  -- Utils folder consists of constatnts file, hooks file which run before and after each scenario and seleniumwarpper file which have entire library of selenium methods.
  ```

# Flow of the Execution.
```
  -- Run start from tag which we have selected to Run. Control goes to Feature File. From feature it goes to hooks file. In hooke it run Before Scenario annotation and initiate the browser.
  -- Then flow goes to first feature step -- step definition -- page - seleniumwrapper - UI and perform the opeartion on Application.
```
  
# How to run the project.
```
  
  --We can run project using Specflow tags.Below is the command to run the project

  -- All test cases 

   test DemoQAAutomation.csproj --filter "Category=regression" -- TestRunParameters.Parameter(name=\"URL\", value=\"https://demoqa.com/\")

   -- Single test case -- Go to Specflow which you want to run. Get the tag and add that tag in Category. It will run that particular type test cases only.

    test DemoQAAutomation.csproj --filter "Category=textbox" -- TestRunParameters.Parameter(name=\"URL\", value=\"https://demoqa.com/\")
 ```

