# ASP.Net-Core 2.2 Empty Project

1. <b>Solution Explorer View</b> :</br>
    ![Solution Explorer](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/SolutionExplorer.JPG)
    
2. <b> Project File </b> :
    - To edit project file, right click the solution and click "Edit Project File"
    - File is as follows : 
    ![Project File](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/ProjectFile.JPG)
    
    - `TargetFramework` : 
        - Specifies the target framework using Target Framework Moniker(TFM)
        - For .NET core TFM is as netcoreapp2.0, netcoreapp2.2 depending on version
        
    - `AspNetCoreHostingModel` :
        - Specifies how the application should be hosted i.e Inprocess or Outprocess
        - The default is outofprocess hosting 
        
    - `PackageReference` :
        - Used to include reference to the NUGET package that is installed for the application
        - It is containing <i> Metapackages </i> (`Microsoft.AspNetCore.App`), they have no content of their own and contains only dependencies

3. <b> Program.cs </b> :
    - The code is as follow :   
    ![Program.cs](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/Program.JPG)
    - ASP.Net core initially starts as console application with `Main` method, which configres and transition to ASP.NET core web application
    - Extended method `CreateWebHostBuilder` calls `WebHost.CreateDefaultBuilder` which sets up webserver, loads host and application from configuration sources and configures logging
    - `CreateWebHostBuilder(args).Build().Run()` and then the webhost is build to host application and run listening to http request
    - The extended method not only creates webserver but also configures Startup class `WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()`
    
4. <b> StartUp.cs </b> : 
    - The code is as follows :</br>    
    ![StartUp.cs](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/StartUp.JPG)
    - `ConfigureServices` : configures services required for application
    - `Configure` : configures the application request processing pipeline
    
5. <b> launchSettings.json </b> :
    - View is as follows :</br>
    ![launchSettings.json](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/launchSettings.JPG)
    - This file is required while development only
    - It is used when application is run from CLI or IDE
    - It has two profile : 1) `IIS Express` and 2) Same as project name `EmployeeManagement`
    - When the application is run from IDE with default build setting or by clicking `ctrl + F5`, `IIS Express` profile is used with `iisSettings` where port number can be changed
    - In `IIS Express` the `ASPNETCORE_ENVIRONMENT` i.e environment varibale can be change as development, staging or prodction and also new environment variables can be added
    - New environment variables will be available throghout the application and can be used to write conditionally executable code depending on these variables
    - `EmployeeManagement` profile is used when the application is run from .NET core CLI (Command Line Interface)
    - `commandName` property of profile and `AspNetHostingModel` of project file is used to determine the internal and external web server for out of process hosting
    - The value of the commandName property can be any one of the following. 
        - Project
        - IISExpress
        - IIS
    - The dependency is as follows:</br>
    ![WebServers](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/WebServes.JPG)
    
6. <b>appsettings.json </b> :
    - File view :</br>
    ![appsettings.json](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/appsettings.JPG)
    - Settings that are used while publishing the application are stored in this file
    - In asp.net application configuration settings like database connection strings are stored in web.config file but in .net core configuration settings can come from various sources like:
        - Files
        - User secrets
        - Environment variables
        - Command-line arguments
        - Custom configuration source
    - Custom configuration settings can be added as key-value pair and to read it IConfiguration service is used
    - Addition of custom configuration :</br>    
    ![CustomCOnfigAddition](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/CustomConfig_appSetting.JPG)    
    - Usage of IConfiguration in StartUp.cs </br>
    ![IConfigurationUsage](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/IConfigurationUse_StartUp.JPG)
    - In addition to <b>appsettings.json</b> there are environment specific like for development environment there is <b>appsettings.Development.json</b> and duplicate settings in these files will override those of <b>appsettings.json</b> file
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
        
      

    
 
