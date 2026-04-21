namespace AspNetWebApiDemo1.Models
{
    public record Person
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string Birthday { get; init; } = "";
    }
}
