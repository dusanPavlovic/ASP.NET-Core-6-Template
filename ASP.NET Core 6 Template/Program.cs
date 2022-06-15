using ASP.NET_Core_6_Template;

//var builder = WebApplication.CreateBuilder(args)
//             .RegisterServices();

//var app = builder.Build()
//        .SetupMiddleware();

//app.Run();

WebApplication.CreateBuilder(args)
    .RegisterServices()
    .Build()
    .SetupMiddleware()
    .Run();