# Local Business Lookup
##### By Andrew Bates
###### Last Updated Jan 31 2020

## Description

This is an api designed to hold local businesses and their respective information. 

## Specifications:

The user will be able to call for:

  - Name 
  - Address 
  - Phone number 
  - Website

## Links:

Github - https://github.com/LocalBusinessLookup

## Setup/Installation Requirements:

1. Open https://github.com/LocalBusinessLookup
2. Clone repository to local machine 
3. Install .NET and ASP.NET Core
4. Downliad and install SQL Server
5. In the terminal:

  - $ dotnet build - when you are ready to build project
  - $ dotnet run - to run the project 
  - $ dotnet test - for testing the project

## To create the tables: 

  - $ dotnet ef migrations add initial
  - $ dotnet ef database update

## Known Bugs

* _No known bugs at this time_

## Technologies Used:

* C#
* .NET
* ASP.NET Core
* Entity
* linq
* JWT Authentication

## License
MIT License

Copyright (c) 2020 Andrew Bates