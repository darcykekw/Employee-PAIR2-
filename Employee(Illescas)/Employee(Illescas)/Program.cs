class Program
{
    static void Main()
    {

        RegularEmployee alice = new RegularEmployee("Alice", 1);
        HourlyEmployee bob = new HourlyEmployee("Bob", 2, 160, 20.5f);
        CommissionEmployee charlie = new CommissionEmployee("Charlie", 3, 50000, 0.10f);

        alice.CalculateSalary();
        bob.CalculateSalary();
        charlie.CalculateSalary();

        Console.WriteLine("Employee Salaries (before bonus):");
        DisplayEmployeeSalary(alice);
        DisplayEmployeeSalary(bob);
        DisplayEmployeeSalary(charlie);

        float bonusThreshold = 4000.0f;
        float bonusAmount = 1000.0f;
        alice.ApplyBonus(bonusThreshold, bonusAmount);
        bob.ApplyBonus(bonusThreshold, bonusAmount);
        charlie.ApplyBonus(bonusThreshold, bonusAmount);

        Console.WriteLine("\nEmployee Salaries (after bonus):");
        DisplayEmployeeSalary(alice);
        DisplayEmployeeSalary(bob);
        DisplayEmployeeSalary(charlie);

        float totalPayroll = alice.Salary + bob.Salary + charlie.Salary;
        Console.WriteLine($"\nTotal Payroll: {totalPayroll}");
    }

    static void DisplayEmployeeSalary(Employee employee)
    {
        Console.WriteLine($"Name: {employee.Name}, ID: {employee.Id}, Salary: {employee.Salary}");
    }
}