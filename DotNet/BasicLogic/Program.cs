List<int> numbers = new();

int number;
do
{
    Console.WriteLine("Please enter a number (or zero to stop):");
    string input = Console.ReadLine() ?? "0"; // Default to "0" if input is null
    number = int.Parse(input);

    if (number != 0)
    {
        numbers.Add(number);
    }
}
while (number != 0);

int sum = numbers.Sum();
Console.WriteLine($"The sum of the entered numbers is: {sum}");

double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
Console.WriteLine($"The average of the entered numbers is: {average}");
