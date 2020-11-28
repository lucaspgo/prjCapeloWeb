using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System;

namespace prjCapeloWeb.Models
{
    [Table("Alunos")]
    public class Aluno : BaseModel
    {     
        public int Matricula { get; set; }

        public DateTime DataIngresso { get; set; }

        public string Senha { get; set; }
    }
}
