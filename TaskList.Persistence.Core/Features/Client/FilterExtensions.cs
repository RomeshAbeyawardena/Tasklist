﻿using LinqKit;
using TaskList.Features.Client;

namespace TaskList.Persistence.Core.Features.Client;

public static class FilterExtensions
{
    public static ExpressionStarter<Models.Client> Filter(this ExpressionStarter<Models.Client> clientExpression, IClientQuery query)
    {
        if (query.Id.HasValue)
        {
            clientExpression.And(c => c.Id == query.Id);
        }


        return clientExpression;
    }
}
