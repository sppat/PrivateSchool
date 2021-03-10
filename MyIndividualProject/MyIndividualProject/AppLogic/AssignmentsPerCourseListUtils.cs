using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.Models;

namespace MyIndividualProject.AppLogic
{
    class AssignmentsPerCourseListUtils
    {
        public static void AddAssignmentsToCourse(List<AssignmentsPerCourse> assignmentsPerCourseList,List<StudentsPerCourse> studentsPerCourseList,List<AssignmentsPerStudent> assignmentsPerStudentList, Assignment temp)
        {
            int choice;

            Console.WriteLine("\n...In which course would you like to add the new assignment?");
            for (int i = 0; i < assignmentsPerCourseList.Count; i++)
                Console.WriteLine($"{i + 1}. {assignmentsPerCourseList[i].Course}");

            do
            {
                Console.Write("Choose a course: ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > assignmentsPerCourseList.Count);

            assignmentsPerCourseList[choice - 1].AddAssignmentToCourseList(temp);
            AssignmentsPerStudentUtils.AddAssignmentToStudent(studentsPerCourseList, assignmentsPerStudentList,assignmentsPerCourseList[choice - 1].Course, temp);
        }

        public static void PrintAssignmentPerCourse(List<AssignmentsPerCourse> assignmentsPerCourseList)
        {
            int choice;

            for (int i = 0; i < assignmentsPerCourseList.Count; i++)
                Console.WriteLine($"{i + 1}. {assignmentsPerCourseList[i].Course}");
            do
            {
                Console.Write("Choose the list you would like to print: ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > assignmentsPerCourseList.Count);

            Console.Clear();
            assignmentsPerCourseList[choice - 1].PrintAssignmentsPerCourseList();
        }
    }
}
