using Microsoft.AspNetCore.Mvc;

namespace FootballPlayersCatalog.controllers;

public partial class FootballPlayerController
{
    [HttpGet]
    [Route("getplayers")]
    public IActionResult GetPlayers()
    {
        var players = _dbContext.Players.ToList();

        return Ok(players);
    }
}