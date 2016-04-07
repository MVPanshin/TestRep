namespace UnitLearningDB
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        public int CityID { get; set; }
        public virtual City City { get; set; }
       
    }
}