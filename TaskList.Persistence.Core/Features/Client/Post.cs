using AutoMapper;
using Microsoft.AspNetCore.Components;
using RST.Mediatr.Extensions;
using TaskList.Persistence.Features.Client;

namespace TaskList.Persistence.Core.Features.Client;

public class Post : RepositoryHandlerBase<PostRequest, Models.Client>
{
    [Inject]
    private IMapper? Mapper { get; set; }
    public Post(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<Models.Client> Handle(PostRequest request, CancellationToken cancellationToken)
    {
        return ProcessSave(request, Mapper!.Map<Models.Client>, cancellationToken);
    }
}
