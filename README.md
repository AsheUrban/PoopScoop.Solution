# Week 13 Two Day Project: Build Your Own API

#### Custom built API offering a helpful index of the signs, and symptons of your pet's poop. Then, there is information that will give you helpful information on  wellness advice based on the  about health concerns, and cures through analizing your pet's poop

#### By Ashe Urban, Caroline Cerussi, Liam Campbell

## Technologies Used

* _C#_
* _CSHTML_
* _CSS_
* _Entity Framework_
* _SQL Database_
* _dotnet_
* _Markdown_

## Description

_You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it_

* _List of all Engineers._
* _List of all Machines._
* _Engineer Details including Machines they work on._
* _Machine Details including Engineers that work on them._
* _Add new Engineers._
* _Add new Machines._
* _Add and Delete Machines from Engineers._
* _Add and Delete Engineers from Machines._


_Link to Github Repository:_ https://github.com/AsheUrban/PoopScoop.Solution

### Da Poop Scoop

_You must follow the naming conventions for your project. Projects that do not follow these conventions will not be reviewed and will be returned not passing._

_Use your first name and last name to name your database in the following way:_

_Production Database:_ poop_scoop
_Main Project Folder:_ PoopScoop.Solution

## Setup/Installation Requirements

* _Clone or download responsitory to your local._
* _Cd into Factory and run dotnet restore, dotnet build to confirm the project has no errors._
* _Touch appsettings.json and add the following configuration:_

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[poop_scoop];uid=root;pwd=[password];"
  }
}

* _Run dotnet ef migrations add Initial and dotnet ef database update to build database._
* _Then use dotnet watch run to run web application._

_NOTE:_ [password] should be replaced by your password. Do not include square brackets in final configuration.

## Known Bugs -- IMPORTANT --

* _No known bugs._

## License

* MIT

## Contact Information

_Please contact us with any questions or contribuitions, ashe@goldentongue.com_, caroceru@gmail.com, liam22campbell@gmail.com

Copyright(c) August 2022 Ashe Urban, Caroline Cerussi, Liam Campbell