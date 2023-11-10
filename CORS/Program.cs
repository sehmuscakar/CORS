using CORS;
using CORS.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(opt => //Microsoft.AspNetCore.Mvc.NewtonsoftJson bu kütüphaneyi eklemen lazým cors için
{
    opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; // program.cs teki configrasyonumuz tamam böylece
});

builder.Services.AddScoped<GetStudentByIdQueryHandler>();//dependix enjekjýn kullandýðým için 
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
