# Week 13 Two Day Project: Build Your Own API

#### Custom built API offering useful information in the identificiation and health of your dog's stool.

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

_This API was designed aid in the quick and efficient identification of 16 different types of canine fecal matter. In addition to identification, this API also provides information on health grade, problem, and potential solutions._

_This API includes data on the following properties:_

* _Consistency_
  * _soft, liquid, hard_

* _Volume_
  * _average, above average, below average_
  
* _Color_
  ![poopImage](img/poop.png)
  * _brown, pink or purple, orange or yellow, green, grey, black, or white_

* _Content_
  * _none, rice-like polka-dots, red streak, grass and random stuff, fur_

* _Coating_
  * _none, greasy, mucus_

* _Grade_
  * _A, A-, B+, B, B-, C, C-, D, D-, F_

* _Problem_
  * _A brief description of possible causes._

* _Solution_
  * _A recommended course of action._

_For best results querying one property at a time, will return best results. If evaluating for two or more properties it is reccommended that two or more api calls are made and results appended together._

![poopImage](img/poopchart.png)

## Disclaimers -- IMPORTANT

_This API was not developed by a licensed veterenarian and is based on information found at:_ https://www.becopets.com/blogs/news/healthy-dog-pvoo-chart. 

_This API is not intended for use in evaluation of human or cat fecal matter._

## Link to Git Hub Repository

https://github.com/AsheUrban/PoopScoop.Solution

### Da Poop Scoop Naming Conventions

* _Production Database:_ poop_scoop
* _Main Project Folder:_ PoopScoop.Solution

## Setup/Installation Requirements

* _Clone or download repository to your local._
* _Cd into PoopScoop and run dotnet restore, dotnet build to confirm the project has no errors._
* _Touch appsettings.json and add the following configuration:_

<pre>{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[poop_scoop];uid=root;pwd=[password];"
  }
}</pre>

* _Run dotnet ef migrations add Initial and dotnet ef database update to build database._
* _Then use dotnet watch run to run web application._

_NOTE:_ [password] should be replaced by your password. Do not include square brackets in final configuration.

## Known Bugs

* _No known bugs in API._
* _README.md doesn't render in github correctly. Use view in VSC to see images._


## License

* MIT

## Contact Information

_Please contact us with any questions or contribuitions, ashe@goldentongue.com, caroceru@gmail.com, liam22campbell@gmail.com_

Copyright(c) August 2022 Ashe Urban, Caroline Cerussi, Liam Campbell