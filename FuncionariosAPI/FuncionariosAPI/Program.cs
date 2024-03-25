using FuncionariosAPI.DataContext;
using FuncionariosAPI.Service.FuncionarioService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//quando eu fizer uma inje��o de dependencia do IFuncion�rioInterface
//eu quero usar os m�todos do funcion�rio service
builder.Services.AddScoped<IFuncionarioInterface, FuncionarioService>();

//Configurando para que ele acesse a conex�o com o banco de dados que eu criei
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
