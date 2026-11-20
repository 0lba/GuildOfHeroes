public class Library
{
    public string Name { get; private set; }
    public List<Game> Games { get; private set; } = new List<Game>();

    public Library(string name)
    {
        Name = name;
    }
}