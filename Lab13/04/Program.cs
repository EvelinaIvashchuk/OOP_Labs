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

                Student student = new Student(firstname, lastName);
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
                     orderby s.FirstName descending
                     orderby s.LastName
                     select new { s.FirstName, s.LastName };

        foreach (var r in result)
        {
            Console.WriteLine(r.FirstName + " " + r.LastName);
        }
    }


}