using System.ComponentModel.DataAnnotations;

namespace Pechi.DataBase
{
    public class Agregati
    {
        [Key]
        public int ID { get; set; }
        public string Название_агрегата { get; set; }
        public string Тип { get; set; }
    }
}
