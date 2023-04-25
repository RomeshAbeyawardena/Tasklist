namespace TaskList.Models;

public record Task : ITask
{
    public Guid? ProjectId { get; set; }
    public string? Notes { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public string? Hash { get; set; }
}
