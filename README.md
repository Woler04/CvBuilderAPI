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

## End Points
### User
User DTO(data transfer object)(can become easy JSON)
```
{
id	integer($int32)
username	string
nullable: true
email	string
nullable: true
password	string
nullable: true
}
```
>GET /api/User - Get all users.

>POST /api/User - Create a new user.

>GET /api/User/{userId} - Get a specific user.

>PUT /api/User/{userId} - Update a user.

>DELETE /api/User/{userId} - Delete a user.

>GET /api/User/{userId}/resumes - Get user's resumes.

### Resume
Resume DTO
```
{
resumeId	integer($int32)
title	string
nullable: true
creationTime	string($date-time)
lastModifiedTime	string($date-time)
}
```
>GET /api/Resume - Get all resumes.

>POST /api/Resume - Create a new resume.

>GET /api/Resume/{resumeId} - Get a specific resume.

>PUT /api/Resume/{resumeId} - Update a resume.

>DELETE /api/Resume/{resumeId} - Delete a resume.

>GET /api/Resume/{resumeId}/user - Get resume's associated user.

>GET /api/Resume/{resumeId}/skills - Get resume's skills.

>GET /api/Resume/{resumeId}/template - Get resume's template.

>GET /api/Resume/{resumeId}/locations - Get resume's locations.

>GET /api/Resume/{resumeId}/languages - Get resume's languages.

>GET /api/Resume/{resumeId}/certificates - Get resume's certificates.

>GET /api/Resume/{resumeId}/personalInfo - Get resume's personal info.

>GET /api/Resume/{resumeId}/educations - Get resume's educations.

>GET /api/Resume/{resumeId}/experiences - Get resume's experiences.























