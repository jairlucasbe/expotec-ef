using System.Text.Json.Serialization;
using expotec_ef.Data;
using expotec_ef.Modules.BusinessExecutives.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IBusinessExecutiveService, BusinessExecutiveService>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

////codigo agregado
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
//    new MySqlServerVersion(new Version(8, 0, 40))));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
                     ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySqlConnection"))));

//fin de codigo agregado    

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
