using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    class VisitCoursesFromShedule
    {
        public virtual Shedule Shedule {get;set;}
        public virtual Student Student { get; set; }
    }
}
