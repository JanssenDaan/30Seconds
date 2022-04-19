using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30SecondsDjan.Objects
{
    public class GameDetails
    {
        public List<Team> TeamsDjan = new List<Team>();
        public List<Player> Players = new List<Player>();
        public string CurrentPlayer { get; set; }
        public string CurrentTeam { get; set; }
        public int GamePlayerID { get; set; }
        public int GameTeamID { get; set; }

    }
}
