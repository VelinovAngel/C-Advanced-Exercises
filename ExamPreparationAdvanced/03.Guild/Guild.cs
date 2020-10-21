using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {

        private List<Player> players;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            players = new List<Player>();
        }

        public int Count
            => players.Count;

        public string Name { get; set; }

        public int Capacity { get; set; }


        public void AddPlayer(Player player)
        {
            if (players.Count < Capacity)
            {
                players.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player player = players.FirstOrDefault(x => x.Name == name);
            return players.Remove(player);
        }

        public void PromotePlayer(string name)
        {
            Player player = players.FirstOrDefault(x => x.Name == name);
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player player = players.FirstOrDefault(x => x.Name == name);
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string name)
        {

            Player[] player = players.Where(x => x.Class.Contains(name))
                                     .ToArray();

            players = players.Where(x => !x.Class.Contains(name))
                                     .ToList();
            return player;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in players)
            {
                sb.AppendLine($"{player}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
