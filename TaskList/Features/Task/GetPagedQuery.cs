using MediatR;
using RST.Contracts;
using RST.Enumerations;

namespace TaskList.Features.Task;

public record GetPagedQuery : ITaskQuery, IPagedRequest<Models.Task>
{
    public Guid? Id { get; set; }
    public Guid? ProjectId { get; set; }
    public Guid? ClientId { get; set; }
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
