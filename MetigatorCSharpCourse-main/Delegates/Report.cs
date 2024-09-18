namespace Delegates;



public class Report
{
    #region after delegate
    public void ProcessEmployees(List<Employee> employees,string title, Func<Employee,bool> predicate)
    {
        Console.WriteLine(title);
        Console.WriteLine("------------------------------------");

        foreach (var employee in employees)
        {
            if (predicate(employee))
            {
                Console.WriteLine(employee);
            }
        }

        Console.WriteLine("\n\n");
    }
    #endregion



    #region Before delegate

    public void ProcessEmployeeswith60000PlusSales(List<Employee> employees)
    {
        Console.WriteLine("Employees with $60.000+ sales");
        Console.WriteLine("------------------------------------");

        foreach (var employee in employees)
        {
            if(employee.TotalSales>=60000m)
            {
                Console.WriteLine(employee);
            }
        }

        Console.WriteLine("\n\n");
    }

    public void ProcessEmployeeswithSalesBetween30000and59999(List<Employee> employees)
    {
        Console.WriteLine("Employees with Sales Between $30,000 and $59,999");
        Console.WriteLine("------------------------------------");

        foreach (var employee in employees)
        {
            if (employee.TotalSales < 60000m && employee.TotalSales>=30000m)
            {
                Console.WriteLine(employee);
            }
        }

        Console.WriteLine("\n\n");
    }

    public void ProcessEmployeeswithSalesLessThan30000(List<Employee> employees)
    {
        Console.WriteLine("Employees with Sales Less than $30,000 ");
        Console.WriteLine("------------------------------------");

        foreach (var employee in employees)
        {
            if (employee.TotalSales < 30000m)
            {
                Console.WriteLine(employee);
            }
        }

        Console.WriteLine("\n\n");
    }

    #endregion

}
//public delegate bool CheckSales(Employee employee);

//public void ProcessEmployee(List<Employee> employees, string title, CheckSales checkSales)
//{
//    Console.WriteLine(title);
//    Console.WriteLine("------------------------------------------------------");

//    foreach (var employee in employees)
//    {
//        if (checkSales(employee))
//        {
//            Console.WriteLine(employee);
//        }
//    }
//    Console.WriteLine("\n\n");
//}