using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<Vlogger> vloggers = new HashSet<Vlogger>();

            while ((input = Console.ReadLine()) != "Statistics")
            {

                string[] tokens = input
                    .Split();

                string action = tokens[1];
                string name = tokens[0];

                switch (action)
                {
                    case "joined":
                        Vlogger newVlogger = new Vlogger(name);
                        if (!vloggers.Any(x => x.Name == newVlogger.Name))
                        {
                            vloggers.Add(newVlogger);
                        }
                        break;
                    case "followed":
                        string following = tokens[0];
                        string followed = tokens[2];

                        if (following != followed
                            && vloggers.Any(x => x.Name == following)
                            && vloggers.Any(x => x.Name == followed))
                        {
                            Vlogger vlogger1 = vloggers.Where(v => v.Name == following).FirstOrDefault();
                            vlogger1.AddFollowing(followed);

                            Vlogger vlogger2 = vloggers.Where(v => v.Name == followed).FirstOrDefault();
                            vlogger2.AddFollower(following);
                        }
                        break;
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            if (vloggers.Count == 0)
            {
                return;
            }

            int maxFollowers = int.MinValue;

            foreach (var item in vloggers)
            {
                if (item.Followers.Count > maxFollowers)
                {
                    maxFollowers = item.Followers.Count;
                }       
            }

            Vlogger famous = vloggers.Where(v => v.Followers.Count == maxFollowers).FirstOrDefault();
 
            Console.WriteLine($"1. {famous.Name} : {famous.Followers.Count} followers, {famous.Following.Count} following");
            foreach (var follower in famous.Followers)
            {
                Console.WriteLine($"*  {follower}");
            }

            vloggers.Remove(famous);

            int cout = 2;
            foreach (var item in vloggers.OrderByDescending(x=>x.Followers.Count).ThenBy(x=>x.Following.Count))
            {
                Console.WriteLine($"{cout}. {item.Name} : {item.Followers.Count} followers, {item.Following.Count} following");
                cout++;
            }
        }


    }
    public class Vlogger
    {
        public string Name { get; set; }

        public SortedSet<string> Followers { get; set; }

        public HashSet<string> Following { get; set; }

        public Vlogger(string name)
        {
            this.Name = name;
            this.Followers = new SortedSet<string>();
            this.Following = new HashSet<string>();
        }

        public void AddFollower(string name)
        {
            Followers.Add(name);
        }

        public void AddFollowing(string name)
        {
            Following.Add(name);
        }
    }
}
