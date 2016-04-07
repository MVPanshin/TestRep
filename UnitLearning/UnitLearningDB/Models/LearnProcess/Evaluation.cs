using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    public class Evaluation
    {
        public int EvaluationsID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Shedule Shedule { get; set; }

        // Список оценок слушателя
        //public 
    }
}
