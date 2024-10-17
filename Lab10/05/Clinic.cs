using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    public class Clinic
    {
        private int firstRoomIndex;
        private string name;
        private Pet[] roomsContent;

        public Clinic(string name, int roomsCount)
        {
            Name = name;
            ValidateNumberOfRooms(roomsCount);
            roomsContent = new Pet[roomsCount];
            firstRoomIndex = roomsContent.Length / 2;
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        public bool AddPet(Pet petToAdd)
        {
            for (int i = 0; i <= firstRoomIndex; i++)
            {
                if (roomsContent[firstRoomIndex - i] == null)
                {
                    roomsContent[firstRoomIndex - i] = petToAdd;
                    return true;
                }

                if (roomsContent[firstRoomIndex + i] == null)
                {
                    roomsContent[firstRoomIndex + i] = petToAdd;
                    return true;
                }
            }

            return false;
        }

        public bool ReleaseAnimal()
        {
            for (int i = firstRoomIndex; i < roomsContent.Length; i++)
            {
                if (roomsContent[i] != null)
                {
                    roomsContent[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < firstRoomIndex; i++)
            {
                if (roomsContent[i] != null)
                {
                    roomsContent = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            foreach (var room in roomsContent)
            {
                if (room == null)
                {
                    return true;
                }
            }
            return false;
        }

        public string GetRoomState(int roomNumber)
        {
            roomNumber--;

            if (roomNumber < 0 || roomNumber >= roomsContent.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Operation!");
                Console.ResetColor();
            }

            string getroomstate = "";

            if (roomsContent[roomNumber] == null)
            {
                getroomstate += "Room empty";
            }
            getroomstate += roomsContent[roomNumber].ToString();

            return getroomstate;
        }

        public string GetAllRomsState()
        {
            string allRoomsState = "";
            foreach (var room in roomsContent)
            {
                if (room == null)
                {
                    allRoomsState += "Room empty" + "\n";
                }
                else
                {
                    allRoomsState += room.ToString() + "\n";
                }
            }
            return allRoomsState;
        }



        public void ValidateNumberOfRooms(int roomsCount)
        {
            if (roomsCount % 2 == 0 || roomsCount < 1 || roomsCount > 101)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Operation!");
                Console.ResetColor();
            }
        }
    }
}
