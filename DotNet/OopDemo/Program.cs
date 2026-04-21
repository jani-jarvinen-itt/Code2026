Console.WriteLine("Hello, World!");

Car myCar = new()
{
    // Make = "Toyota",
    Model = "Corolla"
};

myCar.Accelerate(20);
Console.WriteLine($"Current Speed: {myCar.CurrentSpeed} km/h");
