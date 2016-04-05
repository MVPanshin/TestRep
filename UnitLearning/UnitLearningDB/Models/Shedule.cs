using System;

namespace UnitLearningDB
{
    public class Shedule
    {
        public int Id { get; }
        public DateTime StartDate { get; set; }
        // Длительность курса
        public int Duration { get; set; }
    }
}