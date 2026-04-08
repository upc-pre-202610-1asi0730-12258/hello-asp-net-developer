namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

/// <summary>
/// Represents a Developer entity in the 'Generic' bounded context.
/// This class encapsulates the properties and behaviors associated with a developer,
/// including their first name, last name, and a unique identifier.
/// It also provides methods to retrieve the full name and check for empty name fields.
/// </summary>
/// <param name="firstName">The developer's first name.</param>
/// <param name="lastName">The developer's last name.</param>
public class Developer(string firstName, string lastName)
{
    /// <summary>
    /// Returns the full name of the developer by concatenating the first name and last name.
    /// </summary>
    /// <returns>A string representing the full name of the developer.</returns>
    
    public string GetFullName() => $"{FirstName} {LastName}";
    
    /// <summary>
    /// Checks if either the first name or last name of the developer is empty or null.
    /// </summary>
    /// <returns>True if either the first name or last name is empty or null; otherwise, false.</returns>
    public bool IsAnyNameEmpty() => string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);
    
    
    public Guid Id { get; } = Guid.NewGuid();
    public string FirstName { get;} = string.IsNullOrWhiteSpace(firstName) ? string.Empty : firstName.Trim();
    public string LastName { get;} = string.IsNullOrWhiteSpace(lastName) ? string.Empty : lastName.Trim();
}