# _Parks and Recreation_

#### _A Basic State and National Parks API that serves a web app MVC client: ParksAndRecClient_

#### _By **Jennifer Batara**_

## Description

This application is a ASP.Net web api that gives out the information for different state and national parks. This api is intended to be used by any person who wants to enjoy state and national parks, or for local Parks and Recreation departments to more quickly update the status of the parks under their domain. The PawneeClient is an ASP.Net MVC web application that is an example of this local P&R department utilizing the API for their local parks. 

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
-   SQLite

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
### MySql Database Schema
To reconstruct the database schema and data from the mysql command line interface type in the following commands:

1. Create a new database called salon
```
mysql> CREATE DATABASE salon;
```
Some errors you may encounter:
- ERROR 1007 (HY000): Can't create database 'salon'; database exists
  In this case, make sure that your previously created salon database is empty, so that you don't overwrite important data. If it is not empty, change the name of the database to something different. _Be sure to note the name of the database, as it will be important for future configuration._

2. Change the working database to the new 'salon' database you have created. (If your database name is different, replace 'salon' with your database name.)
```
mysql> USE salon;
```

3. Recreate the database schema by pointing to the Salon.sql file. Make sure to replace "[local path]" with the path from the root to the location of the EauClaireSalon project.
```
mysql> SOURCE [local path]/EauClaireSalon/HairSalon/Salon.sql;
```

Now your database has been recreated!

### Connecting the Application to Local MySql Instance
Open the _appsettings.json_ file in the Hair Salon folder.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=salon;uid=root;pwd=password;"
  }
}
```
Change "password" to your MySql password. Please make sure to correct the database name if it was changed.


### Running the Application

Change the terminal directory to be in the HairSalon project of the EauClaireSalon folder. Confirming that you have .NET core installed (version 2.2), run the app with the command
```
$dotnet run
```
and enjoy!

This project is currently not hosted online.

## Known Bugs

_None. All previously reported bugs have been resolved._

## Support and contact details

Please feel free to contact the developer by raising a new [issue](https://github.com/jbatara/ParksNRecreation/issues/new) on the github repo. You can browse the current issues [here](https://github.com/jbatara/ParksNRecreation/issues).

## Technologies Used

* C#
* .NET Core 2.2

### License

_MIT_

Copyright (c) 2019 **_Jennifer Batara_**
