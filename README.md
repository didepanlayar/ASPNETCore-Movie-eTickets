<div align="center">
    <img src="https://res.cloudinary.com/rexcuni/image/upload/v1688969225/favicon_oxddqi.png" width="80px">
    <br>
    <h1>Movie eTickets</h1>
</div>
<p align="center">
    <a href="https://didepanlayar.com" target="_blank"><img alt="" src="https://img.shields.io/badge/Website-1DA1F2?style=normal&logo=dribbble&logoColor=white" style="vertical-align: center" /></a>
    <a href="https://instagram.com/didepanlayar" target="_blank"><img alt="" src="https://img.shields.io/badge/Instagram-DD2A7B?style=normal&logo=instagram&logoColor=white" style="vertical-align: center" /></a>
    <a href="https://www.youtube.com/@didepanlayar" target="_blank"><img alt="" src="https://img.shields.io/badge/YouTube-CD201F?style=normal&logo=youtube&logoColor=white" style="vertical-align: center" /></a>
</p>

## Description
e-Commerce application with ASP.NET Core MVC and Entity Framework Core for Movie e-Tickets case study.

## Features
- Manage Account
- Manage Actors
- Manage Cinemas
- Manage Movies
- Manage Producers
- Manage Orders
- Integrated with PayPal

## Requirement
Requirements to use this project.
- [x] PayPal Developer
- [x] Micosoft SQL Server

Framework and package versions.
| Name | Version |
| ----- | ----- |
| .NET | 6.0.412 |
| Microsoft.AspNetCore.Identity.EntityFrameworkCore | 6.0.20 |
| Microsoft.EntityFrameworkCore | 7.0.4 |
| Microsoft.EntityFrameworkCore.SqlServer | 7.0.4 |
| Microsoft.EntityFrameworkCore.Tools | 7.0.4 |

## Installation
Clone this project.
```sh
git clone https://github.com/didepanlayar/ASPNETCore-Movie-eTickets.git
cd ASPNETCore-Movie-eTickets
```
Create database and add connection string in `appsettings.json`.
```sh
"DefaultConnectionString": "<Connection String>"
```
Add PayPal Client ID in `Views/Orders/ShoppingCart.cshtml`.
```sh
sandbox: "<Client ID>"
```
Restore configuration.
```sh
dotnet restore
dotnet build
```
Run Project.
```sh
dotnet dev-certs https
dotnet run
```
Hot Reload.
```sh
dotnet watch run
```

## Screenshots
<img src="https://res.cloudinary.com/rexcuni/image/upload/v1690886738/ASP.NET_Core_Movie_eTickets_y97eek.png" width="100%">

## Tech Stack
- ASP.NET Core
- C#
- Microsoft SQL
- Visual Studio Code
- Docker
- DBeaver