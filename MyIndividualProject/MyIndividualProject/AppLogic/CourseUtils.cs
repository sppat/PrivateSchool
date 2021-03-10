using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.Models;

namespace MyIndividualProject.AppLogic
{
    static class CourseUtils
    {
        public static Course GetCourseDetails()
        {
            Course tempObj = new Course();

            tempObj.Stream    = CourseStream();
            tempObj.Type      = CourseType();
            tempObj.Title     = "CB12 " + tempObj.Stream + " " + tempObj.Type;
            tempObj.StartDate = Convert.ToDateTime(MyAppUtils.AskDetails("When is the start date?"));
            tempObj.EndDate   = Convert.ToDateTime(MyAppUtils.AskDetails("When is the end date?"));
            
            return (tempObj);
        }

        public static string CourseStream()
        {
            string temp = "";
            string[] array = new string[] { "C#", "Java", "JavaScript", "Python" };
            int choice;

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{i + 1}. {array[i]}");
            do
            {
                Console.Write("Choose an option: ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > 4);

            return (temp = array[choice - 1]);
        }

        public static string CourseType()
        {
            string temp = "";
            string[] array = new string[] { "Part-Time", "Full-Time" };
            int choice;

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{i + 1}. {array[i]}");
            do
            {
                Console.Write("Choose an option: ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > 4);

            return (temp = array[choice - 1]);
        }

        public static void PrintCoursesList(List<Course> tempList)
        {
            Console.WriteLine("\n~~~~~~~~Courses List~~~~~~~~\n");
            foreach (Course temp in tempList)
            {
                Console.WriteLine(temp);
                Console.WriteLine("--------------------------------------------");
            }
        }

        public static void CourseEntry(int noOfEntries, List<Course> courseList, List<StudentsPerCourse> studentsPerCourseList,
            List<TrainersPerCourse> trainersPerCourseList, List<AssignmentsPerCourse> assignmentsPerCourseList)
        {
            for (int i = 0; i < noOfEntries; i++)
            {
                Console.WriteLine($"\n---Entry no{i + 1}---\n");
                Course temp = CourseUtils.GetCourseDetails();
                courseList.Add(temp);
                studentsPerCourseList.Add(new StudentsPerCourse(temp));
                trainersPerCourseList.Add(new TrainersPerCourse(temp));
                assignmentsPerCourseList.Add(new AssignmentsPerCourse(temp));
            }
        }
    }
}
