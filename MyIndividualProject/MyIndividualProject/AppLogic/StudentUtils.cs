using MyIndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.AppLogic
{
    static class StudentUtils
    {
        public static Student GetStudentDetails()
        {
            Student tempObj = new Student();

            tempObj.FirstName   = MyAppUtils.AskDetails("What is student's name?");
            if (tempObj.FirstName == "")
                return (tempObj = DefaultEntry());
            tempObj.LastName    = MyAppUtils.AskDetails("What is student's surname?");
            tempObj.DateOfBirth = Convert.ToDateTime(MyAppUtils.AskDetails("What is the date of birth?"));
            tempObj.TuitionFees = Convert.ToDouble(MyAppUtils.AskDetails("How much does the student pay?"));
            return (tempObj);
        }

        public static Student DefaultEntry()
        {
            Student tempObj = new Student();
            Random rndNumber = new Random();
            string[] firstName = new string[] { "Jack", "Jim", "Bob" };
            string[] lastName = new string[] { "Black", "Gordon", "Ross" };
            DateTime[] dateOfBirth = new DateTime[] { new DateTime(1995, 5, 23), new DateTime(1999, 11, 28), new DateTime(1992, 3, 14) };
            int i = rndNumber.Next(0, 3);

            tempObj.FirstName   = firstName[i];
            tempObj.LastName    = lastName[i];
            tempObj.DateOfBirth = dateOfBirth[i];
            tempObj.TuitionFees = 2000.0f;

            return (tempObj);
        }

        public static void PrintStudentsList(List<Student> tempList)
        {
            Console.WriteLine("\n~~~~~~~~Students List~~~~~~~~\n");
            foreach (Student temp in tempList)
            {
                Console.WriteLine(temp);
                Console.WriteLine("--------------------------------------------");
            }
        }

        public static void StudentEntry(int noOfEntries, List<Student> studentList, List<StudentsPerCourse> studentsPerCourseList, List<AssignmentsPerCourse> assignmentsPerCourseList, List<AssignmentsPerStudent> assignmentsPerStudentList)
        {
            for (int i = 0; i < noOfEntries; i++)
            {
                Console.WriteLine($"\n---Entry no{i + 1}---\n");
                Student temp = StudentUtils.GetStudentDetails();
                studentList.Add(temp);
                StudentsPerCourseListUtils.AddStudentToCourse(studentsPerCourseList, temp);
                AssignmentsPerStudentUtils.AddStudentToAssignmentsPerStudentList(temp, studentsPerCourseList, assignmentsPerCourseList, assignmentsPerStudentList);
            }
        }

        public static void AddExistingStudentToASecondCourse(int noOfEntries, List<Student> studentsList, List<StudentsPerCourse> studentsPerCourseList, List<Student> multipleCourseStudents)
        {
            int option;
            for (int j = 0; j < noOfEntries; j++)
            {
                while (true)
                {
                    Console.WriteLine();
                    for (int i = 0; i < studentsList.Count; i++)
                        Console.WriteLine($"{i + 1}. {studentsList[i]}");
                    do
                    {
                        Console.Write("Choose the student that you want to add: ");
                        option = Convert.ToInt32(Console.ReadLine());
                    } while (option < 1 || option > studentsList.Count);

                    Student tempStudent = studentsList[option - 1];
                    option = 0;

                    Console.WriteLine();
                    for (int i = 0; i < studentsPerCourseList.Count; i++)
                        Console.WriteLine($"{i + 1}. {studentsPerCourseList[i].Course}");


                    do
                    {
                        Console.Write("Choose the course that you want to add the student: ");
                        option = Convert.ToInt32(Console.ReadLine());
                    } while (option < 1 || option > studentsPerCourseList.Count);

                    List<Student> tempList = studentsPerCourseList[option - 1].StudentsList;
                    bool isEnrolled = false;
                    for (int i = 0; i < studentsPerCourseList[option - 1].StudentsList.Count; i++)
                    {
                        if (tempStudent.AreEquals(studentsPerCourseList[option - 1].StudentsList[i]))
                        {
                            Console.WriteLine("Student is already enrolled in this course");
                            isEnrolled = true;
                            break;
                        }
                    }

                    if (!isEnrolled)
                    {
                        studentsPerCourseList[option - 1].StudentsList.Add(tempStudent);
                        AddStudentToMultipleCourseList(tempStudent, multipleCourseStudents);
                        break;
                    }
                }
            }
        }

        public static void AddStudentToMultipleCourseList(Student tempStudent, List<Student> multipleCourseStudents)
        {
            bool isInTheList = false;

            foreach (Student student in multipleCourseStudents)
                if (student.AreEquals(tempStudent))
                    isInTheList = true;

            if (!isInTheList)
                multipleCourseStudents.Add(tempStudent);
        }


    }
}
