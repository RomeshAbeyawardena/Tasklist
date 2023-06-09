﻿using Microsoft.AspNetCore.Mvc;
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

    [HttpPost]
    public Task<Models.Client> SaveClient([FromForm] PostRequest query, CancellationToken cancellationToken)
    {
        return Mediator.Send(query, cancellationToken);
    }

    [HttpPut, Route("{clientId}")]
    public Task<Models.Client> SaveClient([FromRoute]Guid clientId, [FromForm] PutRequest query, CancellationToken cancellationToken)
    {
        query.Id = clientId;
        return Mediator.Send(query, cancellationToken);
    }

    [HttpDelete, Route("{clientId}")]
    public System.Threading.Tasks.Task DeleteClient([FromRoute] DeleteRequest request, CancellationToken cancellationToken)
    {
        return Mediator.Send(request, cancellationToken);
    }
}