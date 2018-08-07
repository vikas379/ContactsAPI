# ContactsAPI
This is a Sample ASP .NET Core 2.1 Web API which contains CRUD APIs for handling a Contact Entity.

## Organization and Folder Structure

The Application is divided into layers
* Service Layer (ContactsAPI and ContactsAPI.Contract)
* Application Layer (ContactsAPI.Application and ContactsAPI.Application.Contract)
* Persistence Layer (ContactsAPI.Persistence and ContactsAPI.Persistence.Contract)
* Domain Layer (ContactsAPI.DomainModel)

## Technologies implemented

* ASP .NET Core 2.1
* ASP .NET Core Web API 2.1
* Entity Framework Core 2.1.1
* Fluent Validator
* AutoMapper
* Swagger UI

## Architecture

* Responsibility seperation concerns
* SOLID
* Repository and Generic Repository
* Global exception handling


## How to run the Application

In order to run the application in Visual Studio for windows do follow below steps: 
1. clone the repository in local system. Open command prompt and execute the follwing command
```
git clone https://github.com/vikas379/ContactsAPI.git
```
2. open the solution in Visual Studio 2017
3. Go to *__ContactsAPI/appsettings.json__* and change connection string to your local database.
4. open Package Manager Console
5. change the Default project in Package Manager Console to *__ContactsAPI/Persistence__*
6. run the following command in Package Manager Console. As per the connection string it will create a database in the sepcified SQL Server instance
```
update-database
```
7. Now run the API by using using *__CLTR + F5__*
8. Application will get launched in your browser and Swagger Explorer will open or You can browse the API from [Azure App Service](http://contactsapi.azurewebsites.net/)



