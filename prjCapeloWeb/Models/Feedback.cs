using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    [Table("Feedbacks")]
    public class Feedback : BaseModel
    {
        public string Texto { get; set; }
    }
}
