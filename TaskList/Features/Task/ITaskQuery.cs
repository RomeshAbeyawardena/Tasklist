using RST.Contracts;

namespace TaskList.Features.Task;

public interface ITaskQuery : IOrderByQuery
{
    Guid? Id { get; set; }
    Guid? ProjectId { get; set; }
    Guid? ClientId { get; set; }
}
