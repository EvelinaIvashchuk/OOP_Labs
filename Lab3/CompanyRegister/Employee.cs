namespace CompanyRegister;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string? Email { get; set; }
    public int? Age { get; set; }
    
    public Employee(string name, double salary, string position, string department, string? email = null, int? age = null)
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
        Email = email ?? "n/a";
        Age = age ?? -1;
    }
}