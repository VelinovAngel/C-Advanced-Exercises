using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.pets = new List<Pet>();
        }
        public int Capacity { get; set; }

        public int Count
            => this.pets.Count;

        //•	Field data – collection that holds added pets
        //•	Method Add(Pet pet) – adds an entity to the data if there is an empty cell for the pet.
        //•	Method Remove(string name) – removes the pet by given name, if such exists, and returns bool.
        //•	Method GetPet(string name, string owner) – returns the pet with the given name and owner or null if no such pet exists.
        //•	Method GetOldestPet() – returns the oldest Pet.
        //•	Getter Count – returns the number of pets.
        //•	GetStatistics() – returns a string in the following format:
        //o   "The clinic has the following patients:
        //Pet { Name}
        //        with owner: {Owner
        //    }
        //    Pet {Name
        //}
        //with owner: { Owner}
        //   (…)"

        public void Add(Pet pet)
        {
            if (Capacity == pets.Count)
            {
                return;
            }
            else
            {
                pets.Add(pet);

            }
        }

        public bool Remove(string name)
        {
            Pet pet = pets.FirstOrDefault(x => x.Name == name);

            if (pet == null)
            {
                return false;
            }
            else
            {
                pets.Remove(pet);
                return true;
            }
        }

        public Pet GetPet(string name, string owner)
        {

            Pet petName = pets.FirstOrDefault(x => x.Name == name);
            Pet petOwner = pets.FirstOrDefault(x => x.Owner == owner);

            if (petName == null && petOwner == null)
            {
                return null;
            }
            else
            {
                return petName;
            }


        }

        public Pet GetOldestPet()
        {

            if (Capacity > 0 && Count > 0)
            {

                int oldestPet = pets.Max(x => x.Age);

                Pet pet = pets.FirstOrDefault(x => x.Age == oldestPet);

                return pet;
            }
            else
            {
                return null;
            }


        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();

        }
    }
}
