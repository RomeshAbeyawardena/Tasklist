namespace TaskList;

public record ApplicationSettings
{
    public ApplicationSettings()
    {
        ConnectionStrings = new Dictionary<string, string>();
    }
    public IDictionary<string, string> ConnectionStrings { get; set; }
}
