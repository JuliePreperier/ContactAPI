# ContactAPI
It’s a simple API, where a user can get a quick overview over all contacts resources like person, skills...

The following use cases are implemented:

Person
A CRUD endpoint for managing contacts. A contact should have at least the following attributes and
appropriate validation:
• Firstname
• Lastname
• Fullname
• Address
• Email
• Mobile phone number

Skill
A CRUD endpoint for skills. A contact can have multiple skills and a skill can belong to multiple
contacts. A skill should have the following attributes and appropriate validation:
• Name
• Level (expertise)

The API run on Swagger to test every methods.
An Authentication with JWT is implemented
.NET Core Web API (5) is used for the project
