using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.Models;

namespace MyIndividualProject.AppLogic
{
    static class AssignmentsUtils
    {
        public static Assignment GetAssignmentDetails()
        {
            Assignment tempObj = new Assignment();

            tempObj.Title       = MyAppUtils.AskDetails("What is the title of the assignment?");
            if (tempObj.Title == "")
                return (tempObj = DefaultEntry());
            tempObj.Description = MyAppUtils.AskDetails("What is description of the assignment?");
            tempObj.SubDateTime = Convert.ToDateTime(MyAppUtils.AskDetails("When should the assignment be subbmitted?"));
            tempObj.OralMark    = Convert.ToSingle(MyAppUtils.AskDetails("How much is the oral mark?"));
            tempObj.TotalMark   = Convert.ToSingle(MyAppUtils.AskDetails("How much is the total mark?"));
            return (tempObj);
        }

        public static Assignment DefaultEntry()
        {
            Assignment tempObj = new Assignment();

            tempObj.Title       = "Private School Assignment";
            tempObj.Description = "Console application which entries some data for a private school";
            tempObj.SubDateTime = new DateTime(2020, 11, 25);
            tempObj.OralMark    = 20.0f;
            tempObj.TotalMark   = 80.0f;

            return tempObj;
        }

        public static void PrintAssignmentsList(List<Assignment> tempList)
        {
            Console.WriteLine("\n~~~~~~~~Assignments List~~~~~~~~\n");
            foreach (Assignment temp in tempList)
            {
                Console.WriteLine(temp);
                Console.WriteLine("--------------------------------------------");
            }
        }

        public static void AssignmentEntry(int noOfEntries, List<Assignment> assignmentList, List<AssignmentsPerCourse> assignmentsPerCourseList, List<AssignmentsPerStudent> assignmentsPerStudentsList, List<StudentsPerCourse> studentsPerCourseList)
        {
            for (int i = 0; i < noOfEntries; i++)
            {
                Console.WriteLine($"\n---Entry no{i + 1}---\n");
                Assignment temp = AssignmentsUtils.GetAssignmentDetails();
                assignmentList.Add(temp);
                AssignmentsPerCourseListUtils.AddAssignmentsToCourse(assignmentsPerCourseList, studentsPerCourseList, assignmentsPerStudentsList ,temp);
                
            }
        } 
    }
}
