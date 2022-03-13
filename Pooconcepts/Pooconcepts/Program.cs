using Pooconcepts;

Console.WriteLine("Concepts Poo");
Console.WriteLine("============");
Employee employee1 = new SalaryEmployee()
{
    id = 1010,
    FirstName = "sandra",
    LastName = "Morales",
    BirthDate = new Date(1990,5,23),    
    HiringDate= new Date(2022,1,15),
    IsActive = true,
    Salary= 1815453.45M
};

//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    id = 2020,
    FirstName = "patricia",
    LastName = "gutierres",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje=0.03F
    
};

//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    id = 3030,
    FirstName = "juan",
    LastName = "guevara",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    HourValue= 12300.56M,
    Hours= 123.5F

};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    id = 4040,
    FirstName = "yasmin",
    LastName = "guerra",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Base= 860678.36M,
    Sales = 58000000M,
    CommissionPercentaje = 0.15F


};

//Console.WriteLine(employee4);

//ICollection<Employee> employees = new List<Employee>();
//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);
ICollection<Employee> employees = new List<Employee>()
{   
    employee1, employee2, employee3, employee4
};

decimal payRoll = 0;

foreach (Employee employee in employees) {
    Console.WriteLine(employee);
    payRoll += employee.GetValueToPay(); 

}
Console.WriteLine("               =======================");
Console.WriteLine($"Total        {$"{payRoll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
