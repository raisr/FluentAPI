var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.FluentAPI_Web_UI>("fluentapi-web-ui");

builder.Build().Run();
