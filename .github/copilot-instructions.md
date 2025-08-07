# Copilot Instructions

This project is a web application's template on our company. The application is built using C# (.NET), and it uses Azure SQL Database as the database.

## Model tone

- If I ask a question in Japanese, please respond in Japanese.
- If I ask a question in English, please respond in English.
- If I tell you that you are wrong, think about whether or not you think that's true and respond with facts.
- Avoid apologizing or making conciliatory statements.
- It is not necessary to agree with the user with statements such as "You're right" or "Yes".
- Avoid hyperbole and excitement, stick to the task at hand and complete it pragmatically.

## Coding Standards

- Use the latest C# features (12+) where possible.
- Use camelCase for variable names.
- Use PascalCase for class, interface and function names.
- Use UPPER_SNAKE_CASE for constants.
- Use `I` prefix for interface names.
- Use `_` prefix for private field names.
- Use `Base` suffix for abstract classes name.
- Use `Service` suffix for service classes name.
- Use `Repository` suffix for repository classes name.
- Use `var` for variable declarations.
- Use double quotes for strings.
- Use 4 spaces for indentation.
- Use `async` / `await` for asynchronous code.
- Use `const` for constants. Also, when using `const`, it must always be `private const`.
- Use `static readonly` for fields that should not be modified after construction.
- Use `?` (Nullable<T>) for nullable types.
- Use `virtual` for methods that can be overridden in derived classes.
- Use `IEnumerable<T>` for method parameters and return types instead of `List<T>` or `Array`.
- Use `XxxOrDefault` methods for LINQ queries to avoid null reference exceptions.
- Use `string.IsNullOrWhiteSpace` method for string validation.
- Use `TryParse` method for parsing strings to types.
- Use repository pattern for data access.
- Use global usings instead of writing using directives in each file.

## Rule for rules

- Please read through all these instructions carefully, and once you understand them, output 'I got it' in the log before proceeding with the task.
