using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Teacher : Person
    {
        private string name { get; set; }
        private string teacher_id { get; set; }

        private Course course { get; set; }


        public Teacher (string a_name, string a_teacher_id, Course a_course, string a_gender, int a_age) : base(a_gender, a_age)
        {
            name = a_name;
            teacher_id = a_teacher_id;
            course = a_course;
        }

        public Teacher() { }

        public string getTeacherByID(string findTeacherID)
        {
            if (findTeacherID == teacher_id)
            {
                return teacher_id;
            }
            return null;
        }
        public string getTeacherByName()
        {
            return name;
        }

        public string getTeacherID ()
        {
            return teacher_id;
        }

        public string getTeacherCourse()
        {
            return course.getCourseByName();
        }
    }
}
