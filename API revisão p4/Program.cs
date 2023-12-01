using AIRev.Application.AutoMapper;
using AIRev.Application.Services;
using APIRev.Application.Interfaces;
using APIRev.Data.AutoMapper;
using APIRev.Data.Provider.MongoDB.Configuration;
using APIRev.Data.Provider.MongoDB.Interfaces;
using APIRev.Data.Repositories;
using APIRev.Domain.Interfaces;
using H1Store.Catalogo.Data.Providers.MongoDb;
using H1Store.Catalogo.Data.Providers.MongoDb.Interfaces;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoSettings"));

builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider =>
       serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

builder.Services.AddAutoMapper(typeof(DomainToViewModel), typeof(ViewModelToDomain));
builder.Services.AddAutoMapper(typeof(CollectionToDomain), typeof(DomainToCollection));

builder.Services.AddScoped<ICartaService, CartaService>();
builder.Services.AddScoped<ICartaRepository, CartaRepository>();

builder.Services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
