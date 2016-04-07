using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    public enum Direct { Database, Linux, Windows, Java, Csharp, VBA }

    public class Direction
    {
        public int DirectionID { get; set; }

        public Direct direction;
        public string DirectionName
        {
            get { return direction.ToString(); }
        }
    }
}
