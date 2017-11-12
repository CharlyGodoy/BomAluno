using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
	class Materia
	{
		public int MateriaID { get; set; }

		public string Nome { get; set; }

		public string Descricao { get; set; }

		public bool Ativo { get; set; }

		public int AtividadeID { get; set; }

		public List<Atividade> _Atividade { get; set; }

	}
}
