using RST.Contracts;
using RST.Mediatr.Extensions;
using TaskList.Persistence.Features.Client;

namespace TaskList.Persistence.Core.Features.Client;

public class GetPaged : PagedRepositoryHandlerBase<GetPagedQuery, Models.Client>
{
    public GetPaged(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IPagedResult<Models.Client>> Handle(GetPagedQuery request, CancellationToken cancellationToken)
    {
        return base.ProcessPagedQuery(Repository!.QueryBuilder, request, cancellationToken);
    }
}
