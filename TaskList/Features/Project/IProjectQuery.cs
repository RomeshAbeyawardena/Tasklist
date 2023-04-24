namespace TaskList.Features.Project;

public interface IProjectQuery
{
    Guid? ClientId { get; set; }
    string? Name { get; set; }
    bool? IsArchived { get; set; }
}
