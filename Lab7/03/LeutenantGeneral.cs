using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class LeutenantGeneral : Soldier, ILeutenantGeneral
    {
        public List<Private> privateers {  get; }
        private double Salary;
        public LeutenantGeneral(int id,  string name, string lastname, double salary) 
            : base(id, name, lastname) 
        {
            Salary = salary;
            privateers = new List<Private>();
        }

        public void AddPrivate(Private privateSoldier)
        {
            privateers.Add(privateSoldier);
        }


        public override string ToString()
        {
            string privatessoldiers = "";
            foreach (var privat in privateers)
            {
                privatessoldiers += privat.ToString() + "\n";
            }
            return base.ToString() + $" Salary: {Salary} \n Privates:\n{privatessoldiers}";
        }
    }
}
