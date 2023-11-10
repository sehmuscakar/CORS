using CORS;
using CORS.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(opt => //Microsoft.AspNetCore.Mvc.NewtonsoftJson bu k�t�phaneyi eklemen laz�m cors i�in
{
    opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; // program.cs teki configrasyonumuz tamam b�ylece
});

builder.Services.AddScoped<GetStudentByIdQueryHandler>();//dependix enjekj�n kulland���m i�in 
builder.Services.AddDbContext<StudentContext>(opt =>
{
    opt.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=CORSDb; integrated security=true; TrustServerCertificate=true");
});
var app = builder.Build();

app.MapGet("/", () => "Hello World!");



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
