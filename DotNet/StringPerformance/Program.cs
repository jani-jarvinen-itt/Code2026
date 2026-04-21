using System.Text;

Console.WriteLine("Starting to create string...");
const int Iterations = 50_000_000;

DateTime start = DateTime.Now;
StringBuilder s = new();
for (int i = 0; i < Iterations; i++)
{
    s.Append('a');
}
string result = s.ToString();
DateTime end = DateTime.Now;
Console.WriteLine($"Finished creating string. Length: {result.Length}");

/*
DateTime start = DateTime.Now;
string s = "";
for (int i = 0; i < Iterations; i++)
{
    s += "a"; // s = s + "a" -> creates a new string every time, which is inefficient
}
DateTime end = DateTime.Now;
*/

TimeSpan duration = end - start;
Console.WriteLine($"Finished creating string. Duration: {duration.TotalSeconds} seconds.");
