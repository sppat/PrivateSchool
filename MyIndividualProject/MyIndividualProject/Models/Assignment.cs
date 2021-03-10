using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.Models
{
    class Assignment
    {
        private string   _title;
        private string   _description;
        private DateTime _subdatetime;
        private float    _oralmark;
        private float    _totalmark;

        public string Title
        {
            get { return (this._title); }
            set { this._title = value; }
        }

        public string Description
        {
            get { return (this._description); }
            set { this._description = value; }
        }

        public DateTime SubDateTime
        {
            get { return (this._subdatetime); }
            set { this._subdatetime = value; }
        }

        public float OralMark
        {
            get { return (this._oralmark); }
            set { this._oralmark = value; }
        }

        public float TotalMark
        {
            get { return (this._totalmark); }
            set { this._totalmark = value; }
        }

        public Assignment() { }

        public Assignment(string initTitle, string initDescription, DateTime initDateTime, float initOralMark, float initTotalMark)
        {
            this.Title = initTitle;
            this.Description = initDescription;
            this.SubDateTime = initDateTime;
            this.OralMark    = initOralMark;
            this.TotalMark   = initTotalMark;
        }

        public override string ToString()
        {
            return ($"Title: {_title}, Description: {_description}, Submission Date: {_subdatetime.ToString("d")}, " +
                $"Oral Mark: {_oralmark}, Total Mark: {_totalmark}");
        }
    }
}
