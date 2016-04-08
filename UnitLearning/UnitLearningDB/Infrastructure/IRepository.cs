using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    public interface IRepository
    {
        // Получение списка курсов
        IEnumerable<Course> GetAllCources();
        IEnumerable<Course> GetAllCourcesByDirection(Direction direct);

        // Получение курса по коду
        Course GetCourceByCode(string code);

        // Список преподавателей
        IEnumerable<Teacher> GetAllTeacher();

        // Расписание курсов
        Shedule GetShedule();
    }
}
