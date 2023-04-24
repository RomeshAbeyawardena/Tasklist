﻿using MediatR;
using RST.Contracts;
using RST.Enumerations;
using TaskList.Features.Project;

namespace TaskList.Persistence.Features.Project;

public record GetQuery : IProjectQuery, IOrderByQuery, IRequest<IEnumerable<Models.Project>>
{
    public Guid? ClientId { get; set; }
    public string? Name { get; set; }
    public bool? IsArchived { get; set; }
    public IEnumerable<string>? OrderByFields { get; set; }
    public SortOrder? SortOrder { get; set; }
    public bool? NoTracking { get; set; }
}
