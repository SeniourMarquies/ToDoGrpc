# ToDoGrpc
## Overview
ToDoGrpc is a simple ToDo list application that uses ASP.NET Core gRPC, JSON transcoding, SQLite, DBeaver, and Swagger technology.

Features
1 - Create, read, update, and delete (CRUD) ToDo items
2 - JSON transcoding for easy communication with non-gRPC clients
3 - SQLite for lightweight and portable database storage
4 - DBeaver for database management
5 - Swagger for API documentation and testing

## Prerequisites
1 - ASP.NET Core 6.0 or later
2 - Visual Studio 2022
2 - SQLite
3 - DBeaver (Optional)
4 - Swagger

## Getting Started

Clone the repository:
```bash
git clone https://github.com/SeniourMarquies/ToDoGrpc
```
## Open the solution in Visual Studio 2022.

Restore the dependencies:

```bash
dotnet restore
```
Build the solution:
```bash
dotnet build
```
Start the server:
```bash
dotnet run
```
Open a browser and navigate to [http://localhost:5000/swagger](https://localhost:7018/index.html) to view the API documentation.

## Usage
To use the ToDoGrpc API, you can use Postman or Swagger UI built in project.
## Screen Shots
![Uygulama Ekran Görüntüsü](https://github.com/SeniourMarquies/ToDoGrpc/blob/master/ss.png)
![Uygulama Ekran Görüntüsü](https://github.com/SeniourMarquies/ToDoGrpc/blob/master/ss2.png)
