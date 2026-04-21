public class Car
{
    // properties
    public string Make { get; init; }
    public string Model { get; init; }
    public int CurrentSpeed { get; set; }
    public bool EngineRunning { get; set; }

    // methods
    public void StartEngine()
    {
        EngineRunning = true;
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        EngineRunning = false;
        Console.WriteLine("Engine stopped.");
    }

    public void Accelerate(int speedIncrease)
    {
        if (EngineRunning)
        {
            CurrentSpeed += speedIncrease;
            // Console.WriteLine($"Accelerated to {CurrentSpeed} km/h.");
        }
        else
        {
            throw new InvalidOperationException("Can't accelerate. Engine is not running.");
        }
    }

    public void Decelerate(int speedDecrease)
    {
        if (EngineRunning)
        {
            CurrentSpeed = Math.Max(0, CurrentSpeed - speedDecrease);
            Console.WriteLine($"Decelerated to {CurrentSpeed} km/h.");
        }
        else
        {
            Console.WriteLine("Can't brake. Engine is not running.");
        }
    }
}
