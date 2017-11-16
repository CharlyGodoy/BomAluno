using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
   public class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public int TipoID { get; set; }

        [ForeignKey("TipoID")]
        public virtual Tipo _Tipo { get; set; }

        public int MateriaID { get; set; }

        [ForeignKey("MateriaID")]
        public virtual Materia _MateriaID { get; set; }


    }
}
