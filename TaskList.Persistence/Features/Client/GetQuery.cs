using MediatR;
using RST.Contracts;
using RST.Enumerations;
using TaskList.Features.Client;

namespace TaskList.Persistence.Features.Client;

public record GetQuery : IClientQuery, IOrderByQuery, IRequest<IEnumerable<Models.Client>>
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public bool? IsArchived { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
