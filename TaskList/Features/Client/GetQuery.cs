using MediatR;

namespace TaskList.Features.Client;

public record GetQuery : IClientQuery, IRequest<IEnumerable<Models.Client>>
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public bool? IsArchived { get; set; }
}
