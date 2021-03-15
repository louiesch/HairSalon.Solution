# _Louie's Hair Salon_

#### _Practice assignment to get experience using ASP.NET Core MVC and Databases to help a salon track their stylists and clients._

#### By _**Louie Schoenknecht**_

## Technologies Used

* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _dotnet script, REPL_
* _Razor View Engine_
* _MySQL and MySQLWorkbench_
* _Git_


## Setup/Installation Requirements

### Application Setup
* _Install .NET 5.0 [here](https://dotnet.microsoft.com/download/dotnet/5.0)_

* _Clone repository from GitHub to desired location using_
  > $ git clone https://github.com/louiesch/HairSalon.Solution
* _In the terminal navigate to and open project directory_
  > cd HairSalon.Solution
* _Navivate to production directory_
  > cd HairSalon
* _Create a file in production folder called appsettings.json_
  > touch appsettings.json
* _Add the following code to your .json file_
```
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
}
}
```
* _Make sure that [YOUR DATABASE] and [YOUR PASSWORD] match the database name and password of your local MySql server._

### Database Setup

* _Download MySQL and MySQL Workbench to set up a local database._



* _Once in project directory, open project in code editor_
  >code .
* _To build project, navigate to the ToDoList production folder. To download obj and bin files needed for the program to run, in the terminal enter:_
  >dotnet restore
* _To run the program, while still in production folder ToDoList type into the terminal:_
  >dotnet run
* _Note: The server will not open automatically. The user will need to click on the link in terminal, or enter local host URL into browser._


* _To run tests: Navigate from the root directory to the ToDoList.Tests directory. Then in terminal, type:_
  >dotnet restore
* _Finally, to run the tests, make sure you are still in the BakeryTracker.tests directory and in the terminal type:_
  >dotnet test

## Known Bugs

* _Items can still be added if they don't have a category, but they will not show up in the list._

## License

_[MIT](https://choosealicense.com/licenses/mit/) Copyright (c) 2021 Louie Schoenknecht_


## Contact Information

_Get in touch: luisesch97@gmail.com_