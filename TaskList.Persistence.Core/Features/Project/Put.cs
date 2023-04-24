﻿using AutoMapper;
using Microsoft.AspNetCore.Components;
using RST.Mediatr.Extensions;
using TaskList.Persistence.Features.Project;

namespace TaskList.Persistence.Core.Features.Project;

public class Put : RepositoryHandlerBase<PostRequest, Models.Project>
{
    [Inject]
    private IMapper? Mapper { get; set; }
    public Put(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Project> Handle(PostRequest request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Project>, cancellationToken);
    }
}
