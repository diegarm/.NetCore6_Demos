using MediatR;
using VendingMachine.Services.Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Database
builder.Services.AddDatabaseConfiguration(builder.Configuration);


// AutoMapper
builder.Services.AddAutoMapperConfiguration();

// Swagger Config
builder.Services.AddSwaggerConfiguration();

// Adding MediatR
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

//DI
builder.Services.AddDependencyInjectionConfiguration();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//Swagger
app.UseSwaggerSetup();

app.Run();
