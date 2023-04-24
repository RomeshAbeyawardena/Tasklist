using RST.Contracts;
using RST.Mediatr.Extensions;
using TaskList.Persistence.Features.Project;

namespace TaskList.Persistence.Core.Features.Project;

public class GetPaged : PagedRepositoryHandlerBase<GetPagedQuery, Models.Project>
{
    public GetPaged(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IPagedResult<Models.Project>> Handle(GetPagedQuery request, CancellationToken cancellationToken)
    {
        return base.ProcessPagedQuery(Repository!.QueryBuilder, request, cancellationToken);
    }
}
