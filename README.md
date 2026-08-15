# AccountingApi in summary
A RESTful API for an accounting platform built with ASP.NET Core.
The goal of this project is to design and develop a backend platform for accounting systems, focusing on clean architecture, database design, and modern backend development practices.

## Technologies
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Postman
- GitHub Actions (CI/CD)

## Architecture
The project follows a layered architecture:
```text
Controller
    |
    v
Service
    |
    v
Repository
    |
    v
Entity Framework Core
    |
    v
PostgreSQL Database
```
Controllers handle HTTP requests and responses. Services contain business logic, and coordinate operations between controllers and repositories. Repositories handle database operations. 

## API testing
API endpoints are tested using Postman. Example: 
```text
GET    /api/company
GET    /api/company/{id}
POST   /api/company
PUT    /api/company/{id}
DELETE /api/company/{id}
```

## Running the project
### Requirements
- .NET 10 SDK
- PostgreSQL 18
### Setup
1. Clone the repository:
