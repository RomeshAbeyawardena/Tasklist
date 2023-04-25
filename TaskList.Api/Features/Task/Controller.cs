using Microsoft.AspNetCore.Mvc;
using RST.Contracts;
using TaskList.Features.Task;

namespace TaskList.Api.Features.Task;

[Route("api/task")]
public class Controller : RST.AspNetCore.Extensions.ApiController
{
    public Controller(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    [HttpGet]
    public Task<IPagedResult<Models.Task>> GetClients([FromQuery]GetPagedQuery query, CancellationToken cancellationToken)
    {
        return Mediator.Send(query, cancellationToken);
    }

    [HttpPost]
    public Task<Models.Task> SaveClient([FromForm] PostRequest query, CancellationToken cancellationToken)
    {
        return Mediator.Send(query, cancellationToken);
    }

    [HttpPut, Route("{taskId}")]
    public Task<Models.Task> SaveClient([FromRoute]Guid taskId, [FromForm] PutRequest query, CancellationToken cancellationToken)
    {
        query.Id = taskId;
        return Mediator.Send(query, cancellationToken);
    }

    [HttpDelete, Route("{taskId}")]
    public System.Threading.Tasks.Task DeleteClient([FromRoute] DeleteRequest request, CancellationToken cancellationToken)
    {
        return Mediator.Send(request, cancellationToken);
    }
}