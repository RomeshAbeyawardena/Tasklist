using MediatR;
using RST.Contracts;
using TaskList.Models;

namespace TaskList.Features.Task;

public record PutRequest : ITask, IDbCommand, IRequest<Models.Task>
{
    public Guid Id { get; set; }
    public Guid? ProjectId { get; set; }
    public string? Notes { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Modified { get; set; }
    public string? Hash { get; set; }
    public bool CommitChanges { get; set; }
}
