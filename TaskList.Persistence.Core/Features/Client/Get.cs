
using TaskList.Persistence.Features.Client;

namespace TaskList.Persistence.Core.Features.Client;

public class Get : RST.Mediatr.Extensions.RepositoryHandlerBase<GetQuery, IEnumerable<Models.Client>, Models.Client>
{
    public Get(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    public override Task<IEnumerable<Models.Client>> Handle(GetQuery request, CancellationToken cancellationToken)
    {
        return this.ProcessOrderableQuery(Repository!.QueryBuilder.Filter(request), request, cancellationToken);
    }
}
