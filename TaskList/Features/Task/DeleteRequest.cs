using MediatR;

namespace TaskList.Features.Task;

public record DeleteRequest : IRequest
{
    public Guid Id { get; set; }
}
