using Microsoft.AspNetCore.Mvc;
using RST.Contracts;
using TaskList.Features.Client;

namespace TaskList.Api.Features.Client;

[Route("api/client")]
public class Controller : RST.AspNetCore.Extensions.ApiController
{
    public Controller(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    [HttpGet]
    public Task<IPagedResult<Models.Client>> GetClients([FromQuery]GetPagedQuery query, CancellationToken cancellationToken)
    {
        return Mediator.Send(query, cancellationToken);
    }

}