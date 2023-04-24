using MediatR;
using RST.Contracts;
using RST.Enumerations;
using TaskList.Features.Client;

namespace TaskList.Features.Project;

public record GetPagedQuery : IProjectQuery, IPagedRequest<Models.Project>
{
    public Guid? ClientId { get; set; }
    public string? Name { get; set; }
    public bool? IsArchived { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
    public int? PageIndex { get; set; }
    public int? TotalItemsPerPage { get; set; }
}
