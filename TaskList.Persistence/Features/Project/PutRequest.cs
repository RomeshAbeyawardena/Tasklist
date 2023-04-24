using MediatR;
using RST.Contracts;
using TaskList.Models;

namespace TaskList.Persistence.Features.Project;

public record PutRequest : IProject, IDbCommand, IRequest<Models.Project>
{
    public Guid Id { get; set; }
    public bool CommitChanges { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
    public bool IsArchived { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public string? Hash { get; set; }
    public Guid ClientId { get; set; }
    public string? Code { get; set; }
}
