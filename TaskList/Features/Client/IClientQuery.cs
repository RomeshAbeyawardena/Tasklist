namespace TaskList.Features.Client;

public interface IClientQuery
{
    Guid? Id { get; set; }
    string? Name { get; set; }
    bool? IsArchived { get; set; }
}
