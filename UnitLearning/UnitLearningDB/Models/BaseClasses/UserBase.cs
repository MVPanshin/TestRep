using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UnitLearningDB
{
    public abstract class UserBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public IPrincipal User { get; set; }

        // Альтернативный способ входа
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        public byte[] Photo { get; set; }

        public virtual void ChangePassword(string newPassword)
        {
            if (newPassword.Length > 4)
            {
                this.Password = newPassword;
            }
            else {
                throw new ArgumentException("Пароль не соответствует требованиям!");
            }
        }
    }
}
