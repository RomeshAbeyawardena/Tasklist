using RST.Contracts;
using TaskList.Models;

namespace TaskList.Persistence.Models;

public class Client : IClient, IIdentity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
    public bool IsArchived { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public string? Hash { get; set; }
}
