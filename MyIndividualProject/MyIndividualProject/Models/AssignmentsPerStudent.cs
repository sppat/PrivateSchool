using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.Models
{
    class AssignmentsPerStudent
    {
        Student _student;
        List<Assignment> _studentAssignments = new List<Assignment>();

        public Student Student
        {
            get { return (this._student); }
            set { this._student = value; }
        }

        public List<Assignment> StudentAssignments
        {
            get { return (this._studentAssignments); }
            set { this._studentAssignments = value; }
        }

        public AssignmentsPerStudent() { }

        public AssignmentsPerStudent(Student initStudent, List<Assignment> initStudentAssignments)
        {
            this.Student = initStudent;
            this.StudentAssignments = initStudentAssignments;
        }
    }
}
