# ASP.Net-Core 2.2 Empty Project

1. <b>Solution Explorer View</b> :

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
        - The default is outofprocess hosting but it has been changed to Inprocess for 3 and above
        
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
    - The code is as follows :
    
    ![StartUp.cs](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/SatrtUp.JPG)
    - `ConfigureServices` : configures services required for application
    - `Configure` : configures the application request processing pipeline
    
5. <b> launchSettings.json </b> :
    - View is as follows :
    
    ![launchSettings.json](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/launchSettings.JPG)
    - This file is required while development only
    - It is used when application is run from CLI or IDE
    
    
 
