# Architecture & Design Decisions

FluentAPI is built as a modular monolith in ASP.NET Core.

## Key Principles

- **Simplicity First**: Start with a single deployable unit.
- **Containerized Core**: External components like Keycloak and Prometheus run in Docker.
- **Configurable via Web UI**: API routing and security managed through the frontend.
- **Open Source by Default**: All components are free and community-friendly.

## Technologies

- ASP.NET Core (modular monolith)
- YARP (reverse proxy)
- Keycloak (auth)
- Prometheus & Grafana (monitoring)
- PostgreSQL / SQLite (data persistence)
