var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireRetryApp_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.AspireRetryApp_WebApp>("webapp-frontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
