using System;

namespace BethanyPieShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee bethany = new Employee("Bethany", "Smith", "Bethany@gmail.com", new DateTime(1979, 1, 16),
                EmployeeType.Manager, 25.2);

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();

        }
    }
}

