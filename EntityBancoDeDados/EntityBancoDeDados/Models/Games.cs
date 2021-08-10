using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityBancoDeDados.Models
{
	public class Games : BaseModel
	{
		public string Nome{ get; set; }
		public decimal Valor{ get; set; }
	}
}