using System;

namespace SpaceStationRecruitment
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            SpaceStation spaceStation = new SpaceStation("Galaxy" , 20);

            spaceStation.Add(new Astronaut("Pesho", 20, "Plovdiv"));
            spaceStation.Add(new Astronaut("Stoqn", 22, "Vana"));
            spaceStation.Add(new Astronaut("Dimitrichko", 30, "Sofia"));
            spaceStation.Add(new Astronaut("Ivan", 39, "Burgas"));

            spaceStation.Remove("Pesho");

            Console.WriteLine();

            
            


        }
    }
}
