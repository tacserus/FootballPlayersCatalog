using System.Buffers;
using FootballPlayersCatalog;
using FootballPlayersCatalog.Entities;
using FootballPlayersCatalog.models;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CatalogDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers(options =>
    {
        options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true;
        
        options.OutputFormatters.Add(new
            XmlSerializerOutputFormatter());
        
        options.OutputFormatters.Insert(0, new
            NewtonsoftJsonOutputFormatter(new JsonSerializerSettings
            {
                ContractResolver = new
                    CamelCasePropertyNamesContractResolver()
            }, ArrayPool<char>.Shared, options));
    })
    .ConfigureApiBehaviorOptions(options => {
        options.SuppressModelStateInvalidFilter = true;
        options.SuppressMapClientErrors = true;
    })
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    });

builder.Services.AddAutoMapper(cfg =>
{
    cfg.CreateMap<CreatePlayerModel, FootballPlayer>();
    cfg.CreateMap<UpdatePlayerModel, FootballPlayer>();
}, new System.Reflection.Assembly[0]);


var app = builder.Build();

app.Run();