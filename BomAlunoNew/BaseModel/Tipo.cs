using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
    public class Tipo
    {
        public int TipoID { get; set; }

        [Display(Name = "Tipo")]
        public string Nome { get; set; }

        public Boolean Ativo { get; set; }


    }
}
