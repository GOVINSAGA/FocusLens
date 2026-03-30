# FocusLens — CLAUDE.md

## Project Overview
FocusLens is a Digital Wellbeing web app for PC. It tracks browser tab usage
via a Chrome extension and displays analytics on an Angular dashboard.
The backend is .NET 8 Web API connected to Oracle Autonomous Free DB.

## Tech Stack
- Frontend: Angular 17+ (TypeScript, standalone components)
- Backend: .NET 8 Web API (C#), Entity Framework Core
- Database: Oracle Autonomous Free Tier (via ODP.NET / EF Core Oracle provider)
- Auth: JWT Bearer tokens + refresh token rotation
- Browser extension: Chrome Manifest V3 (Vanilla JS, no bundler)
- Deployment target: Oracle Cloud (backend) + Vercel (frontend)

## Folder Structure
focuslens/
├── frontend/          # Angular app
├── backend/           # .NET 8 Web API
├── extension/         # Chrome MV3 extension
└── CLAUDE.md

## Coding Standards
- C#: use record types for DTOs, async/await everywhere, no magic strings
- Angular: standalone components only, no NgModules unless necessary
- Use meaningful variable names — no abbreviations like "mgr", "svc", "tmp"
- Always add XML doc comments on public .NET methods
- Angular services use the inject() function, not constructor injection

## Current Iteration
Iteration 1 — Project scaffolding:
- Angular app scaffold with routing
- .NET 8 API with health check endpoint (/api/health)
- Oracle DB connection via EF Core
- No auth yet (comes in Iteration 2)

## Commands
- Frontend: cd frontend && ng serve
- Backend: cd backend && dotnet run
- DB migrations: cd backend && dotnet ef migrations add <name>

## Do Not
- Do not use .NET 6 or older APIs
- Do not use NgModules in Angular (use standalone)
- Do not commit connection strings or secrets — use user-secrets / env vars
