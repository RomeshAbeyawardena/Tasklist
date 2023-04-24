using RST.Contracts;

namespace TaskList.Models;

public interface IClient : ICreated, IModified, IHashable
{
    string? Name { get; set; }
    string? DisplayName { get; set; }
    bool IsArchived { get; set; }
}
