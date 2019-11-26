# _Parks and Recreation_

#### _A Basic State and National Parks API that serves a web app MVC client: ParksAndRecClient_

#### _By **Jennifer Batara**_

## Description

This application is a ASP.Net Web API that gives out the information for different state and national parks. This api is intended to be used by any person who wants to enjoy state and national parks, or for local Parks and Recreation departments to more quickly update the status of the parks under their domain. The PawneeClient is an ASP.Net MVC web application that is an example of this local P&R department utilizing the API for their local parks. The PawneeClient web application is currently under construction, but the Web API is fully functional!

## Pawnee Client User Stories
- As Ron Swanson, you can view all API data, but are unable to delete, put, or post park information due to the "Total Deletion Initiative" of '09. Our records indicate he still tries. Don't give him admin access.
- As Leslie Knope, you can view all API data, but are unable to post park information due to the constant attmepts to add Joe Biden in the description of Mount Rushmore.
- As Tom Haverford, you do not have any API or Web App access due to the frequent attempts to advertise Snakhole Lounge, Snake Juice, and Rent-A-Swag by injecting ads in the API, local website, and dumping flyers into the most frequented parks (he's still underinvestigation for this).
- As Ben Wyatt, you have admin access to all the API data as well as the website. Local government was hesitant to give you this perk due to the "Ice Town" incident.

## Setup/Installation 

### Requirements
-   Internet Connection
-   Internet browser
-   Bash Terminal
-   .NET Core 2.2
-   MySQL

### Cloning the Project Locally
If you do not have the .NET Core installed on your computer, please install it by following the directions for your operating system [here](https://dotnet.microsoft.com/download). The .NET Core version used for this project is 2.2.

To view locally please change directory to the directory in which you would like to clone the repository. Copy the link to [this repo](https://github.com/jbatara/ParksNRecreation.git) and type the following command into your Bash terminal:
```
$git clone repo_url
```

with repo_url being the url that was just copied. To open the console app, navigate to the local directory which the online repository was cloned to using the command

```
$cd SweetNSavory/SweetNSavory
```

### Setting up a MySql 

Make sure you have MySql installed on your machine. If you do not, download the [MySql Community Server](https://dev.mysql.com/downloads/mysql/). Install MySql, and create a password for the default user. _Make sure to write down this password as all future MySql processes need this password!_

Once installed correctly, run a local instance of your MySql database using the command:
```
$mysql -u root -p
```
The terminal will prompt you to input your password that you have previously saved.

Once running successfully, you will see a welcome message and the prompt will turn into:
```
mysql> 
```

### Connecting the Application to Local MySql Instance
Open the _appsettings.json_ file in the ParksAndRecAPI folder.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parksnrec;uid=root;pwd=password;"
  }
}
```
Change "password" to your MySql password.

### MySql Database Schema from migration
 
Open the terminal and navigate to the ParksAndRecAPI folder. Run the following command:

```
$dotnet restore
$dotnet ef database update
```
Dotnet will return a "Done." message once the database has been successfully updated. If you recieve an error "Build failed.", run the command:
```
$dotnet build
```
to get a more in depth error log.

Once all errors are corrected, you will have an updated MySQL database!

### Running the Application

Change the terminal directory to be in the ParksAndRecAPI project of the ParksAndRec folder. Confirming that you have .NET core installed (version 2.2), run the api with the command
```
$dotnet run
```
Now that the api is successfully running, in a new terminal window navigate to the PawneeClient folder and run the application with the command
```
$dotnet run
```
Open the browser to the address [http://localhost:5004](http://localhost:5004) and enjoy! You can try to make api calls using [Postman](https://www.getpostman.com/).

This project is currently not hosted online.

## Known Bugs

_None. All previously reported bugs have been resolved._

## Support and contact details

Please feel free to contact the developer by raising a new [issue](https://github.com/jbatara/ParksNRecreation/issues/new) on the github repo. You can browse the current issues [here](https://github.com/jbatara/ParksNRecreation/issues).

## Technologies Used

* C#
* .NET Core 2.2
* Entity Core
* .Net Core Web Api

### License

_MIT_

Copyright (c) 2019 **_Jennifer Batara_**
