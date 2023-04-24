using MediatR;
using TaskList.Features.Client;

namespace TaskList.Features.Project;

public record GetQuery : IProjectQuery, IRequest<IEnumerable<Models.Project>>
{
    public Guid? ClientId { get; set; }
    public string? Name { get; set; }
    public bool? IsArchived { get; set; }
    public Guid? Id { get; set; }
}
