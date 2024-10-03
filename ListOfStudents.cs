using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class ListOfStudents
    {
        List<Student> Students;

        public ListOfStudents()
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student addStudent)
        {
            Students.Add(addStudent);
        }

        public void RemoveStudent(Student removeStudent)
        {
            Students.Remove(removeStudent);
        }

        public Student findStudentByID(string findStudentID)
        {
            foreach (var student in Students)
            {
                if (student.getStudentByID(findStudentID) == findStudentID)
                {
                    return student;
                }
            }
            return null;
        }

        public void DisplayAllStudent()
        {
            foreach (var student in Students)
            {
                Console.WriteLine("{0,-20} {1,-15}", student.getStudentByName(), student.getStudentByID());
            }
        }
    }
}
