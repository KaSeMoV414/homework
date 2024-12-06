using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentList studentList = new StudentList();
            studentList.Name = "Classroom Algorithem";

            studentList.AddStudentInOrder(new Student());
            studentList.AddStudentInOrder(new Student());
            studentList.AddStudentInOrder(new Student());

            Console.WriteLine("Students before sorting:");
            Console.WriteLine("------------------------");
            studentList.DisplayStudents();

            studentList.OrderStudents();

            Console.WriteLine("Students after sorting:");
            Console.WriteLine("------------------------");
            studentList.DisplayStudents();
            Console.ReadKey();
        }

    }

}
