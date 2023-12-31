using basic_graphQL_api.API.GraphQL;
using basic_graphQL_api.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped<IEmployeeRepo, EmployeeRepository>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<EmployeeQueryType>()
    .AddErrorFilter(error => new Error(error.Exception.InnerException?.Message ?? error.Exception.Message));



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGraphQL();  

app.Run();