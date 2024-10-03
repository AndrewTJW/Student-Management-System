using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Course
    {
        private string course_name { get; set; }
        private string course_id { get; set; }

        public Course (string a_course_name, string a_course_id)
        {
            course_name = a_course_name;
            course_id = a_course_id;
        }

        public Course() { }

        public string getCourseByID (string findCourseID)
        {
            if (findCourseID == course_id)
            {
                return course_id;
            }
            return null;
        }

        public string getCourseByName ()
        {
            return course_name;
        }

        public string getCourseID()
        {
            return course_id;
        }
    }
}
