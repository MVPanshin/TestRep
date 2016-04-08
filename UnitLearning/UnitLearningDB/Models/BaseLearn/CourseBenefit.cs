using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    // Таблица в которой будут прописаны причины, по которым курс будет полезен клиенту
    public class CourseBenefit
    {
        public int CourseBenefitID { get; set; }

        public virtual int CourseID {get;set;}
        public virtual Course Course { get;set;}

        public string Benefit { get; set; }

    }
}
