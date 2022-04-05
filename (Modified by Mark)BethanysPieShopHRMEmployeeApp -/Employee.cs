using System;

namespace BethanysPieShopHRMEmployeeApp
{
    public class Employee
    {
        private string firstName;
        private string lastName;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private double bonus;
        private double newRate;
        

     
       public double NewRate
            { get { return newRate; } set { newRate = value; } }
      
        
        public double Bonus
        {
            get { return bonus; }
            set
            {
                bonus = value;  
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                hourlyRate = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            set
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get { return wage; }
            set
            {
                wage = value;
            }
        }

        public Employee(string first, string last, double rate, double bonus)
        {
            FirstName = first;
            LastName = last;
            HourlyRate = rate;
            Bonus = bonus;

          

                    
        }

        
        public int PerformWork(int hours)
        {
            NumberOfHoursWorked += hours;
            return NumberOfHoursWorked;
        }

        public double ReceiveWage(out int hoursWorked, out double salary)
        {

            Wage = NumberOfHoursWorked * HourlyRate;
            salary = Wage + Bonus;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {salary}.");

            NumberOfHoursWorked = 0;
            hoursWorked = NumberOfHoursWorked;

            return salary;
        }

        public double NewHourlyRate( double hourlyRate)
        {

            NewRate = hourlyRate;
            return hourlyRate;

        }
    }
}
