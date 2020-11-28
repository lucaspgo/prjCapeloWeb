using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using prjCapeloWeb.Models;

namespace prjCapeloWeb.Models
{
    [Table("Aulas")]
    public class Aula : BaseModel
    {
        public Feedback FeedBack { get; set; }
        public Aluno Aluno { get; set; }
        public Professor Professor { get; set; }        
        public Sala Sala { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataInicio { get; set; } 
        public DateTime DataFim { get; set; }

    }
}
