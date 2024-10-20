using FootballPlayersCatalog.Entities;
using FootballPlayersCatalog.models;
using Microsoft.AspNetCore.Mvc;

namespace FootballPlayersCatalog.controllers;

public partial class FootballPlayerController
{
    [HttpPost]
    [Route("create")]
    public IActionResult Create(CreatePlayerModel createPlayerModel)
    {
        if (!ValidateModel(createPlayerModel))
        {
            return BadRequest("incorrect player model");
        }

        var newPlayer = _mapper.Map<FootballPlayer>(createPlayerModel);
        var playerEntity = _dbContext.Players.Add(newPlayer);

        return CreatedAtRoute(
            nameof(GetPlayerById),
            new { playerId = playerEntity.Entity.PlayerId },
            playerEntity.Entity.PlayerId );
    }

    private bool ValidateModel(CreatePlayerModel createPlayerModel)
    {
        
        
        return true;
    }
}