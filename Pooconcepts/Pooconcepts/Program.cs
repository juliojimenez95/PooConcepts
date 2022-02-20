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

Console.WriteLine(employee1);

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

Console.WriteLine(employee2);
