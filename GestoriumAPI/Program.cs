using GestoriumAPI.Application.Services;
using GestoriumAPI.Configurations; // Adicionada a referÍncia correta
using GestoriumAPI.Infra;
using GestoriumAPI.Infra.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting; // Adicionada a referÍncia correta

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureApplicationApp();
builder.Services.ConfigureInfraApp(builder.Configuration); // Adicionada a chamada correta

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

CreateDatabase(app);

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void CreateDatabase(WebApplication app)
{
	using var serviceScope = app.Services.CreateScope();
	var dataContext = serviceScope.ServiceProvider.GetRequiredService<DataBaseContext>();
	dataContext.Database.EnsureCreated();
}