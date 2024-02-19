using API_GerenciamentoGerenciamentoControle_Controle.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar a configura��o do aplicativo
builder.Configuration.AddJsonFile("appsettings.json", optional: false);

// Obter a string de conex�o do arquivo de configura��o
var connectionString = builder.Configuration.GetConnectionString("ConnectionDbContext");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adicionar o DbContext ao cont�iner
builder.Services.AddDbContext<GerenciamentoControleTesteContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
