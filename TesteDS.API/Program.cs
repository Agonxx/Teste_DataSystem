using TesteDS.API.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.SetupDatabase(builder.Configuration);
builder.Services.SetupServices();
builder.Services.SetupSwagger();
builder.Services.SetupCORS();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllOrigins");
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseMiddleware<CustomMiddleware>();
app.MapControllers();
app.Run();
