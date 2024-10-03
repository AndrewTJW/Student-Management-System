using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class ListOfTeachers
    {
        List<Teacher> Teachers;

        public ListOfTeachers ()
        {
            Teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher addTeacher)
        {
            Teachers.Add(addTeacher);
        }

        public void RemoveTeacher(Teacher removeTeacher)
        {
            Teachers.Remove(removeTeacher);
        }

        public Teacher findTeacherByID(string findTeacherID)
        {
            foreach (var teacher in Teachers)
            {
                if (teacher.getTeacherByID(findTeacherID) == findTeacherID)
                {
                    return teacher;
                }
            }
            return null;
        }

        public void DisplayAllTeacher()
        {
            foreach (var teacher in Teachers)
            {
                Console.WriteLine("{0,-20} {1,-15} {2,-20}", teacher.getTeacherByName(), teacher.getTeacherID(), teacher.getTeacherCourse());
            }
        }
    }
}
