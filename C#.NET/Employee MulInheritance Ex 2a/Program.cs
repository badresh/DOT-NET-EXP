using System;
interface EmpDetails
{
    string Name { get; }
    int Emp_ID { get; }
    string Gender { get; }
}

interface EmpDesignation
{
    string Position { get; }
    double Salary { get; }
    string Department { get; }
}

class Emp : EmpDetails, EmpDesignation
{
    public string Name { get; private set; }
    public int Emp_ID { get; private set; }
    public string Gender { get; private set; }
    public string Position { get; private set; }
    public double Salary { get; private set; }
    public string Department { get; private set; }

    public Emp(string name, int empid, string gender, string position, double salary, string department)
    {
        Name = name;
        Emp_ID = empid;
        Gender = gender;
        Position = position;
        Salary = salary;
        Department = department;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        int empid = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter Employee Position: ");
        string position = Console.ReadLine();

        Console.Write("Enter Employee Salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter Employee Department: ");
        string department = Console.ReadLine();

        Emp employee = new Emp(name, empid, gender, position, salary, department);
        Console.WriteLine();
        employee.DisplayEmployeeDetails();
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("{0,-15} {1,-5} {2,-10} {3,-15} {4,-10} {5,-15}", "Name", "Empid", "Gender", "Position", "Salary", "Department");
        Console.WriteLine(new string('-', 70));
        Console.WriteLine("{0,-15} {1,-5} {2,-10} {3,-15} {4,-10} {5,-15}", Name, Emp_ID, Gender, Position, Salary, Department);
    }
}

