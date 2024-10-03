using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace School_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
			ListOfStudents StudentsRegistered = new ListOfStudents();
            List<ListOfCourse> ViewStudentRegisteredCourses = new List<ListOfCourse>();
            ListOfCourse CoursesTaught = new ListOfCourse();
            ListOfTeachers RegisteredTeachers = new ListOfTeachers();

			char user_option;

            string student_name;
            int student_age;
            string student_gender;
            string student_id;
            int num_course;

            string teacher_name;
            string teacher_gender;
            int teacher_age;
            string teacher_id;

            void ViewRegisteredStudents()
            {
                Console.WriteLine("{0,-20} {1,-15}", "STUDENT NAME", "STUDENT ID");
                StudentsRegistered.DisplayAllStudent();
            }


            Console.WriteLine("==========================");
            Console.WriteLine("SCHOOL MANAGEMENT SYSTEM");
            Console.WriteLine("==========================");

            while (true)
            {
                Console.WriteLine("\n1. Add Student ");
                Console.WriteLine("2. Remove Student ");
                Console.WriteLine("3. View Students");
                Console.WriteLine("4. Add Teacher ");
                Console.WriteLine("5. View Teachers");
                Console.WriteLine("6. Remove Teacher\n");

                Console.WriteLine("Choose an option: ");
                user_option = Convert.ToChar(Console.ReadLine());
                Option newUserOption = new Option(user_option);

                switch(newUserOption.getUserOption())
                {
                    case '1':
                        ListOfStudents newStudentsRegistered = new ListOfStudents();
						ListOfCourse StudentRegisteredCourses = new ListOfCourse();

						Console.WriteLine("Please enter student name: ");
                        student_name = Console.ReadLine();
                        Console.WriteLine("Please enter student age: ");
                        student_age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter student gender: ");
                        student_gender = Console.ReadLine();
                        Console.WriteLine("Please enter student ID: ");
                        student_id = Console.ReadLine();
                        Console.WriteLine("Please enter the number of courses registed by student: ");
                        num_course = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < num_course; i++)
                        {
                            string course_registered;
                            string course_id;

                            Console.WriteLine("Enter the course name registed by student: ");
                            course_registered = Console.ReadLine();
                            Console.WriteLine("Enter the course ID registed by student: ");
                            course_id = Console.ReadLine();

                            Course newCourse = new Course(course_registered, course_id);
                            StudentRegisteredCourses.AddCourse(newCourse);
                        }
                        ViewStudentRegisteredCourses.Add(StudentRegisteredCourses);
						Student newStudent = new Student(student_name, student_id, StudentRegisteredCourses, num_course, student_gender, student_age);
                        StudentsRegistered.AddStudent(newStudent);
                        break;
                    case '2':
                        string IdOfStudentToBeRemoved;
                        Console.WriteLine("Enter the student ID of the student you want to remove: ");
                        IdOfStudentToBeRemoved = Console.ReadLine();
                        Student StudentToBeRemoved = StudentsRegistered.findStudentByID(IdOfStudentToBeRemoved);
                        StudentsRegistered.RemoveStudent(StudentToBeRemoved);
                        Console.WriteLine("{0} with ID: {1} has been removed.", StudentToBeRemoved.getStudentByName(), StudentToBeRemoved.getStudentByID(IdOfStudentToBeRemoved));
                        break;
                    case '3':
                        ViewRegisteredStudents();
                        break;
                    case '4':
                        string course_taught;
                        string course_id_taught;

                        Console.WriteLine("Enter teacher name: ");
                        teacher_name = Console.ReadLine();
                        Console.WriteLine("Enter teacher gender: ");
                        teacher_gender = Console.ReadLine();
                        Console.WriteLine("Enter teacher age: ");
                        teacher_age = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter teacher ID: ");
                        teacher_id = Console.ReadLine();
                        Console.WriteLine("Enter course taught by teacher: ");
                        course_taught = Console.ReadLine();
                        Console.WriteLine("Enter course ID taught by teacher: ");
                        course_id_taught = Console.ReadLine();

                        Course newTaughtCourse = new Course(course_taught, course_id_taught);

                        Teacher newTeacher = new Teacher(teacher_name, teacher_id, newTaughtCourse, teacher_gender, teacher_age);
                        CoursesTaught.AddCourse(newTaughtCourse);
                        RegisteredTeachers.AddTeacher(newTeacher);
                        break;
                    case '5':
                        Console.WriteLine("{0,-20} {1,-15} {2,-20}", "TEACHER NAME", "TEACHER ID", "SUBJECT");
                        RegisteredTeachers.DisplayAllTeacher();
                        break;
                }
            }
        }
    }
}
