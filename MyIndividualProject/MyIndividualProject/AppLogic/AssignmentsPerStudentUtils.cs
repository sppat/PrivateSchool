using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.Models;

namespace MyIndividualProject.AppLogic
{
    class AssignmentsPerStudentUtils
    {
        public static void ChooseStudentToPrintAssignments(List<Student> studentsList, List<StudentsPerCourse> studentsPerCourseList, List<AssignmentsPerCourse> assignmentsPerCourseList,
    List<AssignmentsPerStudent> assignmentsPerStudentsList)
        {
            int option;
            Console.WriteLine();
            if (studentsList.Count == 0)
                Console.WriteLine("There are no students.");
            else 
            {
                for (int i = 0; i < studentsList.Count; i++)
                    Console.WriteLine($"{i + 1}. {studentsList[i]}");

                do
                {
                    Console.Write("Choose a student to print his assignments: ");
                    option = Convert.ToInt32(Console.ReadLine());
                } while (option < 1 || option > studentsList.Count);
                FindAssignmentsPerStudent(studentsList[option - 1], assignmentsPerStudentsList);
            }
        }

        public static void AddAssignmentToStudent(List<StudentsPerCourse> studentsPerCourseList, List<AssignmentsPerStudent> assignmentsPerStudentList, Course course, Assignment assignment)
        {
            List<Student> tempStudentsList = new List<Student>();

            for (int i = 0; i < studentsPerCourseList.Count; i++)
                if (studentsPerCourseList[i].Course.Equals(course))
                    for (int j = 0; j < studentsPerCourseList[i].StudentsList.Count; j++)
                        tempStudentsList.Add(studentsPerCourseList[i].StudentsList[j]);

            for (int i = 0; i < assignmentsPerStudentList.Count; i++)
                for (int j = 0; j < tempStudentsList.Count; j++)
                    if (assignmentsPerStudentList[i].Student.Equals(tempStudentsList[j]))
                        assignmentsPerStudentList[i].StudentAssignments.Add(assignment);
        }

        public static void FindAssignmentsPerStudent(Student student, List<AssignmentsPerStudent> assignmentsPerStudentsList)
        {
            Console.WriteLine();
            for (int i = 0; i < assignmentsPerStudentsList.Count; i++)
                if (student.AreEquals(assignmentsPerStudentsList[i].Student))
                    foreach (Assignment assignment in assignmentsPerStudentsList[i].StudentAssignments)
                        Console.WriteLine(assignment);
        }

        public static void AddStudentToAssignmentsPerStudentList(Student temp, List<StudentsPerCourse> studentsPerCourseList,
            List<AssignmentsPerCourse> assignmentsPerCourseList, List<AssignmentsPerStudent> assignmesPerStudentList)
        {
            List<Course> CoursesPerStudent = new List<Course>();
            List<Assignment> studentAssignments = new List<Assignment>();

            for (int i = 0; i < studentsPerCourseList.Count; i++)
                for (int j = 0; j < studentsPerCourseList[i].StudentsList.Count; j++)
                    if (temp.AreEquals(studentsPerCourseList[i].StudentsList[j]))
                        CoursesPerStudent.Add(studentsPerCourseList[i].Course);

            for (int i = 0; i < CoursesPerStudent.Count; i++)
                for (int j = 0; j < assignmentsPerCourseList.Count; j++)
                    if (CoursesPerStudent[i].Equals(assignmentsPerCourseList[j].Course))
                        foreach (Assignment assignment in assignmentsPerCourseList[j].AssignmentsList)
                            studentAssignments.Add(assignment);

            assignmesPerStudentList.Add(new AssignmentsPerStudent(temp, studentAssignments));
        }

        public static void PrintStudentsWithSubmissionDate(List<AssignmentsPerStudent> assignmentsPerStudentsList)
        {
            DateTime tempDateTime;

            Console.WriteLine();
            Console.Write("Provide a submission date: ");
            tempDateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            switch (tempDateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    tempDateTime = tempDateTime.AddDays(-6);
                    break;
                case DayOfWeek.Saturday:
                    tempDateTime = tempDateTime.AddDays(-5);
                    break;
                case DayOfWeek.Friday:
                    tempDateTime = tempDateTime.AddDays(-4);
                    break;
                case DayOfWeek.Thursday:
                    tempDateTime = tempDateTime.AddDays(-3);
                    break;
                case DayOfWeek.Wednesday:
                    tempDateTime = tempDateTime.AddDays(-2);
                    break;
                case DayOfWeek.Tuesday:
                    tempDateTime = tempDateTime.AddDays(-1);
                    break;
                default:
                    break;
            }

            var compareDateTime = tempDateTime;
            while (!Equals(tempDateTime, compareDateTime.AddDays(5)))
            {
                Console.WriteLine($"Assignments for {tempDateTime.ToString("D", CultureInfo.CreateSpecificCulture("en-us"))}:");
                Console.WriteLine("----------------------------------------");
                for (int j = 0; j < assignmentsPerStudentsList.Count; j++)
                {
                    for (int k = 0; k < assignmentsPerStudentsList[j].StudentAssignments.Count; k++)
                    {
                        if (DateTime.Compare(assignmentsPerStudentsList[j].StudentAssignments[k].SubDateTime, tempDateTime) == 0 && assignmentsPerStudentsList[j].Student.FirstName != "")
                        {
                            Console.WriteLine(assignmentsPerStudentsList[j].Student);
                            break;
                        }
                    }
                }
                Console.WriteLine();
                tempDateTime = tempDateTime.AddDays(1);
            }

        }
    }
}
