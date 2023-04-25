using MediatR;
using RST.Enumerations;

namespace TaskList.Features.Task;

public record GetQuery : ITaskQuery, IRequest<IEnumerable<Models.Task>>
{
    public Guid? Id { get; set; }
    public Guid? ProjectId { get; set; }
    public Guid? ClientId { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
