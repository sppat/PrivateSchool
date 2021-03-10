using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.Models
{
    class Trainer
    {
        private string _firstname;
        private string _lastname;
        private string _subject;

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

        public string Subject 
        { 
            get { return (this._subject); } 
            set { this._subject = value; } 
        }

        public Trainer() { }

        public Trainer(string initFirstName, string initLastName, string initSubject)
        {
            this.FirstName = initFirstName;
            this.LastName = initLastName;
            this.Subject = initSubject;
        }

        public override string ToString()
        {
            return ($"First name: {_firstname}, Last name: {_lastname}, Subject: {_subject}");
        }

        public bool AreEqual(Trainer obj)
        {
            if (this.FirstName == obj.FirstName && this.LastName == obj.LastName && this.Subject == obj.Subject)
                return (true);
            else
                return (false);
        }
    }
}
