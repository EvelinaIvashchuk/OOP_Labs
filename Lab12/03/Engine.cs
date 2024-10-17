using _03;

class Program
{
    static void Main()
    {
        var jobs = new List<Job>();
        var employees = new List<IEmployee>();
        var jobHandler = new JobHandler();

        string command = null;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] input = command.Split();
            if (input[0] == "Job")
            {
                var currentJob = new Job(input[1], int.Parse(input[2]), employees.FirstOrDefault(e => e.Name.Equals(input[3])));
                currentJob.JobDone += jobHandler.OnJobCompleted;
                jobs.Add(currentJob);
            }

            if (input[0] == "StandardEmployee")
            {
                var standartEmployee = new StandardEmployee(input[1]);
                employees.Add(standartEmployee);
            }

            if (input[0] == "PartTimeEmployee")
            {
                var parttimeEmployee = new PartTimeEmployee(input[1]);
                employees.Add(parttimeEmployee);
            }

            if (input[0] == "Pass")
            {
                foreach (Job job in jobs)
                {
                    job.Update();
                }
            }

            if (input[0] == "Status")
            {
                foreach (Job job in jobs)
                {
                   if (job.HoursRequired >= 0)
                   {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(job);
                        Console.ResetColor();
                   }
                }
            }
        }

    }

}