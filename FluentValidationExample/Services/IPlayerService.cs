using FluentValidationExample.Models;
using System.Collections.Generic;

namespace FluentValidationExample.Services
{
    public interface IPlayerService
    {
        IEnumerable<Player> GetPlayers();
        string AddPlayer(Player player);
    }
}
