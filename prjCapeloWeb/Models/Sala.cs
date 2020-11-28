using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    [Table("Salas")]
    public class Sala : BaseModel
    {
        public string Nome { get; set; }
    }
}
