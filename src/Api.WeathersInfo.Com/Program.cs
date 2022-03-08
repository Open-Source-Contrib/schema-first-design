using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Model.WeathersInfo.Com;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<JsonOptions>(o=>{
    var enumConverter = new JsonStringEnumConverter();
    o.JsonSerializerOptions.Converters.Add(enumConverter);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("Local", builder =>
    {
        builder.WithOrigins("http://localhost:3000");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors("Local");
var sampleData = new WeatherInfo { Id = 1, CityName = "New York", LowTemp = 12.4m, HighTemp = 16.7m, WindDirection = WeatherInfo.WindDirectionEnum.SE, WindSpeed = 62.4m, Atmoshphere = WeatherInfo.AtmoshphereEnum.Rain };

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/cities/{cityName}", ([FromRoute] string cityName) =>
{
    return sampleData;
}).RequireCors("Local")
.WithName("getByCityName");

    endpoints.MapGet("/geos", ([FromQuery] decimal lat, [FromQuery] decimal lng) =>
    {
        return sampleData;
    }).RequireCors("Local")
    .WithName("getByLatLong");
});


app.Run();
