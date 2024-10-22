var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Basket_Api>("basket-api");

builder.AddProject<Projects.Discount_Grpc>("discount-grpc");

builder.Build().Run();