using System;

namespace UnitLearningDB
{
    public class Shedule
    {
        public int SheduleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual StatusCode StatusCode { get; set; }

        // куратор курса
        public virtual int? ManagerID { get; set; }
        public virtual Manager Manger { get; set; }

        // Длительность курса
        public int Duration { get; set; }

        // Этап курса (например если курс проходит по выходным)
        public int CurrentState { get; set; }
        public int FullState { get; set; }

        // Какой курс идет
        public virtual int? CourseID { get; set; }
        public virtual Course Course { get; set; }

        // Кокой препод читает
        public virtual int? TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}