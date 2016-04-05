using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB.Infrastructure
{
    class TestDataBase : IDataBase
    {
        public ICollection<Course> GetAllCources()
        {
            throw new NotImplementedException();
        }

        public ICollection<Course> GetAllCourcesByDirection(Direction direct)
        {
            throw new NotImplementedException();
        }

        public ICollection<Teacher> GetAllTeacher()
        {
            throw new NotImplementedException();
        }

        public Course GetCourceByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Shedule GetShedule()
        {
            throw new NotImplementedException();
        }
    }
}
