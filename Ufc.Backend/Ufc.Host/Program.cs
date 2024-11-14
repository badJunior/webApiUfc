using Ufc.Host.Routes;
using UFC.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.RegisterServicesLayerDependencies();

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

app.RegisterFighterRoutes();
app.RegisterCardRoutes();
app.RegisterWinnerRoutes();
app.Run();