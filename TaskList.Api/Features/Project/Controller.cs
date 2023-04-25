using Microsoft.AspNetCore.Mvc;
using RST.Contracts;
using TaskList.Features.Project;

namespace TaskList.Api.Features.Project;

[Route("api/project")]
public class Controller : RST.AspNetCore.Extensions.ApiController
{
    public Controller(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    [HttpGet]
    public Task<IPagedResult<Models.Project>> GetClients([FromQuery] GetPagedQuery query, CancellationToken cancellationToken)
    {
        return Mediator.Send(query, cancellationToken);
    }

    [HttpPost]
    public Task<Models.Project> SaveClient([FromForm] PostRequest query, CancellationToken cancellationToken)
    {
        return Mediator.Send(query, cancellationToken);
    }

    [HttpPut, Route("{projectId}")]
    public Task<Models.Project> SaveClient([FromRoute] Guid projectId, [FromForm] PutRequest query, CancellationToken cancellationToken)
    {
        query.Id = projectId;
        return Mediator.Send(query, cancellationToken);
    }

    [HttpDelete, Route("{projectId}")]
    public System.Threading.Tasks.Task DeleteClient([FromRoute] DeleteRequest request, CancellationToken cancellationToken)
    {
        return Mediator.Send(request, cancellationToken);
    }
}