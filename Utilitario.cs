using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automovel
{
	internal class Utilitario:Automovel
	{
		public int quantlugares { get; set; }

		public string cor { get; set; }



		public virtual double desconto()
		{
			return valor - 1000;
		}
	}
}
