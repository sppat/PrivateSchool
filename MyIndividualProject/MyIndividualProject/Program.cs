using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.AppLogic;
using MyIndividualProject.Models;

namespace MyIndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAppUtils.StartApplication();

            List<Assignment>            assignmentsList              = new List<Assignment>()
            {
                AssignmentsUtils.DefaultEntry(),
                AssignmentsUtils.DefaultEntry()
            };
            List<Student>               studentList                  = new List<Student>();
            List<Trainer>               trainerList                  = new List<Trainer>()
            {
                new Trainer("George", "Pasparakis", "C#"),
                new Trainer("George", "Pasparakis", "Java")
            };
            List<Course>                courseList                   = new List<Course>() 
            {
             new Course("C#", "Full-Time", new DateTime(2020, 10, 19), new DateTime(2021, 1, 19)), 
             new Course("Java", "Full-Time", new DateTime(2020, 10, 19), new DateTime(2021, 1, 19)) 
            };
            List<StudentsPerCourse>     studentsPerCourseList        = new List<StudentsPerCourse>
            {
                new StudentsPerCourse(courseList[0]),
                new StudentsPerCourse(courseList[1])
            };
            List<TrainersPerCourse>     trainersPerCourseList        = new List<TrainersPerCourse>
            {
                new TrainersPerCourse(courseList[0], new Trainer("George", "Pasparakis", "C#")),
                new TrainersPerCourse(courseList[1], new Trainer("George", "Pasparakis", "Java"))
            };
            List<AssignmentsPerCourse>  assignmentsPerCourseList     = new List<AssignmentsPerCourse>
            {
                new AssignmentsPerCourse(courseList[0], new Assignment("Private School Assignment", "Console application which entries some data for a private school", new DateTime(2020, 11, 25), 20.0f, 80.0f)),
                new AssignmentsPerCourse(courseList[1], new Assignment("Private School Assignment", "Console application which entries some data for a private school", new DateTime(2020, 11, 25), 20.0f, 80.0f))
            };
            List<Student>               multipleCourseStudents       = new List<Student>();
            List<AssignmentsPerStudent> assignmentsPerStudentsList   = new List<AssignmentsPerStudent>();

            MyAppUtils.Start(assignmentsList, studentList, trainerList, courseList, studentsPerCourseList, trainersPerCourseList, assignmentsPerCourseList, multipleCourseStudents, assignmentsPerStudentsList);
        }
    }
}
