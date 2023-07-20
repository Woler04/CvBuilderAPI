# Curriculum Vitae Builder API Documentaion
This repository contains an API(Application programming interface) for our project Curriculum Vitae (Builder) 
made for AIBEST Academy 2023

## Set up
Unfortunately, our API is not hosted anywhere so it has to be run locally to be used
After downloading or cloning and opening the solution you need to

1. Get a valid connection string to database and set it in the appsettings.json
```
 "ConnectionStrings": {
   "DefaultConnection": "Data Source=YOURCONNECTIONSTRING"
 }
```

2. Then run the "update-database" command in the Package Manager Console so the migrations be applied
3. There is no seed for the database BUT that is an excellent opportunity to try reaching an endpoint

## [End Points]((docs/CVAPI.md))
### User
