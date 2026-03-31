# FocusLens — CLAUDE.md

## Project Overview
FocusLens is a Digital Wellbeing web app for PC. It tracks browser tab usage
via a Chrome extension and displays analytics on an Angular dashboard.
The backend is .NET 10 Web API connected to Oracle Autonomous Free DB.

## Tech Stack
- Frontend: Angular 17+ (TypeScript, standalone components)
- Backend: .NET 10 Web API (C#), Entity Framework Core
- Database: Oracle Autonomous Free Tier (via Oracle.EntityFrameworkCore)
- Auth: JWT Bearer tokens + refresh token rotation
- Browser extension: Chrome Manifest V3 (Vanilla JS, no bundler)
- Deployment target: Oracle Cloud (backend) + Vercel (frontend)

## Folder Structure
focuslens/
├── frontend/          # Angular app
├── backend/           # .NET 10 Web API
│   ├── Models/        # EF Core DbContext and entity classes
│   ├── Controllers/   # API controllers (add as we grow)
│   └── Properties/
├── extension/         # Chrome MV3 extension
└── CLAUDE.md

## Coding Standards
- C#: use record types for DTOs, async/await everywhere, no magic strings
- Angular: standalone components only, no NgModules unless necessary
- Use meaningful variable names — no abbreviations like "mgr", "svc", "tmp"
- Always add XML doc comments on public .NET methods
- Angular services use the inject() function, not constructor injection
- Never hardcode secrets — use dotnet user-secrets in development

## Completed Iterations

### Iteration 1 — Foundation (DONE)
- .NET 10 Web API scaffolded
- Oracle EF Core provider installed and DbContext created (AppDbContext)
- GET /api/health endpoint returning { status: "ok" }
- Oracle connection string in appsettings.json (to be moved to user-secrets)

## Current Iteration
### Iteration 2 — Auth + User Accounts
Goals:
- User entity + EF Core migration
- POST /api/auth/register — creates user with hashed password
- POST /api/auth/login — returns JWT access token + refresh token
- JWT middleware configured in Program.cs
- Angular login + register pages (standalone components)
- Angular HTTP interceptor to attach Bearer token to all requests
- Angular route guard to protect future dashboard routes

## Commands
- Frontend: cd frontend && ng serve
- Backend: cd backend && dotnet run
- Add migration: cd backend && dotnet ef migrations add <name>
- Apply migration: cd backend && dotnet ef database update
- Set secret: cd backend && dotnet user-secrets set "OracleConnection" "<value>"

## Do Not
- Do not use .NET 6, 7, or 8 APIs — project targets net10.0
- Do not use NgModules in Angular (use standalone)
- Do not commit connection strings or secrets — use user-secrets / env vars
- Do not leave the WeatherForecast boilerplate endpoint in Program.cs
- Do not use var for complex types — prefer explicit types for readability