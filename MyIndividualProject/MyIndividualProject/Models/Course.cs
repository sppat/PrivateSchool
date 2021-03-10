using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.Models
{
    class Course
    {
        private protected string   _title;
        private protected string   _stream;
        private protected string   _type;
        private protected DateTime _start_date;
        private protected DateTime _end_date;

        public Course()
        {

        }

        public Course(string initStream, string initType, DateTime initStartDate, DateTime initEndDate)
        {
            
            this.Stream    = initStream;
            this.Type      = initType;
            this.Title     = "CB12 " + this.Type + " " + this.Stream;
            this.StartDate = initStartDate;
            this.EndDate   = initEndDate;
        }

        public string Title
        {
            get { return (this._title); }
            set { this._title = value; }
        }

        public string Stream
        {
            get { return (this._stream); }
            set { this._stream = value; }
        }

        public string Type
        {
            get { return (this._type); }
            set { this._type = value; }
        }

        public DateTime StartDate
        {
            get { return (this._start_date); }
            set { this._start_date = value; }
        }

        public DateTime EndDate
        {
            get { return (this._end_date); }
            set { this._end_date = value; }
        }

        public override string ToString()
        {
            return ($"{_title}, Start Date: {_start_date.ToString("d")}, " +
                $"End Date: {_end_date.ToString("d")}");
        }
    }
}
