using Application;
using Infra.Data;
using Infra.Email;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDataBaseInMemory();
builder.Services.AddEmailService();
builder.Services.ApplicationService();


var app = builder.Build();

app.MapOpenApi();
app.UseSwaggerUI(op =>
{
    op.SwaggerEndpoint("/openapi/v1.json", "HexagonalArch Api");
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

