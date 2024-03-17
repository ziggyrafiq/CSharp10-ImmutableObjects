//The File name is Person.cs inside Models folder
namespace CSharp10_ImmutableObjects.Models;

/// <summary>
/// Represents a Person with read-only properties for first and last name.
/// </summary>
public class Person
{
    /// <summary>
    /// Gets the first name of the person.
    /// </summary>
    public string FirstName { get; init; }

    /// <summary>
    /// Gets the last name of the person.
    /// </summary>
    public string LastName { get; init; }

    /// <summary>
    /// Gets the date of birth of the person.
    /// </summary>
    public DateTime DateOfBirth { get; init; }

    /// <summary>
    /// Gets the email of the person.
    /// </summary>
    public string Email { get; init; }

    /// <summary>
    /// Gets the phone number of the person.
    /// </summary>
    public string Phone { get; init; }

    /// <summary>
    /// Gets the address of the person.
    /// </summary>
    public Address Address { get; init; }

    /// <summary>
    /// Gets the orders of the person.
    /// </summary>
    public List<Order> Orders { get; init; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Person"/> class with the specified first and last name.
    /// </summary>
    /// <param name="firstName">The first name of the person.</param>
    /// <param name="lastName">The last name of the person.</param>
    /// <param name="dateOfBirth">The date of birth of the person.</param>
    /// <param name="email">The email of the person.</param>
    /// <param name="phone">The phone number of the person.</param>
    /// <param name="address">The address of the person.</param>
    /// <param name="orders">The orders of the person.</param>
    public Person(string firstName, string lastName, DateTime dateOfBirth, string email, string phone, Address address, List<Order> orders)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Email = email;
        Phone = phone;
        Address = address;
        Orders = orders;
    }

    /// <summary>
    /// Person Name is returned
    /// </summary>
    /// <returns>First Name and Last Name returned</returns>
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

}
