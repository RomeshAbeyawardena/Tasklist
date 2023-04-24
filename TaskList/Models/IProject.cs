using RST.Contracts;

namespace TaskList.Models;

public interface IProject : ICreated, IModified, IHashable
{
    Guid ClientId { get; set; }
    string? Code { get; set; }
    string? Name { get; set; }
    string? DisplayName { get; set; }
}
