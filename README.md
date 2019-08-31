# Steps to setup environment
1. Clone this repo
2. Open VS CLI and verify that Sql Local DB is installed 
```
sqllocaldb info
```
3. From the VS CLI inside the project directory, verify Entity Framework is installed
```
dotnet ef
If not installed, use NuGet package manager to install the latest stable version
```
4. From the VS CLI inside the project directory, verify the database context
```
dotnet ef dbcontext info
This should print a message that the database has been intitialized using your db context class
```
5. From the VS CLI inside the project directory, create a new migration 'myfirstmigration'
```
dotnet ef migrations add myfirstmigration -v
This should create the database
```
6. Verify the migration files to see that they match your model structure
7. From the VS CLI inside the project directory, run the migration with the update command to create database
```
dotnet ef database update -v
```
8. Use the database object browser to validate that the database has been created
9. Use the database object browser to add test records to your tables
