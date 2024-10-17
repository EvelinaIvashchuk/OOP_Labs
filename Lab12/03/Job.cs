using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public delegate void JobEventArgs(Job job);
    public interface IEmployee
    {
        string Name { get; }
        int WorkHoursPerWeek { get; }
    }

    public class Job
    {
        private IEmployee employee;
        private int hoursRequired;

        public Job(string name, int hoursRequired, IEmployee employee)
        {
            Name = name;
            this.hoursRequired = hoursRequired;
            this.employee = employee;
        }

        public int HoursRequired
            { get { return hoursRequired; } set { hoursRequired = value; } }


        public event JobEventArgs JobDone;

        public string Name { get; private set; }

        public void Update()
        {
            hoursRequired -= employee.WorkHoursPerWeek;

            if (hoursRequired <= 0)
            {
                OnJobDone();
            }
        }

        public override string ToString()
        {
            return $"Job: {Name} Hours Remaining: {hoursRequired}";
        }

        public void OnJobDone()
        {
            JobDone?.Invoke(this);
        }
    }
}
