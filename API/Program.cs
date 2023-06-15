using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options=>
{
    options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();


app.MapControllers();

app.Run();
