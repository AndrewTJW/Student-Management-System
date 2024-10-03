using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Student : Person
    {
        private string name { get; set; }
        private string student_id { get; set; }
        private ListOfCourse courses { get; set; }

        private int num_course { get; set; }


        public Student () { }
        public Student (string a_name, string a_student_id, ListOfCourse a_courses, int a_num_course,string a_gender, int a_age) : base(a_gender, a_age)
        {
            name = a_name;
            student_id = a_student_id;
            courses = a_courses;
            num_course = a_num_course;
        }
        public string getStudentByID(string findStudentID)
        {
            if (findStudentID == student_id)
            {
                return student_id;
            }
            return null;
        }
        public string getStudentByName()
        {
            return name;
        }

        public int getNumOfCourseOfStudent()
        {
            return num_course;
        }

        public string getStudentByID()
        {
            return student_id;
        }
    }
}
