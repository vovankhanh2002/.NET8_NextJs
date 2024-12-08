using BA_School.Infrastructure.DependencyInjection;
using BA_School.Application.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureService(builder.Configuration);
builder.Services.AddApplicationService();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()  // Cho ph�p m?i domain g?i y�u c?u
              .AllowAnyMethod()  // Cho ph�p m?i ph??ng th?c HTTP (GET, POST, PUT, DELETE, ...)
              .AllowAnyHeader(); // Cho ph�p m?i header
    });
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors("AllowAll");
app.MapControllers();

app.Run();
