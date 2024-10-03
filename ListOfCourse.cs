using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class ListOfCourse
    {
        private List<Course> Courses;

        public ListOfCourse ()
        {
            Courses = new List<Course>();
        }

        public Course findCourseByID (string findCourseID)
        {
            foreach (var course in Courses)
            {
                if (course.getCourseByID(findCourseID) == findCourseID)
                {
                    return course;
                }
            }
            return null;
        }

        public void AddCourse(Course addCourse)
        {
            Courses.Add(addCourse);
        }

        public void RemoveCourse(Course removeCourse)
        {
            Courses.Remove(removeCourse);
        }

        public void DisplayAllCourse ()
        {
            foreach(var course in  Courses)
            {
                Console.WriteLine("{0} {1}", course.getCourseByName(), course.getCourseID());
            }
        }
    }
}
