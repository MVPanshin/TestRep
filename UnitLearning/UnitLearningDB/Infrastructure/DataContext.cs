using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using UnitLearningDB;

namespace UnitLearningDB.Infrastructure
{
    // Класс БД EntityFramework
    public class DataContext: DbContext
    {
        public DataContext():base("UnitLearningDB")
        {
        }

        // Базовые таблицы (модели Base)
        public DbSet<Course> Courses { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        // Таблицы Клиентов (модели Clients)
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Student> Students { get; set; }

        // Таблицы Учебного процесса (модели LearnProcess)
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Shedule> Shedules { get; set; }
        public DbSet<StatusCode> StatusCodes { get; set; }

    }
}
