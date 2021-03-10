using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.Models;

namespace MyIndividualProject.AppLogic
{
    class TrainersPerCourseListUtils
    {
        public static void AddTrainerToCourse(List<TrainersPerCourse> trainersPerCourseList, Trainer temp)
        {
            int choice;

            Console.WriteLine("\n...In which course would you like to add the new trainer?");
            for (int i = 0; i < trainersPerCourseList.Count; i++)
                Console.WriteLine($"{i + 1}. {trainersPerCourseList[i].Course}");

            do
            {
                Console.Write("Choose a course: ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > trainersPerCourseList.Count);

            for (int i = 0; i < trainersPerCourseList[choice - 1].TrainersList.Count; i++)
                if (trainersPerCourseList[choice - 1].TrainersList[i].AreEqual(temp))
                    Console.WriteLine("Trainer already exists in this course");
                else
                    trainersPerCourseList[choice - 1].AddTrainerToCourseList(temp);

        }

        public static void PrintTrainerPerCourse(List<TrainersPerCourse> trainersPerCourseList)
        {
            int choice;

            for (int i = 0; i < trainersPerCourseList.Count; i++)
                Console.WriteLine($"{i + 1}. {trainersPerCourseList[i].Course}");
            do
            {
                Console.Write("Choose the list you would like to print: ");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 1 || choice > trainersPerCourseList.Count);

            Console.Clear();
            trainersPerCourseList[choice - 1].PrintTrainersPerCourseList();
        }
    }
}
