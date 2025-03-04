# API-Versioning


This project demonstrates how to implement API versioning in an ASP.NET Core Web API. The project includes two versions of an API for managing items, showcasing how to handle different versions of the same API.

## Features

- **API Versioning**: The project includes two versions of the `ItemsController` to demonstrate how to manage different versions of an API.
- **CRUD Operations**: Both versions of the API support basic CRUD operations (Create, Read, Update, Delete) for items.
- **ASP.NET Core**: Built using ASP.NET Core, leveraging its features for building modern web APIs.

## Project Structure

- **V1/Controllers/ItemsController.cs**: Contains the first version of the `ItemsController` with basic CRUD operations.
- **V2/Controllers/ItemsController.cs**: Contains the second version of the `ItemsController` with updated descriptions for items.
- **Models/Item.cs**: Defines the `Item` model used by both versions of the API.

## API Endpoints

### Version 1

- **GET /api/v1/items**: Retrieves a list of items.
- **GET /api/v1/items/{id}**: Retrieves a specific item by ID.
- **POST /api/v1/items**: Creates a new item.
- **PUT /api/v1/items/{id}**: Updates an existing item by ID.
- **DELETE /api/v1/items/{id}**: Deletes an item by ID.

### Version 2

- **GET /api/v2/items**: Retrieves a list of items with updated descriptions.
- **GET /api/v2/items/{id}**: Retrieves a specific item by ID with an updated description.
- **POST /api/v2/items**: Creates a new item.
- **PUT /api/v2/items/{id}**: Updates an existing item by ID with an updated description.
- **DELETE /api/v2/items/{id}**: Deletes an item by ID.

## Getting Started

### Prerequisites

- .NET 8 SDK

### Running the Application

1. Clone the repository.
2. Navigate to the project directory.
3. Run the application using the following command:

   