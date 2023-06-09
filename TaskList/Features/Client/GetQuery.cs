﻿using MediatR;
using RST.Enumerations;

namespace TaskList.Features.Client;

public record GetQuery : IClientQuery, IRequest<IEnumerable<Models.Client>>
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public bool? IsArchived { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
