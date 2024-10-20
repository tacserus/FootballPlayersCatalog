using FootballPlayersCatalog.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FootballPlayersCatalog.controllers;

[ApiController]
[Route("player")]
public partial class FootballPlayerController
    : ControllerBase
{
    private readonly CatalogDbContext _dbContext;

    public FootballPlayerController(CatalogDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}