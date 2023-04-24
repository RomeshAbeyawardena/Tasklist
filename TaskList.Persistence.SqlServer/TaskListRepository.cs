using LinqKit;
using System.Reactive.Subjects;

namespace TaskList.Persistence.SqlServer;
public class TaskListRepository<T> : RST.EntityFrameworkCore.EntityFrameworkRepositoryBase<TaskListDbContext, T>
where T : class
{
    public TaskListRepository(TaskListDbContext context, ISubject<ExpressionStarter<T>> subject) : base(context, subject)
    {
    }
}
