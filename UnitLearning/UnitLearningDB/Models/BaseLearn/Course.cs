using System.Collections.Generic;

namespace UnitLearningDB
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Code { get; set; }
        public string CourseTitle { get; set; }
        public string Descripttions { get; set; }

        //Длительность курса в часах
        public int Duration { get; set; }

        public virtual IEnumerable<Direction> Directions { get; set; }
        
        //public virtual Vendor CourseVendor { get; set; }
    }
}