using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class ClinicsManager
    {
        private List<Pet> pets;
        private List<Clinic> clinics;

        public ClinicsManager()
        {
            pets = new List<Pet>();
            clinics = new List<Clinic>();
        }

        public void CreatePet(string name, int age, string kind) => pets.Add(new Pet(name, age, kind));
        public void CreateClinic(string name, int rooms) => clinics.Add(new Clinic(name, rooms));
        public bool HasEmptyRooms(string clinicName) => GetConcreteClinic(clinicName).HasEmptyRooms();
        public string PrintClinic(string clinicName) => GetConcreteClinic(clinicName).GetAllRomsState();
        public string PrintRoom(string clinicName, int roomNumber) => GetConcreteClinic(clinicName).GetRoomState(roomNumber);
        public bool Release(string clinicName) => GetConcreteClinic(clinicName).ReleaseAnimal();
        public bool Add(string petName, string clinicName)
        {
            var currentPet = GetConcretePet(petName);
            var currentClinic = GetConcreteClinic(clinicName);
            return currentClinic.AddPet(currentPet);
        }

        public Pet GetConcretePet(string petName)
        {
            var currentPet = pets.FirstOrDefault(p => p.Name == petName);
            if (currentPet == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Operation!");
                Console.ResetColor();
            }
            return currentPet;
        }

        public Clinic GetConcreteClinic(string clinicName)
        {
            var currentClinic = clinics.FirstOrDefault(c => c.Name == clinicName);
            if (currentClinic == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Operation!");
                Console.ResetColor();
            }
            return currentClinic;
        }
    }
}
