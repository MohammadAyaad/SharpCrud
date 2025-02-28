<img src="logo.png" alt="Logo" width="400" style="display:block; margin:auto;">
<hr>

# SharpCrud

SharpCrud is a .NET library designed to standardize CRUD (Create, Read, Update, Delete) operations through interfaces, promoting clean architecture and separation of concerns. It provides both synchronous and asynchronous interfaces for single and bulk operations, making it easy to implement consistent data access patterns.

## Features

- **Action Interfaces**: Base interfaces for individual CRUD operations.
  - `ICreate`, `IRead`, `IUpdate`, `IDelete`
  - Async variants (`ICreateAsync`, `IReadAsync`, etc.).
  - Bulk operation support (`ICreateMany`, `IReadMany`, etc.) and their async counterparts.
- **CRUD Aggregates**: Unified interfaces combining actions:
  - `ICrud`: Standard CRUD operations.
  - `ICrudAsync`: Async CRUD operations.
  - `ICrudMany` and `ICrudManyAsync`: Bulk operations with sync/async support.
- **Flexibility**: Decouple your business logic from data access implementations.
- **Async Ready**: Built for modern applications with `Task`-based async patterns.

## Installation

```bash
dotnet add package SharpCrud
```

## Usage

### Implementing Action Interfaces

```csharp
// Example: Sync Create operation
public class UserCreator : ICreate<User, UserInput>
{
    public User Create(UserInput input)
    {
        // Your implementation here
    }
}

// Example: Async Read operation
public class UserReader : IReadAsync<User, UserQuery>
{
    public async Task<User?> ReadAsync(UserQuery query)
    {
        // Your async implementation here
    }
}
```

### Using CRUD Aggregates

```csharp
// Implement ICrud for a User entity
public class UserCrud : ICrud<User, UserInput, User, int, User, int, UserInput, int>
{
    public User Create(UserInput input) => /* ... */;
    public User? Read(int id) => /* ... */;
    public User Update(int id, UserInput input) => /* ... */;
    public void Delete(int id) => /* ... */;
}

// Async version
public class UserCrudAsync : ICrudAsync<User, UserInput, User, int, User, int, UserInput, int>
{
    public Task<User> CreateAsync(UserInput input) => /* ... */;
    public Task<User?> ReadAsync(int id) => /* ... */;
    public Task<User> UpdateAsync(int id, UserInput input) => /* ... */;
    public Task DeleteAsync(int id) => /* ... */;
}
```

## Interfaces Overview

### Action Interfaces

| Interface                 | Description                          |
|---------------------------|--------------------------------------|
| `ICreate<TEntity, TInput>` | Creates an entity from input.        |
| `IRead<TEntity, TQuery>`   | Retrieves a single entity by query.  |
| `IUpdate<TEntity, TQuery, TInput>` | Updates an entity by query and input. |
| `IDelete<TQuery>`          | Deletes an entity by query.          |

Async versions append `Async` to the name (e.g., `CreateAsync(...)`, `ICreateAsync`). Bulk interfaces (e.g., `CreateMany(...)`,`ICreateMany`). for Async bulk interfaces append `ManyAsync` to the name.

### CRUD Aggregates

- **`ICrud`**: Combines `ICreate`, `IRead`, `IUpdate`, `IDelete`.
- **`ICrudAsync`**: Async variant of `ICrud`.
- **`ICrudMany`**: Bulk operations (`CreateMany`, `ReadMany`, etc.).
- **`ICrudManyAsync`**: Async bulk operations.

## Contributing

Contributions are welcome! Feel free to submit issues, feature requests, or pull requests to the `development` branch. Please follow the project's coding standards and include tests where applicable.

## License

Licensed under the **Apache License 2.0**. See [LICENSE](LICENSE) for details.

## Author

**Mohammad Ayaad**  
GitHub: [@mohammadayaad](https://github.com/mohammadayaad)