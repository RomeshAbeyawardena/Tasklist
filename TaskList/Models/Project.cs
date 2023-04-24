namespace TaskList.Models;

public record Project : IProject
{
    public Guid? Id { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public string? Hash { get; set; }
    public Guid ClientId { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
}
