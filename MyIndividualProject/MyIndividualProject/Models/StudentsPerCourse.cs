using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.Models
{
    class StudentsPerCourse
    {
        private Course _course;
        private List<Student> _studentslist = new List<Student>();

        public Course Course
        {
            get { return this._course; }
            set { this._course = value; }
        }

        public List<Student> StudentsList
        {
            get { return this._studentslist; }
            private set { this._studentslist = value; }
        }

        public StudentsPerCourse() { }

        public StudentsPerCourse(Course initCourse)
        {
            this.Course = initCourse;
        }

        public void AddStudentToCourseList(Student newStudent)
        {
            _studentslist.Add(newStudent);
        }

        public void PrintStudentsPerCourseList()
        {
            Console.WriteLine($"Students in {this._course}:\n");
            foreach (Student student in this._studentslist)
            {
                Console.WriteLine(student);
                Console.WriteLine("--------------------------------------------");
            }
             Console.WriteLine();
        }
    }
}
