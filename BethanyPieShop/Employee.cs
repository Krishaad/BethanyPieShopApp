using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShop
{
    public class Employee
    {
        public Employee(string first, string last, string em, DateTime bd, EmployeeType emptype, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            bday = bd;
            employeeType = emptype;
            hourlyRate = rate;
        }






        public string firstName;
        public string lastName;
        public string email;

        public double numOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime bday;

        public EmployeeType employeeType;


        public void PerformWork()
        {
            numOfHoursWorked++;

            Console.WriteLine($"{firstName} {lastName} is now working!");

        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            wage = numOfHoursWorked * hourlyRate;

            Console.WriteLine($"The wage for {numOfHoursWorked} hours of work is {wage}.");
            numOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {firstName}\nLast name: {lastName}\nEmail: {email}\nBirthday: {bday}\nEmployee Type: {employeeType}");
            
        }




    }
}
