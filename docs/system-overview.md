# System Overview

FluentAPI consists of the following main components:

| Component     | Role                                       |
|---------------|--------------------------------------------|
| FluentAPI Core | Main backend application (ASP.NET Core)    |
| Web UI         | Interface for API configuration and control |
| Keycloak       | Identity & access management                |
| YARP           | Reverse proxy for request routing           |
| Prometheus     | Metrics gathering                           |
| Grafana        | Metrics visualization                       |
| Database       | Stores configuration & usage data          |

## Request Flow

1. Request enters via reverse proxy (YARP)
2. Auth check via Keycloak
3. Forwarded to internal or external API
4. Metrics logged via Prometheus

