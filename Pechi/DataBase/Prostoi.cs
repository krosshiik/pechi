using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pechi.DataBase
{
    public class Prostoi
    {
        [Key]
        public int ID { get; set; }
        public int ID_Агрегата { get; set; }
        public int ID_Типа { get; set; }
        public DateTime Дата_начала_простоя { get; set; }
        public DateTime Дата_окончания_простоя_план { get; set; }
        public DateTime Дата_окончания_простоя_факт { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Время_простоя_план { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Время_простоя_факт { get; set; }
        public string? Описание { get; set; }
        public int ID_Лица { get; set; }
    }
}
