using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pechi.DataBase
{
    public class Tipi
    {
        [Key]
        public int ID { get; set; }
        public string Название_простоя { get; set; }
        public string? Описание { get; set; }
    }
}
