# Sample .Net Core application (using .Net Framework)
Sample project that showcases the use of dotnet core with dotnet framework  

> Requirements  
> 1. DotNet Core 1.0 and above
> 2. .Net Framework 4.6.*

## SampleDotNetCore.Service
Application classes that performs business logic code outside the system.  
In this case there's a `GitHubService.cs` which exist to maken asynchronous request to the github api to retrieve the basic information of a given user

## SampleDotNetCore.Models
Models for the application  
`GitHuModel` contains the definition of all the basic required information for the application.

## SampleDotNetCore.Contracts  
Interfaces that required for *DI/IoC* implementation.  
`IGitHubService` exist as a contract for the `GitHubService` service implementation and is mapped with the `Startup.cs` file.

## API
Consumes the services/repositories to provide data to the consumer/client in json.  
`GitHubController` uses *DI* to resolve the Service and uses it's own View model to display the information.

## Web
_Not Implemented__