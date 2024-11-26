using System;

enum EmployeeRole
{
    Manager,
    Developer,
    Designer,
    Tester
}

class SalaryCalculator
{
    public static int CalculateSalary(EmployeeRole role)
    {
        switch (role)
        {
            case EmployeeRole.Manager:
                return 10000;
            case EmployeeRole.Developer:
                return 8000;
            case EmployeeRole.Designer:
                return 7000;
            case EmployeeRole.Tester:
                return 6000;
            default:
                throw new ArgumentException("Geçersiz rol.");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Manager maaşı: {SalaryCalculator.CalculateSalary(EmployeeRole.Manager)} TL");
        Console.WriteLine($"Developer maaşı: {SalaryCalculator.CalculateSalary(EmployeeRole.Developer)} TL");
        Console.WriteLine($"Designer maaşı: {SalaryCalculator.CalculateSalary(EmployeeRole.Designer)} TL");
        Console.WriteLine($"Tester maaşı: {SalaryCalculator.CalculateSalary(EmployeeRole.Tester)} TL");
    }
}