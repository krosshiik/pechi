using System.ComponentModel.DataAnnotations;

namespace Pechi.DataBase
{
    public class Litsa
    {
        [Key]
        public int ID { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string? Отчество { get; set; }
    }
}
