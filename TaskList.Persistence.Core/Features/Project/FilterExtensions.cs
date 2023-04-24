using LinqKit;
using TaskList.Features.Project;

namespace TaskList.Persistence.Core.Features.Project;

public static class FilterExtensions
{
    public static ExpressionStarter<Models.Project> Filter(this ExpressionStarter<Models.Project> clientExpression, IProjectQuery query)
    {
        return clientExpression;
    }
}
