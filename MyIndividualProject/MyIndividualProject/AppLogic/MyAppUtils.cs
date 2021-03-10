using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.Models;

namespace MyIndividualProject.AppLogic
{
    static class MyAppUtils
    {
        public static void StartApplication()
        {
            Console.WriteLine("~~~Private School Console Application~~~");
            Console.WriteLine("----------------------------------------\n");
        }

        public static void Start(List<Assignment> assignmentList,
            List<Student> studentList, List<Trainer> trainerList, List<Course> courseList, List<StudentsPerCourse> studentsPerCourseList,
            List<TrainersPerCourse> trainersPerCourseList, List<AssignmentsPerCourse> assignmentsPerCourseList, List<Student> multipleCourseStudents, List<AssignmentsPerStudent> assignmentsPerStudentsList)
        {
            while (true)
            {
                MenuUtils.GeneralMenu();
                int option = MenuUtils.MenuOption("General");

                if (option == 1)
                {
                    Console.Clear();
                    MenuUtils.EntryMenu();
                    AddElement(MenuUtils.MenuOption("Entry"), assignmentList, studentList, trainerList, courseList, studentsPerCourseList, trainersPerCourseList, assignmentsPerCourseList, multipleCourseStudents, assignmentsPerStudentsList);
                    Console.Clear();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    MenuUtils.PrintMenu();
                    PrintList(MenuUtils.MenuOption("Print"), assignmentList, studentList, trainerList, courseList, studentsPerCourseList, trainersPerCourseList, assignmentsPerCourseList, multipleCourseStudents, assignmentsPerStudentsList);
                }
                else
                    break;
            }
        }

        public static void AddElement(int option, List<Assignment> assignmentList,
            List<Student> studentList, List<Trainer> trainerList, List<Course> courseList, List<StudentsPerCourse> studentsPerCourseList,
            List<TrainersPerCourse> trainersPerCourseList, List<AssignmentsPerCourse> assignmentsPerCourseList, List<Student> multipleCourseStudents, List<AssignmentsPerStudent> assignmentsPerStudentsList)
        {
            int noOfEntries;
            do
            {
                Console.Write("How many entries would you like to add? ");
                noOfEntries = Convert.ToInt32(Console.ReadLine());
            } while (noOfEntries < 1);

            switch (option)
            {
                case 1:
                    CourseUtils.CourseEntry(noOfEntries, courseList, studentsPerCourseList, trainersPerCourseList, assignmentsPerCourseList);
                    break;
                case 2:
                    AssignmentsUtils.AssignmentEntry(noOfEntries, assignmentList, assignmentsPerCourseList, assignmentsPerStudentsList, studentsPerCourseList);
                    break;
                case 3:
                    TrainerUtils.TrainerEntry(noOfEntries, trainerList, trainersPerCourseList);
                    break;
                case 4:
                    StudentUtils.StudentEntry(noOfEntries, studentList, studentsPerCourseList, assignmentsPerCourseList, assignmentsPerStudentsList);
                    break;
                case 5:
                    StudentUtils.AddExistingStudentToASecondCourse(noOfEntries, studentList, studentsPerCourseList, multipleCourseStudents);
                    break;
            }
        }

        public static void PrintList(int option, List<Assignment> assignmentList,
            List<Student> studentList, List<Trainer> trainerList, List<Course> courseList, List<StudentsPerCourse> studentsPerCourseList,
            List<TrainersPerCourse> trainersPerCourseList, List<AssignmentsPerCourse> assingmnetsPerCourseList, List<Student> multipleCourseStudents, List<AssignmentsPerStudent> assignmentsPerStudentsList)
        {
            switch (option)
            {
                case 1:
                    CourseUtils.PrintCoursesList(courseList);
                    Console.WriteLine();
                    break;
                case 2:
                    AssignmentsUtils.PrintAssignmentsList(assignmentList);
                    Console.WriteLine();
                    break;
                case 3:
                    TrainerUtils.PrintTrainersList(trainerList);
                    Console.WriteLine();
                    break;
                case 4:
                    StudentUtils.PrintStudentsList(studentList);
                    Console.WriteLine();
                    break;
                case 5:
                    StudentsPerCourseListUtils.PrintStudentPerCourse(studentsPerCourseList);
                    Console.WriteLine();
                    break;
                case 6:
                    TrainersPerCourseListUtils.PrintTrainerPerCourse(trainersPerCourseList);
                    Console.WriteLine();
                    break;
                case 7:
                    AssignmentsPerCourseListUtils.PrintAssignmentPerCourse(assingmnetsPerCourseList);
                    Console.WriteLine();
                    break;
                case 8:
                    StudentUtils.PrintStudentsList(multipleCourseStudents);
                    Console.WriteLine();
                    break;
                case 9:
                    AssignmentsPerStudentUtils.ChooseStudentToPrintAssignments(studentList, studentsPerCourseList, assingmnetsPerCourseList, assignmentsPerStudentsList);
                    Console.WriteLine();
                    break;
                case 10:
                    AssignmentsPerStudentUtils.PrintStudentsWithSubmissionDate(assignmentsPerStudentsList);
                    Console.WriteLine();
                    break;
            }
        }

        public static string AskDetails(string message, List<string> subjects = null)
        {
            string tempString = "";
            int index;
            Console.Write($"{message} ");

            if (subjects != null)
            {
                Console.WriteLine();
                for (int i = 0; i < subjects.Count; i++)
                    Console.WriteLine($"{i + 1}. {subjects.ElementAt(i)}");

                do
                {
                    Console.Write("Choose a number: ");
                    index = Convert.ToInt32(Console.ReadLine());
                } while (index <= 0 || index > subjects.Count);

                tempString = subjects.ElementAt(index - 1);
            }
            else
                do
                {
                    tempString = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(tempString))
                        Console.Write("Only whitespaces entered: ");
                } while (string.IsNullOrWhiteSpace(tempString));
                

            return (tempString);
        }

        
    }
}
