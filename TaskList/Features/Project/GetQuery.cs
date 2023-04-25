using MediatR;
using RST.Enumerations;
using TaskList.Features.Client;

namespace TaskList.Features.Project;

public record GetQuery : IProjectQuery, IRequest<IEnumerable<Models.Project>>
{
    public Guid? ClientId { get; set; }
    public string? Name { get; set; }
    public bool? IsArchived { get; set; }
    public Guid? Id { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
