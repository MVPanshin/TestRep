using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    public interface IRepository
    {
        #region UserBase
        UserBase FindUser(string login, string password);
        #endregion

        #region Курсы и все что с ними связано
        // Получение списка курсов
        IEnumerable<Course> GetAllCources();
        IEnumerable<Course> GetAllCourcesByDirection(Direction direct);

        // Список курсов на которых отучился Слушатель/Компания
        IEnumerable<Course> GetAllCourcesForStudent(int studentID);
        IEnumerable<Course> GetAllCourcesForCompany(int companyID);

        // Получение курса по коду
        Course GetCourceByCode(string code);

        // DML операции с курсами
        void AddOrUpdateCourse(Course course);
        void DeleteCourse(Course course);

        void UpdateCoursePrice(decimal newPrice, params int[] courseID);
        #endregion

        #region Расписание
        // Расписание курсов за разное время
        IEnumerable<Shedule> GetSheduleForCurrentYear();
        IEnumerable<Shedule> GetSheduleForCustomYear();
        IEnumerable<Shedule> GetSheduleForCurrentMonth();
        IEnumerable<Shedule> GetSheduleForCustomMonth();
        IEnumerable<Shedule> GetSheduleForCurrentWeek();
        IEnumerable<Shedule> GetSheduleForCustomWeek();
        IEnumerable<Shedule> GetSheduleForRange(DateTime start, DateTime end);

        //Добавление курса в расписание
        void AddOrUpdateCourseToShedule(Shedule shedule, DateTime startDate, DateTime? endDate = null, 
                int? managerID = null, int? teacherID = null,
                StatusCode statusCode = null, int state = 1, int fullState = 1);

        //Изменение статуса курса в расписании
        void ChangeStatusCourseToShedule(Shedule shedule, StatusEnum status);
        #endregion

        #region Работа с Составом УЦ
        // Список преподавателей
        IEnumerable<Teacher> GetAllTeacher();
        Teacher GetTeacherByID(int teacherID);

        void AddOrUpdateTeacher(Teacher teacher);
        #endregion

        #region Клиенты
        IEnumerable<Company> GetCompanies();
        Company GetCompanyById(int companyID);
        void AddOrUpdateCompany(Company company);

        IEnumerable<Student> GetStudents();
        IEnumerable<Student> GetStudentsForCompany(int companyID);
        #endregion
    }
}
