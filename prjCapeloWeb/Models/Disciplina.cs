using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    [Table("Disciplinas")]
    public class Disciplina : BaseModel
    {
        public string Nome { get; set; }

        public string Sigla { get; set; }
    }
}
