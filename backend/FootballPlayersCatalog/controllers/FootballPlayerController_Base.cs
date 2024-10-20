using FootballPlayersCatalog.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace FootballPlayersCatalog.controllers;

[ApiController]
[Route("player")]
public partial class FootballPlayerController
    : ControllerBase
{   
    private readonly CatalogDbContext _dbContext;
    private readonly IMapper _mapper;

    public FootballPlayerController(CatalogDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
}