//The File name is public class Address.cs inside Models folder
namespace CSharp10_ImmutableObjects.Models;
public class Address
{
    public Guid AddressID { get; init; }
    public string Street { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string ZipCode { get; init; }

    public Address(Guid addressID, string street, string city, string state, string zipCode)
    {
        AddressID = addressID;
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
}
