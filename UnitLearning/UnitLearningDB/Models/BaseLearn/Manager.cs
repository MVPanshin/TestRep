using System.Collections.Generic;

namespace UnitLearningDB
{
    public class Manager: UserBase
    {
        public int ManagerID { get; set; }
        
        // Для связи с доменом UNIT
        public string DomainLogin { get; set; }
        public string SID { get; set; }

        public virtual IEnumerable<Role> Roles { get; set; }
    }
}