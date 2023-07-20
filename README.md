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
Get all users

>GET /api/User

Create a new user

>POST /api/User

Get a specific user

>GET /api/User/{userId}

Update a user

>PUT /api/User/{userId}

Delete a user

>DELETE /api/User/{userId}

Get user's resumes

>GET /api/User/{userId}/resumes

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
Get all resumes

GET /api/Resume

Create a new resume

POST /api/Resume

Get a specific resume

GET /api/Resume/{resumeId}

Update a resume

PUT /api/Resume/{resumeId}

Delete a resume

DELETE /api/Resume/{resumeId}

Get resume's associated user

GET /api/Resume/{resumeId}/user

Get resume's skills

GET /api/Resume/{resumeId}/skills

Get resume's template

GET /api/Resume/{resumeId}/template

Get resume's locations

GET /api/Resume/{resumeId}/locations

Get resume's languages

GET /api/Resume/{resumeId}/languages

Get resume's certificates

GET /api/Resume/{resumeId}/certificates

Get resume's personal info

GET /api/Resume/{resumeId}/personalInfo

Get resume's educations

GET /api/Resume/{resumeId}/educations

Get resume's experiences

GET /api/Resume/{resumeId}/experiences

### Template
Template DTO
```
{
languageId	integer($int32)
languageName	string
nullable: true
level	string
nullable: true
}
```
Get all templates

GET /api/Template

Create a new template

POST /api/Template

Get a specific template

GET /api/Template/{templateId}

Update a template

PUT /api/Template/{templateId}

Delete a template

DELETE /api/Template/{templateId}

Get resumes using a template

GET /api/Template/{templateId}/resumes

Associate a template with a resume

POST /api/Template/{templateId}&&{resumeId}

Remove association between a template and a resume

DELETE /api/Template/{templateId}&&{resumeId}

### Skill
Skill DTO
```
{
skillId	integer($int32)
skillName	string
nullable: true
}
```
Get all skills

GET /api/Skill

Create a new skill

POST /api/Skill

Get a specific skill

GET /api/Skill/{skillId}

Update a skill

PUT /api/Skill/{skillId}

Delete a skill

DELETE /api/Skill/{skillId}

Get resumes associated with a skill

GET /api/Skill/{skillId}/resumes

Associate a skill with a resume

POST /api/Skill/{skillId}&&{resumeId}

Remove association between a skill and a resume

DELETE /api/Skill/{skillId}&&{resumeId}


















