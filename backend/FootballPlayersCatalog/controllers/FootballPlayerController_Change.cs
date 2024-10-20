using FootballPlayersCatalog.Entities;
using FootballPlayersCatalog.models;
using Microsoft.AspNetCore.Mvc;

namespace FootballPlayersCatalog.controllers;

public partial class FootballPlayerController
{
    [HttpPut]
    [Route("edit")]
    public IActionResult Update(UpdatePlayerModel updatePlayerModel)
    {
        if (!ValidateModel(updatePlayerModel))
        {
            return BadRequest("incorrect player model");
        }

        var playerForUpdate = _mapper.Map<FootballPlayer>(updatePlayerModel);
        var updatedPlayer = _dbContext.Players.Update(playerForUpdate);
        
        return Ok(updatedPlayer);
    }

    private bool ValidateModel(UpdatePlayerModel updatePlayerModel)
    {
        return true;
    }
}