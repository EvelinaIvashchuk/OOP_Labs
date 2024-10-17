using System.Diagnostics;
using _01;
class Program
{
    static void Main()
    {
        try
        {
            List<Student> students = new List<Student>();

            string command = null;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command.Split();
                var firstname = input[0];
                var lastName = input[1];
                var age = int.Parse(input[2]);

                Student student = new Student(firstname, lastName, age);
                students.Add(student);
            }
            Console.WriteLine("--------------");
            LINQ(students);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


    private static void LINQ(List<Student> students)
    {
        var result = from s in students
                     where s.Age >= 18 && s.Age <= 25
                     orderby s.Age descending
                     select new { s.FirstName, s.LastName, s.Age};

        foreach (var r in result)
        {
            Console.WriteLine($"{r.FirstName} {r.LastName} {r.Age}");
        }
    }


}