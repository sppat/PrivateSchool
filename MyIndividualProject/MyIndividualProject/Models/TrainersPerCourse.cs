using MyIndividualProject.AppLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.Models
{
    class TrainersPerCourse
    {
        private Course _course;
        private List<Trainer> _trainerslist = new List<Trainer>();

        public Course Course
        {
            get { return this._course; }
            set { this._course = value; }
        }

        public List<Trainer> TrainersList 
        {
            get { return (this._trainerslist); }
            private set { this._trainerslist = value; }
        } 

        public TrainersPerCourse() { }

        public TrainersPerCourse(Course initCourse)
        {
            this._course = initCourse;
        }

        public TrainersPerCourse(Course initCourse, Trainer initTrainer)
        {
            this.Course = initCourse;
            this.AddTrainerToCourseList(initTrainer);
        }

        public void AddTrainerToCourseList(Trainer newTrainer)
        {
            this._trainerslist.Add(newTrainer);
        }

        public void PrintTrainersPerCourseList()
        {
            Console.WriteLine($"Trainers in {this._course}:\n");
            foreach (Trainer trainer in this._trainerslist)
            {
                Console.WriteLine(trainer);
                Console.WriteLine("--------------------------------------------");
            }
            Console.WriteLine();
        }
    }
}
