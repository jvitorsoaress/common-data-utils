# Common Data Utils 
Generic C# data access library for reusable persistence patterns

<!-- BADGES: https://shields.io/ -->

![.NET](https://img.shields.io/badge/.NET-8-blue)
![C#](https://img.shields.io/badge/C%23-Data%20Access-green)
![Entity Framework](https://img.shields.io/badge/ORM-Entity%20Framework-purple)
![Dapper](https://img.shields.io/badge/MicroORM-Dapper-orange)
![License](https://img.shields.io/github/license/jvitorsoaress/common-data-utils)
![Last Commit](https://img.shields.io/github/last-commit/jvitorsoaress/common-data-utils)


## Overview

**Common Data Utils** is a reusable C# class library designed to standardize data access patterns across multiple .NET applications.

This project provides reusable infrastructure components such as:

- Generic base entities  
- Repository abstractions  
- Entity Framework DbContext base classes  
- Dapper query support  
- Common persistence utilities  

The main goal is to **reduce duplication**, **increase maintainability**, and **enforce consistent data access practices** across enterprise applications.

Instead of rewriting repositories and persistence logic in every project, this library centralizes shared behaviors into reusable components.

---

### Context

This library is intended for environments where multiple services or applications share common persistence requirements.

Typical usage scenarios include:

- Enterprise backend services  
- Internal business systems  
- Microservices with shared persistence conventions  
- Legacy system modernization  
- Systems requiring both ORM and optimized SQL access  

It reflects real-world scenarios where **consistency**, **scalability**, and **maintainability** are critical.

---

### Architecture

This project follows a **modular and extensible architecture**, focusing on reuse and separation of concerns.

The library is structured into reusable components:

---

### Base Entities

Provides reusable base entity abstractions.

Examples:

- `BaseEntity`
- `AuditableEntity`
- `SoftDeleteEntity`

Common fields may include:

- `Id`
- `CreatedAt`
- `UpdatedAt`
- `DeletedAt`
- `IsActive`

These promote consistent entity modeling across projects.

---

### Repository Abstractions

Generic repository interfaces define common data access operations.

Examples:

- `IGenericRepository<TEntity>`
- `IReadRepository<TEntity>`
- `IWriteRepository<TEntity>`

Responsibilities include:

- Standard CRUD operations  
- Query abstraction  
- Async operations  
- Strong typing support  

Repositories are designed to be **extended**, not rewritten.

---

### Entity Framework Support

Provides reusable infrastructure built on Entity Framework Core.

Key components:

- `BaseDbContext`
- Generic repository implementations
- Entity configuration conventions
- Change tracking standardization
- Migration support

Entity Framework is primarily used for:

- Standard CRUD operations  
- Entity lifecycle management  
- Domain persistence  

---

### Dapper Support

Dapper is integrated for **performance-critical operations**.

Key components:

- `IDapperRepository`
- Query execution helpers
- Transaction handling
- Parameterized SQL execution

Typical use cases:

- Complex queries  
- Reporting queries  
- High-performance read operations  

This hybrid approach allows combining:

- Entity Framework → maintainability  
- Dapper → performance  

---

### Unit of Work (Optional)

If implemented, the library includes:

- `IUnitOfWork`
- Transaction coordination
- Centralized `SaveChanges` control

This helps ensure consistency across multiple operations.

---

### Key Design Decisions

### Generic Repository Pattern

Chosen to standardize persistence logic and reduce duplication.

**Trade-offs:**

- Adds abstraction layer  
- Improves consistency and maintainability  

---

### Entity Framework + Dapper Hybrid

Entity Framework is used for:

- Entity management  
- Domain persistence  
- Transactional operations  

Dapper is used for:

- Performance-sensitive queries  
- Direct SQL execution  
- Reporting scenarios  

This combination reflects **real-world enterprise practices**.

---

### Convention Over Configuration

Where possible, conventions are applied to:

- Entity configuration  
- Naming patterns  
- Repository behavior  

This reduces repetitive configuration and speeds development.

---

### Tech Stack

- .NET 8  
- C#  
- Entity Framework Core  
- Dapper  
- SQL Server  
- LINQ  
- Dependency Injection  
- Async/Await  
