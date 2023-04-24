using System.Reflection;

var app = new TaskList.Web.App("config.json", args, Path.GetDirectoryName (Assembly.GetExecutingAssembly().Location));
await app.RunAsync(CancellationToken.None);