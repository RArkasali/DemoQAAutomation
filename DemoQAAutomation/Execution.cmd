SETLOCAL
SET URL=https://demoqa.com/
dotnet test DemoQAAutomation.csproj --logger:"console;verbosity=detailed"  --filter "Category=regression"