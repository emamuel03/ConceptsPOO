// See https://aka.ms/new-console-template for more information
using POOConceptos;

Console.WriteLine("PO Concepts");
Console.WriteLine("==========");

Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 1),
    HiringDate = new Date(2022, 6, 1),
    IsActive = true,
    Salary = 160052.23M,
};

Employee employee2 = new CommissionEmployee()
{
    Id = 2,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1994, 5, 12),
    HiringDate = new Date(2022, 6, 1),
    IsActive = true,
    Sales = 3200000.23M,
    CommissionPercentaje = 0.03F
};

Employee employee3 = new HourlyEmployee()
{
    Id = 3,
    FirstName = "Juan",
    LastName = "Perez",
    BirthDate = new Date(1989, 10, 11),
    HiringDate = new Date(2022, 6, 1),
    IsActive = true,
    HourValue = 1120.14M,
    Hours = 123.5F
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 3,
    FirstName = "Hector",
    LastName = "Valdez",
    BirthDate = new Date(1994, 10, 21),
    HiringDate = new Date(2022, 2, 1),
    IsActive = true,
    Sales = 540000.23M,
    CommissionPercentaje = 0.015F,
    Base = 86000
};

//Console.WriteLine(employee1);
//Console.WriteLine(employee2);
//Console.WriteLine(employee3);
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("==========================");
Console.WriteLine($"Total nomina: {$"{payroll:C2}",15}");

Console.WriteLine("==========================");
Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 500000.00M,
    Quantity = 2,
};
Invoice invoice2 = new Invoice()
{
    Description = "Samsung J7",
    Id = 2,
    Price = 30000.00M,
    Quantity = 6,
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);