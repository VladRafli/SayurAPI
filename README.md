# ASP.NET Core Web API Example

This repo is just reproduce code from example given from Microsoft Docs, link down below:

[**Create a web API with ASP.NET Core Controllers**](https://docs.microsoft.com/en-gb/learn/modules/build-web-api-aspnet-core/)

Basicly, its just tutorial how to make RESTful API using ASP.NET Core that supports CRUD Operations.

# Notes

- Make sure that .Net SDK and nuget is present on your machine
- This project is run on **Visual Studio Code** (Not Visual Studio)
- Install C# Extension (OmniSharp) for Intelisense

# How to run from scratch

**Note: Better to init project like steps below**

- Open terminal
- Run `dotnet new webapi -o SayurAPI`
- Open project on VSCode `code SayurAPI`
- Install required dependencies `dotnet restore`
- Run the Project `dotnet run` or Watch for Hot Reloads `dotnet watch`
- Then follow the tutorial

# Intellisense not running?

- Press f1 on VSCode
- Search for -> OmniSharp: Select Project
- Select that had .csproj extension
- Finished!
