using TaskList.Persistence.Features.Project;

namespace TaskList.Persistence.Core.Features.Project;

public class Get : RST.Mediatr.Extensions.RepositoryHandlerBase<GetQuery, IEnumerable<Models.Project>, Models.Project>
{
    public Get(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.Project>> Handle(GetQuery request, CancellationToken cancellationToken)
    {
        return this.ProcessOrderableQuery(Repository!.QueryBuilder.Filter(request), request, cancellationToken);
    }
}
