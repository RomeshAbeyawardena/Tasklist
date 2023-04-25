using RST.Contracts;

namespace TaskList.Features.Client;

public interface IClientQuery : IOrderByQuery
{
    Guid? Id { get; set; }
    string? Name { get; set; }
    bool? IsArchived { get; set; }
}
