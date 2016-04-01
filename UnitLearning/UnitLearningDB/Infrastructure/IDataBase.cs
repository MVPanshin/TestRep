using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    public interface IDataBase
    {
        // Получение списка курсов
        ICollection<Course> GetAllCources();
        ICollection<Course> GetAllCourcesByDirection(Direction direct);

        // Получение курса по коду
        Course GetCourceByCode(string code);

        // Список преподавателей
        ICollection<Teacher> GetAllTeacher();

        // Расписание курсов
        Shedule GetShedule();
    }
}
