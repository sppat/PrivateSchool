using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyIndividualProject.Models
{
    class AssignmentsPerCourse
    {
        private Course _course;
        private List<Assignment> _assignmentslist = new List<Assignment>();

        public Course Course
        {
            get { return this._course; }
            set { this._course = value; }
        }

        public List<Assignment> AssignmentsList
        {
            get { return this._assignmentslist; }
            private set { this._assignmentslist = value; }
        }

        public AssignmentsPerCourse() { }

        public AssignmentsPerCourse(Course initCourse)
        {
            this._course = initCourse;
        }

        public AssignmentsPerCourse(Course initCourse, Assignment initAssignment)
        {
            this.Course = initCourse;
            this.AddAssignmentToCourseList(initAssignment);
        }

        public void AddAssignmentToCourseList(Assignment newAssignment)
        {
            _assignmentslist.Add(newAssignment);
        }

        public void PrintAssignmentsPerCourseList()
        {
            Console.WriteLine($"Assignments in {this._course}:\n");
            foreach (Assignment assignment in this._assignmentslist)
            {
                Console.WriteLine(assignment);
                Console.WriteLine("--------------------------------------------");
            }
            Console.WriteLine();
        }
    }
}
