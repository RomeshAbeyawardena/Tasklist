var builder = WebApplication.CreateBuilder(args);
var app = new TaskList.Web.App("", args);
await app.RunAsync(CancellationToken.None);