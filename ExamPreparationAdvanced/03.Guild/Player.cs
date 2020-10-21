using System;
using System.Text;

namespace Guild
{
    public class Player
    {
        private string rank = "Trial";
        private string description = "n/a";

        public Player(string name, string @class)
        {
            Name = name;
            Class = @class;
        }

        public string Name { get; set; }

        public string Class { get; set; }

        public string Rank
        {
            get
            {
                return rank;
            }
            set
            {
                rank = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Player {Name}: {Class}")
                .AppendLine($"Rank: {Rank}")
                .AppendLine($"Description: {Description}");

            return sb.ToString().TrimEnd();
        }

    }
}
