using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
	class Tipo
	{
		[Key]
		public int TipoID { get; set; }

		public string Nome { get; set; }

		public Boolean Ativo { get; set; }

	}
}
