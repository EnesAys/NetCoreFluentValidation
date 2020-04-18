using FluentValidation;
using FluentValidationExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace FluentValidationExample.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IValidator<Player> _playerValidator;
        public PlayerService(IValidator<Player> playerValidator)
        {
            _playerValidator = playerValidator;
        }
        public List<Player> Players = new List<Player>
        {
            new Player{
                Name="Ronaldo",
                TeamName="Juventus",
                IsCanPlay=true
            },
            new Player{
                Name="Messi",
                TeamName="Barcelona",
                IsCanPlay=true
            },
            new Player{
                Name="Mbappe",
                TeamName="PSG",
                IsCanPlay=true
            },
            new Player{
                Name="Neymar",
                TeamName="PSG",
                IsCanPlay=true
            },
            new Player{
                Name="Bale",
                TeamName="Real Madrid",
                IsCanPlay=false
            }
        };

        public string AddPlayer(Player player)
        {
            //var validateResult = _playerValidator.Validate(player, ruleSet: "test");
            var validateResult = _playerValidator.Validate(player);
            if (validateResult.IsValid)
                Players.Add(player);
            return validateResult.IsValid ? "Success" : validateResult.Errors.FirstOrDefault().ErrorMessage;
        }

        public IEnumerable<Player> GetPlayers()
        {
            var resultPlayers = new List<Player>();
            foreach (var player in Players)
            {
                var validateResult = _playerValidator.Validate(player);
                if (validateResult.IsValid)
                    resultPlayers.Add(player);
            }
            return resultPlayers;
        }
    }
}
