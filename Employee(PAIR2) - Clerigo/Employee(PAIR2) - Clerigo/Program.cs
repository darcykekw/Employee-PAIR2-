using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public float Salary { get; protected set; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
        Salary = 0;
    }

    public void ApplyBonus(float threshold, float bonus)
    {
        if (Salary > threshold)
        {
            Salary += bonus;
        }
    }
}

class RegularEmployee : Employee
{
    private const float FixedRate = 3000.0f;

    public RegularEmployee(string name, int id) : base(name, id) { }

    public void CalculateSalary()
    {
        Salary = FixedRate;
    }
}

class HourlyEmployee : Employee
{
    public float HoursWorked { get; set; }
    public float HourlyRate { get; set; }

    public HourlyEmployee(string name, int id, float hoursWorked, float hourlyRate) : base(name, id)
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }

    public void CalculateSalary()
    {
        Salary = HoursWorked * HourlyRate;
    }
}

class CommissionEmployee : Employee
{
    public float SalesAmount { get; set; }
    public float CommissionRate { get; set; }

    public CommissionEmployee(string name, int id, float salesAmount, float commissionRate) : base(name, id)
    {
        SalesAmount = salesAmount;
        CommissionRate = commissionRate;
    }

    public void CalculateSalary()
    {
        Salary = SalesAmount * CommissionRate;
    }
}