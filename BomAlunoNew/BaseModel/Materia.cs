using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
    public class Materia
    {
        [Key]
        public int MateriaID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }
 
        public int LoginID { get; set; }

        [ForeignKey("LoginID")]
        public virtual Login _LoginID { get; set; }


    }
}
