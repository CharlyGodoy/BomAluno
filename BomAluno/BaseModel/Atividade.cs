using System;
using System.Collections.Generic;
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

		public int TipoID { get; set; }

		public Tipo _Tipo { get; set; }

	}

}
