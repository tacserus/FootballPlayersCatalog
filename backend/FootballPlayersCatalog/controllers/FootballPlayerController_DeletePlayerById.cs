using FootballPlayersCatalog.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FootballPlayersCatalog.controllers;

public partial class FootballPlayerController
{
    [HttpDelete]
    [Route("delete")]
    public IActionResult DeletePlayerById([FromBody] int? playerId)
    {
        if (playerId is null)
        {
            return BadRequest("you need to specify the ID of the player you are deleting");
        }
        
        var player = _dbContext.Players.Find(playerId);

        if (player is null)
        {
            return Ok();
        }

        _dbContext.Players.Remove(player);

        _dbContext.SaveChanges();
        
        return Ok();
    }
}