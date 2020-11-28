using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    [Table("Professor")]
    public class Professor : BaseModel
    {
        public int Matricula { get; set; }

        public DateTime DataIngresso { get; set; }

        public string Senha { get; set; }

        public Disciplina Disciplina { get; set; }
    }
}
