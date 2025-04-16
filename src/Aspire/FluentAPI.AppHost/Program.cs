var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.FluentAPI_Web_UI>("fluentapi-web-ui");

builder.AddProject<Projects.FluentApi_DemoApi>("fluentapi-demoapi");

builder.Build().Run();
