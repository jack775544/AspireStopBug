var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireStopBug_ApiService>("apiservice");

builder.AddProject<Projects.AspireStopBug_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.AddNpmApp("testing", "../TestNodeApp", "dev")
    .WithHttpEndpoint(targetPort: 3000);

builder.Build().Run();
