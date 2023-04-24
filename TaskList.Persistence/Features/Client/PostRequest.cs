using MediatR;
using RST.Contracts;
using TaskList.Models;

namespace TaskList.Persistence.Features.Client;

public record PostRequest : IClient, IDbCommand, IRequest<Models.Client>
{
    public bool CommitChanges { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
    public bool IsArchived { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public string? Hash { get; set; }
}
