using CompanyRegister;

Console.WriteLine("Enter the number of employees: ");
var input = Console.ReadLine();
var countEmployeeCalculate = Convert.ToInt32(input);

var employees = new[]
{
    new Employee("Pesho", 120, "Dev", "Development", "pesho@abv.bg", 28),
    new Employee("Toncho", 133, "Dev", "Development", "pesho@abv.bg", 21),
    new Employee("Maks", 160, "Manager", "Sales", "pesho@abv.bg", 20),
    new Employee("Roman", 100, "Manager", "Sales", "pesho@abv.bg", 50),
    new Employee("Ivan", 140, "Manager", "Marketing"),
    new Employee("Gosho", 150, "Manager", "Marketing", "pesho@abv.bg", 23),
};

var departments = new List<string>();
var averageSalaries = new List<double>();
var countOfDepartmentEmployees = new List<int>();

for (int i = 0; i < countEmployeeCalculate; i++)
{
    if (!departments.Contains(employees[i].Department))
    {
        departments.Add(employees[i].Department);
    }
}

var countEmployee = 0;
for (int i = 0; i < departments.Count; i++)
{
    for (int j = 0; j < countEmployeeCalculate; j++)
    {
        if (departments[i] == employees[j].Department)
        {
            countEmployee++;
        }
    }
    
    countOfDepartmentEmployees.Add(countEmployee);
    countEmployee = 0;
}

double averageSum = 0;
for (int i = 0; i < departments.Count; i++)
{
    for (int j = 0; j < employees.Length; j++)
    {
        if (departments[i] == employees[j].Department)
        {
            averageSum += employees[j].Salary;
        }
    }
    
    averageSalaries.Add(averageSum / countOfDepartmentEmployees[i]);
    averageSum = 0;
}

var highestSalaryDepartment = departments[averageSalaries.IndexOf(averageSalaries.Max())];

Console.WriteLine("Highest Average Salary: ");
Console.WriteLine(highestSalaryDepartment);
for (int i = 0; i < countEmployeeCalculate; i++)
{
    if (employees[i].Department.Equals(highestSalaryDepartment))
    {
        Console.WriteLine($"{employees[i].Name} {employees[i].Salary} {employees[i].Email} {employees[i].Age}");
    }
}
