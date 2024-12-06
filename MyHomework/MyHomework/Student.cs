using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class Student
    {
        static int available_id = 1;
        public int StudentID { get; set; }
        public string Name { get; set; }
        public double Test1 { get; set; }
        public double Test2 { get; set; }
        public double Average { get; private set; }
        public string Grade { get; private set; }

        public Student()
        {
            StudentID = available_id;
            available_id++;

            Console.WriteLine("Please enter student Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter Test1 score: ");
            Test1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter Test2 score: ");
            Test2 = Convert.ToDouble(Console.ReadLine());

            CalculateAverage();
            DetermineGrade();
        }

        private void CalculateAverage()
        {
            Average = (Test1 + Test2) / 2;
        }

        private void DetermineGrade()
        {
            if (Average < 50)
                Grade = "Fail";
            else if (Average < 65)
                Grade = "Pass";
            else if (Average < 80)
                Grade = "Good";
            else if (Average < 90)
                Grade = "Very Good";
            else
                Grade = "Excellent";
        }

        public void PrintStudent()
        {
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Test1 Score: " + Test1);
            Console.WriteLine("Test2 Score: " + Test2);
            Console.WriteLine("Average Score: " + Average);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("-------------------------------------");
        }
    }
}




