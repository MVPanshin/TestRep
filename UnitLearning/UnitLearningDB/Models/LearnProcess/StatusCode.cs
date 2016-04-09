namespace UnitLearningDB
{
    // Запланированный, Идет набор, Снятый, Прошедший
    public enum StatusEnum { Open, Planned, Closed, Cancelled, Transferred }

    public class StatusCode
    {
        public StatusCode(StatusEnum status)
        {
            this._status = status;
        }

        public int StatusCodeID { get; set; }
        private StatusEnum _status;
        
        public string Status
        {
            get
            {
                return this._status.ToString();
            }
        }
    }
}