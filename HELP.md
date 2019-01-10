# Azure DevOps
## Testing
[Unit testing C#](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest) in .NET Core.

## Azure Pipelines
Create pipeline using [YAML](https://docs.microsoft.com/en-us/azure/devops/pipelines/languages/dotnet-core?view=vsts&tabs=yaml).

## Web App
Deploy the application to Azure App Service. Azure Web App provides [sandbox](https://github.com/projectkudu/kudu/wiki/Azure-Web-App-sandbox) capabilities.

One can deploy an app to Azure App Service with a [ZIP or WAR](https://docs.microsoft.com/en-us/azure/app-service/deploy-zip) file

## Remote Debugging Azure App Service 
Debug apps deployed on [App Service](https://blogs.msdn.microsoft.com/premier_developer/2018/06/18/remote-debugging-azure-app-services/)

## Debugging Test Projects with Visual Studio Code
Need to run in PowerShell to enable host debugging
```powershell
$env:VSTEST_HOST_DEBUG=1
```
For more information, refer to [Debugging .NET Core Projects with Visual Studio Code](https://medium.com/@mikezrimsek/debugging-dotnet-core-projects-with-visual-studio-code-ff0ab66ecc70).

## UI Tests with Selenium
Refer to [Selenium .NET Class Reference](https://seleniumhq.github.io/selenium/docs/api/dotnet/).