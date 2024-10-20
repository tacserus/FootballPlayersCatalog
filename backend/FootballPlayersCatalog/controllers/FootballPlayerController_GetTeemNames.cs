using FootballPlayersCatalog.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FootballPlayersCatalog.controllers;

public partial class FootballPlayerController
{
    [HttpGet]
    [Route("getteemnames")]
    public IActionResult GetTeemNames()
    {
        List<string> teemNames;
        try
        {
            teemNames = _dbContext.Players.Select(p => p.TeemName).Distinct().ToList();
        }
        catch
        {
            return Ok();
        }
      
        return Ok(teemNames);
    }
}
