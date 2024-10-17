using System;
using System.Diagnostics;
using _01;
using static System.Formats.Asn1.AsnWriter;
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
                var index = input[0];
                int[] score = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    score[i] = int.Parse(input[i + 1]);
                }

                Student student = new Student(index, score);
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
                     where s.Index.EndsWith("14") || s.Index.EndsWith("15")
                     select s.score;

        foreach (var r in result)
        {
            Console.WriteLine(string.Join(" ", r));
        }
    }


}