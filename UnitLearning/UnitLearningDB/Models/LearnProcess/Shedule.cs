using System;

namespace UnitLearningDB
{
    public class Shedule
    {
        public int Id { get; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual StatusCode StatusCode { get; set; }

        // куратор курса
        public Manager Manger { get; set; }

        // Длительность курса
        public int Duration { get; set; }

        // Этап курса (например если курс проходит по выходным)
        public int CurrentState { get; set; }
        public int FullState { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}