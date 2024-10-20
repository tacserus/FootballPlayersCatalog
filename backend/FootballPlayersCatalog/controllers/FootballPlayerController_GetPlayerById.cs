using FootballPlayersCatalog.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace FootballPlayersCatalog.controllers;

public partial class FootballPlayerController
{
    [HttpGet]
    [Route("get")]
    public IActionResult GetPlayerById([FromBody] int? playerId)
    {
        if (playerId is null)
        {
            return BadRequest("you need to specify the ID of the player you are receiving");
        }

        FootballPlayer player;
        
        try
        {
            player = _dbContext.Players.First(e => e.PlayerId == playerId);
        }
        catch
        {
            return BadRequest("the player with this id was not found");
        }

        return Ok(player);
    }
}