using System.Collections.Generic;

namespace UnitLearningDB
{
    public class Role
    {
        public int RoleID { get; set; }
        public string TitleRole { get; set; }
        public string DescriptionsRole { get; set; }

        // Базовая роль
        public virtual Role BaseRole { get; set; }
        // Роли наследники
        public virtual IEnumerable<Role> InternalRoles { get; set; }
    }

}