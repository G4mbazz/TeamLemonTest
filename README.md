# Team Lemon's Bank App!
A simple bank app made with .NET Core 3.1

##Table of Contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [Classes](#classes)

## General info
This project is a simple bank app where the user can create new accounts, check current accounts,
take a loan, open a savings account and transfer to other users in the bank.

## Technologies
Project created with:
.NET Core 3.1.
C# 8.0.

## Setup

```
$ cd ../debug
$ TeamLemon.exe
```

# Classes
[Login](#login)
[Menu](#menu)
[Account Managment](#account-managment)
[Loan Managment](#loan-managment)
[Account](#account)
[Admin](#admin)
[Loan](#loan)
[Person](#person)
[User](#user)



## Login
This is our login class that handles the basic login functions with username and password validation.
The admin also goes through the same login class and at the end we check if the user is an admin or normal user.

## Menu
This is the menu class. Here the user or admin gets to choose where to go next in the program depending on their role.
The user have many choices to pick and the admin have the basic functions of creating a new user and changing exchange rates.

## Account Managment
![alt text](https://ibb.co/PZJwwb5)
