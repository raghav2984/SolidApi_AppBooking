using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
using src.Database;
using src.Repositories;
using src.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddDbContext<Appt_EF_DataContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("Appt_Db")));
builder.Services.AddApptDb(builder.Configuration);
builder.Services.AddTransient<IDoctorService, DoctorService>();
builder.Services.AddTransient<IDoctorRepository, DoctorRepo>();

builder.Services.AddTransient<IPatientService, PatientService>();
builder.Services.AddTransient<IPatientRepository, PatientRepo>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllers();   

app.Run();
