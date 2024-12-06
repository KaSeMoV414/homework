using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{

    public class StudentList
    {
        public string Name { get; set; }
        public Node First { get; set; }

        public void AddStudentInOrder(Student new_student)
        {
            Console.WriteLine("Adding new Student to: " + this.Name);

            Node new_node = new Node(new_student);

            if (First == null || First.Data.Average > new_student.Average)
            {
                new_node.Next = First;
                First = new_node;
                return;
            }

            Node current = First;

            while (current.Next != null && current.Next.Data.Average < new_student.Average)
                current = current.Next;

            new_node.Next = current.Next; 
            current.Next = new_node; 
        }

        public void AddStudent(Student new_student)
        {
            Console.WriteLine("Adding new Student to: " + this.Name);

            Node new_node = new Node(new_student);

            new_node.Next = First;
            First = new_node;
        }

        public void OrderStudents()
        {
            Console.WriteLine("Ordering all students in " + this.Name);

            if (First == null || First.Next == null)
                return; 

            bool swapped;
            do
            {
                swapped = false;

                for (Node i = First; i != null && i.Next != null; i = i.Next)
                {
                    if (i.Data.Average > i.Next.Data.Average)
                    {
                        var tempData = i.Data;
                        i.Data = i.Next.Data;
                        i.Next.Data = tempData;
                        swapped = true;
                    }
                }
            } while (swapped); 
        }


        public void DisplayStudents()
        {
            Console.WriteLine("Displaying all students in " + this.Name);

            for (Node i = First; i != null; i = i.Next)
            {
                i.Data.PrintStudent();
            }
        }
    }
}




