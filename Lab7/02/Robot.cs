using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Robot
    {
        private string model;
        private string ID;

        public Robot(string model, string ID)
        {
            this.model = model;
            this.ID = ID;
        }
    }

    interface Robots
    {
        void AddRobot(string model, string ID);
    }


}
