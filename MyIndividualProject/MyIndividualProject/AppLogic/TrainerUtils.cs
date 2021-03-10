using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIndividualProject.Models;

namespace MyIndividualProject.AppLogic
{
    static class TrainerUtils
    {
        public static Trainer GetTrainerDetails()
        {
            Trainer tempObj = new Trainer();

            tempObj.FirstName = MyAppUtils.AskDetails("What is the teacher's name?");
            if (tempObj.FirstName == "")
                return (tempObj = DefaultEntry());
            tempObj.LastName  = MyAppUtils.AskDetails("What is the teacher's surname?");
            tempObj.Subject   = MyAppUtils.AskDetails("What subject does he teach?", new List<string>() { "C#", "Java", "JavaScript", "Python" });

            return (tempObj);
        }

        public static Trainer DefaultEntry()
        {
            Trainer tempObj = new Trainer();
            Random rndNumber = new Random();

            string[] firstNames = new string[] { "George", "Steve", "Donald", "Bill", "Linus" };
            string[] lastNames  = new string[] { "Pasparakis", "Jobs", "Knuth", "Gates", "Torvalds" };
            string[] subjects   = new string[] { "C#", "Java", "Python", "JavaScript" };
            int i               = rndNumber.Next(0, 5);
            int k               = rndNumber.Next(0, 4);

            tempObj.FirstName = firstNames[i];
            tempObj.LastName  = lastNames[i];
            tempObj.Subject   = subjects[k];

            return (tempObj);
        }

        public static void PrintTrainersList(List<Trainer> tempList)
        {
            Console.WriteLine("\n~~~~~~~~Trainers List~~~~~~~~\n");
            foreach (Trainer temp in tempList)
            {                
                Console.WriteLine(temp);
                Console.WriteLine("--------------------------------------------");
            }
        }

        public static void TrainerEntry(int noOfEntries, List<Trainer> trainerList, List<TrainersPerCourse> trainersPerCourseList)
        {
            for (int i = 0; i < noOfEntries; i++)
            {
                Console.WriteLine($"\n---Entry no{i + 1}---\n");
                Trainer temp = TrainerUtils.GetTrainerDetails();
                trainerList.Add(temp);
                TrainersPerCourseListUtils.AddTrainerToCourse(trainersPerCourseList, temp);
            }
        }
    }
}
