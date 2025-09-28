# Silver Lemonade - Multi-User Blogging Platform

A comprehensive blogging platform built with .NET 8, featuring multi-user capabilities, Markdown support, image uploads, and role-based access control.

## 🏗️ Architecture

This solution consists of multiple projects targeting different platforms:

- **Backend API** (ASP.NET Core Web API) - RESTful API with Entity Framework
- **Web Frontend** (Blazor WebAssembly) - Modern web interface
- **Mobile/Desktop App** (.NET MAUI) - Cross-platform native application
- **Shared Library** (Class Library) - Common DTOs and models
- **Tests** (xUnit) - Unit and integration tests

## 📁 Project Structure

```
silver-lemonade/
├── BlogPlatform.sln                # Solution file
├── shared/                         # Shared C# library
│   └── BlogPlatform.Shared/
├── backend/                        # ASP.NET Core Web API
│   └── BlogPlatform.Api/
├── web/                           # Blazor WebAssembly app
│   └── BlogPlatform.Web/
├── apps/                          # .NET MAUI app
│   └── BlogPlatform.App/
└── tests/                         # Test projects
    └── BlogPlatform.Tests/
```

## 🚀 Features (Planned)

### Core Features
- ✅ Multi-user registration and authentication
- ✅ Blog post creation, editing, and deletion
- ✅ Comment system
- ✅ Markdown support for content
- ✅ Image upload and management
- ✅ Post tagging and categorization

### Advanced Features
- ✅ Role-based access control (Admin, Editor, Reader)
- ✅ User profiles and bio
- ✅ Post search and filtering
- ✅ Responsive design
- ✅ Cross-platform mobile app

## 🛠️ Tech Stack

- **Backend**: ASP.NET Core 8, Entity Framework Core, SQL Server
- **Frontend**: Blazor WebAssembly, Bootstrap
- **Mobile**: .NET MAUI (iOS, Android, Windows, macOS)
- **Authentication**: ASP.NET Identity, JWT tokens
- **Database**: SQL Server (LocalDB for development)
- **Testing**: xUnit, Entity Framework InMemory

## 📋 Next Steps

The project structure and basic files have been created. Here's what you should do next:

### 1. Set Up Development Environment
- Install .NET 8 SDK
- Install Visual Studio 2022 or VS Code with C# extensions
- Install SQL Server or SQL Server Express

### 2. Initialize the Database
- Run Entity Framework migrations
- Seed initial data (roles, admin user)

### 3. Implement Core Features
- Complete authentication system
- Implement blog post CRUD operations
- Add comment functionality
- Integrate Markdown rendering

### 4. Add Advanced Features
- Image upload service
- Tag management
- User roles and permissions
- Search functionality

### 5. Testing and Deployment
- Write comprehensive tests
- Set up CI/CD pipeline
- Deploy to cloud platform

## 🔧 Development Commands

```bash
# Restore packages
dotnet restore

# Build solution
dotnet build

# Run API
cd backend/BlogPlatform.Api
dotnet run

# Run Blazor Web App
cd web/BlogPlatform.Web
dotnet run

# Run tests
cd tests/BlogPlatform.Tests
dotnet test
```

## 📝 License

This project is licensed under the MIT License.
