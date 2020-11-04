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
        - It is containing <i> Metapackages </i> (Microsoft.AspNetCore.App), they have no content of their own and contains only dependencies

3. <b> Program.cs </b> :
    - The code is as follow :
    
    ![Program.cs](https://github.com/KarkiBindu/ASP.Net-Core/blob/main/Program.JPG)
    - ASP.Net core initially starts as console application with `Main` method
    - Extended method `CreateWebHostBuilder` calls `WebHost.CreateDefaultBuilder `
