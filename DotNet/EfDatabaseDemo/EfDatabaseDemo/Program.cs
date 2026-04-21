using EfDatabaseDemo.Models;

Console.WriteLine("Starting to access database using EF...");

using NorthwindContext ctx = new();
var finnishCustomers = ctx.Customers.Where(c => c.Country == "Finland").ToList();

// display the customers from Finland
foreach (var f in finnishCustomers)
{
    Console.WriteLine($"Customer {f.CustomerId} is from {f.Country}.");
}
