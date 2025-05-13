# AutoMapperExample

This project demonstrates how to use [AutoMapper](https://automapper.org/) and [FluentValidation](https://fluentvalidation.net/) in an ASP.NET Core Web API (.NET 8, C# 12) to map between domain models and Data Transfer Objects (DTOs), and to validate incoming data. It also includes Swagger/OpenAPI integration for easy API exploration.

## Features

- CRUD API for `Item` entities using DTOs
- AutoMapper integration for model-to-DTO mapping
- FluentValidation for DTO validation
- In-memory data storage (static list)
- Swagger UI for API documentation and testing

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 or later

### Running the Project

1. Clone the repository or download the source code.
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Build and run the project.

The API will be available at `https://localhost:{port}/api/item` and Swagger UI at `https://localhost:{port}/swagger`.

### Example Endpoints

- `GET /api/item` - Get all items
- `GET /api/item/{id}` - Get item by ID
- `POST /api/item` - Create a new item (validated with FluentValidation)
- `PUT /api/item/{id}` - Update an existing item (validated with FluentValidation)
- `DELETE /api/item/{id}` - Delete an item

## Project Structure

- `Controllers/ItemController.cs` - API endpoints for items
- `Models/Item.cs` - Domain model
- `DTOs/ItemDTO.cs` - Data Transfer Object
- `Mappings/AutoMapperProfile.cs` - AutoMapper configuration
- `Validators/ItemDTOValidator.cs` - FluentValidation rules for DTOs
- `Program.cs` - Application startup and service configuration

## NuGet Packages Used

- [AutoMapper](https://www.nuget.org/packages/AutoMapper)
- [AutoMapper.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection)
- [FluentValidation](https://www.nuget.org/packages/FluentValidation)
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore)

## License

This project is licensed under the MIT License.
