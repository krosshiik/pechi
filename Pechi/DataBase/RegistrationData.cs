using System.ComponentModel.DataAnnotations;

namespace Pechi.DataBase
{
    public class RegistrationData
    {
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
