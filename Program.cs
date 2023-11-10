
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ToDoGrpc.Data;
using ToDoGrpc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlite("Data Source =ToDoDatabase.db"));

// Add services to the container.
builder.Services.AddGrpc().AddJsonTranscoding(); // Json Transcoding added.
builder.Services.AddGrpcSwagger();

//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
               options =>
               {
                   options.SwaggerDoc("v1", new OpenApiInfo
                   {
                       Version = "v1",
                       Title = "gRPC Transcoding",
                       Description = " a gRPC service with 5 methods: Create, Read (single), List (multiple), Update and Delete. We then employ JSON transcoding (a new feature added in .NET 7) to allow our gRPC service to act as a REST based API. This allows web-based endpoints to consume our service, while at the same time continuing to allow native gRPC clients to consume as well. ",
                       Contact = new OpenApiContact
                       {
                           Name = "Linkedin Contact",
                           Url = new Uri("https://www.linkedin.com/in/sit-bulu/")
                       }

                   });
               }

               );
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<ToDoService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
