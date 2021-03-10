using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.Models;

namespace MyIndividualProject.AppLogic
{
    static class StudentsPerCourseListUtils
    {
        public static void AddStudentToCourse(List<StudentsPerCourse> studentsPerCourseList, Student temp)
        {
            int choice;

            Console.WriteLine("\n...In which course would you like to add the new student?");
            for (int i = 0; i < studentsPerCourseList.Count; i++)
                Console.WriteLine($"{i + 1}. {studentsPerCourseList[i].Course}");

            do
            {
                Console.Write("Choose a course: ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > studentsPerCourseList.Count);

            studentsPerCourseList[choice - 1].AddStudentToCourseList(temp);
        }

        public static void PrintStudentPerCourse(List<StudentsPerCourse> studentsPerCourseList)
        {
            int choice;

            for (int i = 0; i < studentsPerCourseList.Count; i++)
                Console.WriteLine($"{i + 1}. {studentsPerCourseList[i].Course}");
            do
            {
                Console.Write("Choose the list you would like to print: ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > studentsPerCourseList.Count);

            Console.Clear();
            studentsPerCourseList[choice - 1].PrintStudentsPerCourseList();
        }
    }
}
