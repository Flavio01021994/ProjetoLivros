using ProjetoLivros.Context;
using ProjetoLivros.Interfaces;
using ProjetoLivros.Repositores;

var builder = WebApplication.CreateBuilder(args);
// avisa que a aplicacao usa controllers
builder.Services.AddControllers();

// adiciono um gerador de swagger
builder.Services.AddSwaggerGen();


// dotnet ef migrations add inicial
// dotnet ef database update
builder.Services.AddDbContext<LivrosContext>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();

var app = builder.Build();
// Avisa o .NET que eu tenho controladores
app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(options =>
{

    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

});

app.Run();
