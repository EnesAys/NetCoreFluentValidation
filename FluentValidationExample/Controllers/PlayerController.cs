using FluentValidationExample.Models;
using FluentValidationExample.Services;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var players = _playerService.GetPlayers();
            return Ok(players);
        }

        [HttpPost]
        public IActionResult Post(Player player)
        {
            var resultMessage = _playerService.AddPlayer(player);
            return Ok(resultMessage);
        }
    }
}
