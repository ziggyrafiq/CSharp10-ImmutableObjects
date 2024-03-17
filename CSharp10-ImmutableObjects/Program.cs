using CSharp10_ImmutableObjects.Models;
using System.Diagnostics;

Console.WriteLine("Hello, from Ziggy Rafiq!");

var address = new Address(Guid.NewGuid(), "123 Main St", "Anytown", "State", "12345");

var orders = new List<Order>
{
    new Order(Guid.NewGuid(), DateTime.Now, "Product1", 2, 20.00m),
    new Order(Guid.NewGuid(), DateTime.Now, "Product2", 1, 15.00m)
};

var person = new Person(
     
        
    firstName:"Lisa",
    lastName: "Smith",
    dateOfBirth:new DateTime(1980, 10, 10),
    email: "lisa@example.com",
    phone: "123-456-7890",
    address: address,
    orders: orders
);
Console.WriteLine(person.ToString());

Console.WriteLine($"Person: {person}");



// Check the C# version being used
Console.WriteLine($"C# Version: {Environment.Version}");

// Check for C# 10 compatibility
if (Environment.Version.Major >= 6) // C# 10 corresponds to .NET 6
{
    Console.WriteLine("Init-only properties are supported!");
}
else
{
    Console.WriteLine("Init-only properties may not be fully supported. Consider upgrading your C# compiler or runtime environment.");
}


const int numberOfIterations = 1000000;

Stopwatch stopwatch = new Stopwatch();

// Measure performance with traditional properties
stopwatch.Start();
for (int i = 0; i < numberOfIterations; i++)
{
    var person2 = new Person(


     firstName: "Lisa",
     lastName: "Smith",
     dateOfBirth: new DateTime(1980, 10, 10),
     email: "lisa@example.com",
     phone: "123-456-7890",
     address: address,
     orders: orders
 );
    // Perform some operations with the person object
}
stopwatch.Stop();
Console.WriteLine($"Time taken with traditional properties: {stopwatch.ElapsedMilliseconds} ms");

// Measure performance with init-only properties
stopwatch.Reset();
stopwatch.Start();
for (int i = 0; i < numberOfIterations; i++)
{
    var person3 = new Person(


     firstName: "Lisa",
     lastName: "Smith",
     dateOfBirth: new DateTime(1980, 10, 10),
     email: "lisa@example.com",
     phone: "123-456-7890",
     address: address,
     orders: orders
 );
    // Perform some operations with the person object
}
stopwatch.Stop();
Console.WriteLine($"Time taken with init-only properties: {stopwatch.ElapsedMilliseconds} ms");
