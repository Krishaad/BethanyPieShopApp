using System;

namespace BethanyPieShop
{
    class Program
    {
        private static List<Employee> employeeList = new List<Employee>();

        static void Main(string[] args)
        {


            bool checker = false;
            do
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("Welcome to the Employee HR Manager!");
                Console.WriteLine("1. Register Employee");
                Console.WriteLine("2. Pay Employee");
                Console.WriteLine("3. List Employee");
                Console.WriteLine("4. Quit Application");
                Console.WriteLine("************************************************************");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                       // Console.WriteLine("Welcome to Register employee\n\n");
                        //checker = true;
                       Console.Clear();
                        RegisterEmployee();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("***Welcome to payroll***\n\n");
                        PayRoll();
                        //checker = true;
                        break;
                    case "3":
                        Console.Clear();
                        //Console.WriteLine("Welcome to Employees list\n\n");
                        ListEmployees();
                        break;
                    case "4":
                        Console.Clear();
                        checker = true;
                        Console.WriteLine("You have been logged out");

                        break;
                    default:
                        Console.WriteLine("Please enter valid input\n");
                        // checker = false;
                        break;
                }
            } while (checker == false);

        }

        private static void RegisterEmployee()
        {
            string fname;
            string lname;
            double hourlyRate;

            Console.WriteLine("Please enter employee's first name");
            fname = Console.ReadLine();

            Console.WriteLine($"Please enter {fname}'s last name");
            lname = Console.ReadLine();

            Console.WriteLine($"Please enter {fname} {lname}'s hourly rate");

            while (!double.TryParse(Console.ReadLine(), out hourlyRate))
            {
                Console.WriteLine("Invalid input. Try again");
            }
            
            //Employee employee = new Employee(fname, lname, hourlyRate);
            employeeList.Add(new Employee(fname, lname, hourlyRate));

            Console.WriteLine("************************************************************");
            //Console.WriteLine(employeeList[0].FirstName);
            Console.Clear();
            Console.WriteLine($"Successfully added employee {fname} {lname}\n\n");
            Console.WriteLine("************************************************************");

        }


        private static void ListEmployees()
        {
            if (employeeList.Count == 0)
            {
                Console.WriteLine("No employees yet");
            }
            else
            {
                for (int i = 0; i < employeeList.Count(); i++)
                {
                    Console.WriteLine("************************************************************");
                    Console.WriteLine($"\n\n{i+1}. {employeeList[i].FirstName}  {employeeList[i].LastName}");
                    Console.WriteLine($"Hourly rate: {employeeList[i].Rate}\n\n");
                    Console.WriteLine("************************************************************");
                }
            }
            
        }

        private static void PayRoll()
        {
            Console.WriteLine("Pick employee to pay now");
            ListEmployees();

            int lengthOfList = employeeList.Count;

            int numPicked;

            while (!int.TryParse(Console.ReadLine(), out numPicked))
            {
                Console.WriteLine("Enter valid number");
            }

            int positinInArr = numPicked - 1;
            Console.WriteLine("************************************************************");
            Console.WriteLine($"You picked {employeeList[positinInArr].FirstName}.\n{employeeList[positinInArr].FirstName}'s hourly rate is {employeeList[positinInArr].Rate}");
            Console.WriteLine("Please enter how many hours worked\n");
            //Console.WriteLine("************************************************************");
            int hoursWorked;

            while (!int.TryParse(Console.ReadLine(), out hoursWorked))
            {
                Console.WriteLine("Enter valid number");
            }

            double currentWage = hoursWorked * employeeList[positinInArr].Rate;
            double roundedWage = Math.Round(currentWage, 2);
            Console.WriteLine("************************************************************");
            Console.WriteLine($"{employeeList[positinInArr].FirstName}'s weekly wage is {roundedWage}");
            Console.WriteLine("************************************************************");

        }
    }
    public class Employee
    {
        public Employee(string firstName, string lastName, double rate)
        {
            FirstName = firstName;
            LastName = lastName;
            Rate = rate;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }
        public double Rate
        {
            get;
            set;
        }



        private string firstName;
        private string lastName;
        private double hourlyRate;
        private double wage;

        public string email;

        public double numOfHoursWorked;



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
        



    

       

