using _11;
using System.Linq.Expressions;
class Program
{
    static void Main()
    {
        try
        {
            List<Student> students = new List<Student>();
            List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>();

            string command = null;
            string second_command = null;
            while ((command = Console.ReadLine()) != "Students:")
            {
                string[] input = command.Split();
                if (input.Length == 3)
                {
                    var specialty_name = input[0] + " " + input[1];
                    var num_faculty = input[2];
                    StudentSpecialty studentSpecialty = new StudentSpecialty(specialty_name, num_faculty);
                    studentSpecialties.Add(studentSpecialty);
                }             
            }
            while ((second_command = Console.ReadLine()) != "END")
            {
                string[] input2 = second_command.Split();
                if (input2.Length == 3)
                {
                    var num_faculty1 = input2[0];
                    var studentName = input2[1] + " " + input2[2];
                    Student student = new Student(studentName, num_faculty1);
                    students.Add(student);
                }
            }

            Console.WriteLine("--------------");
            LINQ(students, studentSpecialties);




        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
    }


    private static void LINQ(List<Student> students, List<StudentSpecialty> studentSpecialties)
    {
        var result = from s in students
                     join ss in studentSpecialties on s.NumberOfFaculty equals ss.NumberOfFaculty
                     orderby s.Name
                     select new
                     {
                         StudentName = s.Name,
                         StudentSpecialtyName = ss.SpecialtyName,
                         FacultyNumber = ss.NumberOfFaculty
                     };

        foreach (var r in result)
        {
            Console.WriteLine($"{r.StudentName} {r.FacultyNumber} {r.StudentSpecialtyName}");
        }
    }
}