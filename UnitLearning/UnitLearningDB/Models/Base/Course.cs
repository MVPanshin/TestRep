using System.Collections.Generic;

namespace UnitLearningDB
{
    public class Course
    {
        public int Id { get;}
        public string Code { get; set; }
        public string FullName { get; set; }
        public List<Direction> Directions { get; set; }
        
        //public virtual Vendor CourseVendor { get; set; }
    }
}