using System.Collections.Generic;

namespace UnitLearningDB
{
    public class Manager
    {
        public int ManagerID { get; set; }
        
        // Для связи с доменом UNIT
        public string DomainLogin { get; set; }
        public string SID { get; set; }
        
        // Альтернативный способ входа
        public string Login { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public virtual IEnumerable<Role> Roles { get; set; }
    }
}