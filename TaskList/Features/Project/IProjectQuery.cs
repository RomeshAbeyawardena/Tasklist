using RST.Contracts;

namespace TaskList.Features.Project;

public interface IProjectQuery : IOrderByQuery
{
    Guid? Id { get; set; }
    Guid? ClientId { get; set; }
    string? Name { get; set; }
    bool? IsArchived { get; set; }
}
