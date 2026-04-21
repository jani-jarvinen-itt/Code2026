using AspNetWebApiDemo1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiDemo1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        public List<Person> GetPersonsFromCsvFile()
        {
            List<Person> persons = [];
            string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Persons.csv");
            if (!System.IO.File.Exists(csvFilePath))
            {
                return persons; // Return an empty list if the file doesn't exist
            }

            string[] lines = System.IO.File.ReadAllLines(csvFilePath);
            foreach (string? line in lines.Skip(1)) // Skip header line
            {
                string[] fields = line.Split(',');
                if (fields.Length >= 3)
                {
                    if (int.TryParse(fields[0], out int id))
                    {
                        Person person = new()
                        {
                            Id = id,
                            Name = fields[1],
                            Birthday = fields[2]
                        };
                        persons.Add(person);
                    }
                }
            }

            return persons;
        }
    }
}
