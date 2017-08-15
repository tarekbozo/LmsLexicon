using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LmsLexicon.Models.LMS
{
    public class Courses
    {
        public int Id { get; set; }
        public byte NumberOfDays { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}