namespace Delegates;

public class Program
{
    static void Main(string[] args)
    {
        #region Delegates
        var employees = new List<Employee>
     {
           new Employee { Id = 1, Name = "John Doe", TotalSales = 50000.75m, Gender = "Male" },
           new Employee { Id = 2, Name = "Jane Smith", TotalSales = 75000.50m, Gender = "Female" },
           new Employee { Id = 3, Name = "Bob Johnson", TotalSales = 60000.25m, Gender = "Male" },
           new Employee { Id = 4, Name = "Alice Brown", TotalSales = 45000.90m, Gender = "Female" },
           new Employee { Id = 5, Name = "Charlie Wilson", TotalSales = 80000.00m, Gender = "Male" },
           new Employee { Id = 6, Name = "Eva Davis", TotalSales = 55000.60m, Gender = "Female" },
           new Employee { Id = 7, Name = "Frank White", TotalSales = 70000.30m, Gender = "Male" },
           new Employee { Id = 8, Name = "Grace Miller", TotalSales = 48000.80m, Gender = "Female" },
           new Employee { Id = 9, Name = "Harry Thompson", TotalSales = 62000.40m, Gender = "Male" },
           new Employee { Id = 10, Name = "Ivy Lee", TotalSales = 67000.20m, Gender = "Female" },
           new Employee { Id = 11, Name = "Jack Robinson", TotalSales = 53000.70m, Gender = "Male" },
           new Employee { Id = 12, Name = "Katie Hall", TotalSales = 72000.10m, Gender = "Female" },
           new Employee { Id = 13, Name = "Leo Garcia", TotalSales = 49000.85m, Gender = "Male" },
           new Employee { Id = 14, Name = "Mia Turner", TotalSales = 68000.45m, Gender = "Female" },
           new Employee { Id = 15, Name = "Nathan Harris", TotalSales = 59000.95m, Gender = "Male" }
     };


           var report = new Report();

        report.ProcessEmployees(employees, "Employeeswith60000PlusSales", CheckIfMoreThan60000);

        //report.ProcessEmployeeswithSalesLessThan30000(employees);
        //report.ProcessEmployeeswithSalesBetween30000and59999(employees);
        //report.ProcessEmployeeswith60000PlusSales(employees);

         

        #endregion

        #region Multicast delegates

        //RectHelper.GetPerimeter(10, 10);
        //RectHelper.GetArea(10,10);






        #endregion
    }

    static bool CheckIfMoreThan60000(Employee employee) => employee.TotalSales >= 60000m;
}







      
        //RectDelegate rect;
        //rect = RectHelper.GetArea;
        //rect += RectHelper.GetPerimeter;

        //rect(10,10);


        //rect -= RectHelper.GetArea;
        //Console.WriteLine("After Unsubscrioing from Area");