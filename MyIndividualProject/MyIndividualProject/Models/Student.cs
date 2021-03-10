using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.Models
{
    class Student
    {
        private string   _firstname;
        private string   _lastname;
        private DateTime _dateofbirth;
        private double   _tuitionfees;
    
        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value; }
        }

        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value; }
        }

        public DateTime DateOfBirth
        {
            get { return (this._dateofbirth); }
            set { this._dateofbirth = value; }
        }

        public double TuitionFees
        {
            get { return (this._tuitionfees); }
            set { this._tuitionfees = value; }
        }

        public override string ToString()
        {
            return ($"First name: {_firstname}, Last name: {_lastname}, " +
                $"Date of birth {_dateofbirth.ToString("d")}, Tuition fees: {_tuitionfees}");
        }

        public bool AreEquals(Student obj)
        {
            if (this.FirstName == obj.FirstName && this.LastName == obj.LastName && this.DateOfBirth == obj.DateOfBirth && this.TuitionFees == obj.TuitionFees)
                return true;
            return false;
        }
    }
}
