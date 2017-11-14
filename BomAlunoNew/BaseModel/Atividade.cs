using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
    class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        [ForeignKey("_Tipo")]
        public int TipoID { get; set; }

        public Tipo _Tipo { get; set; }
    }
}
