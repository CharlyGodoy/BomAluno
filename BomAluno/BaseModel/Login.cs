﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel
{
	class Login
	{
		[Key]
		public int LoginID { get; set; }

		public string Nome { get; set; }

		public string Usuario { get; set; }

		public string Senha { get; set; }

		public bool Ativo { get; set; }
	}
}
