using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    public abstract class BaseMan
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        // Альтернативный способ входа
        public string Login { get; set; }
        public string Password { get; set; }

        public byte[] Photo { get; set; }
    }
}
