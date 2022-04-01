using Project_Agence_Voyage.Managers.Manager_Adress;
using Project_Agence_Voyage.Managers.Manager_Client;
using Project_Agence_Voyage.Managers.Manager_Hotel;
using Project_Agence_Voyage.Managers.Manager_Voiture;
using Project_Agence_Voyage.Managers.Manager_Vol;
using Project_Agence_Voyage.Services.Services_Adress;
using Project_Agence_Voyage.Services.Services_Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IService_Adress, Service_Adress>();
builder.Services.AddScoped<IManager_Adress, Manager_Adress>();

builder.Services.AddScoped<IService_Client, Service_Client>();
builder.Services.AddScoped<IManager_Client, Manager_Client>();

builder.Services.AddScoped<IManager_Vol, Manager_Vol>();
builder.Services.AddScoped<IManager_Voiture, Manager_Voiture>();
builder.Services.AddScoped<IManager_Hotel, Manager_Hotel>();




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
