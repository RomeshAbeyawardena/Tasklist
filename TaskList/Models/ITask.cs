using RST.Contracts;

namespace TaskList.Models;

public interface ITask : ICreated, IModified, IHashable
{
    Guid? ProjectId { get; set; }
    string? Notes { get; set; }
}
