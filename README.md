# ASP.NET Core Web API + React SPA template

This repository is a template for a modern web app, powered by [React.js](https://reactjs.org/) on the front end and [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) on the back end.

## Features and design decisions

- Database seeding service to allow [custom initialization logic](https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding#custom-initialization-logic)
- Unit tests with [Xunit](https://xunit.net/)
- [Swagger](https://swagger.io/) for generating an interactive documentation of the back end API
- [Data transfer objects](https://en.wikipedia.org/wiki/Data_transfer_object) for interfacing between the front and back end
- [AutoMapper](https://automapper.org/) for automatically mapping between DTOs and entities
- [TypeScript](https://www.typescriptlang.org/) support in the React app

## Things not included

The following are a list of other features you could add to the project to further increase code quality. I did not include them in this template since they are more complex or there are many valid solutions (I've listed a few in parantheses):

- Support for a _real_ database (e.g. [PostgreSQL](https://www.postgresql.org/))
- [Migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/) (useful when using a persistent database as recommended above)
- Set up user authentication (using [Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio) or [IdentityServer](https://docs.identityserver.io/en/latest/index.html))
- Use [the repository pattern](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-implementation-entity-framework-core) to avoid directly accessing the Entity Framework context from your API controllers (this might be useful when your project scales)
- End-to-end tests (Cypress, Selenium, etc.)
- Continuous integration and continuous deployment (GitHub Actions, GitLab CI/CD, etc.)
- Automated dependency updates ([Dependabot](https://dependabot.com/))
- Automated code vulnerability scanning ([GitHub security features](https://github.com/features/security))

## Why?

I've created this template for my own use, since I couldn't find anything similar on the internet. While Microsoft provides a [standard React SPA template](https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/react?view=aspnetcore-5.0&tabs=visual-studio) with the ASP.NET Core SDK, it hardly replicates the best practices found in the industry.

After a long learning process and many mistakes, I've published this template: my own, opinionated view on how to best structure and organize a modern web app built with ASP.NET and React.

## Acknowledgements

- Thanks to the [Code4romania](https://code4.ro/en) community for their high-quality projects (which were a big source of inspiration) and their uplifting vision for Romania.
- Thanks to the [University of Bucharest](https://unibuc.ro/) Software Development Center for an opportunity to grow and apply my skills.
