using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automovel
{
	internal class Trabalho:Automovel
	{
		public double capacidadepeso { get; set; }

		public int quanteixo { get; set; }

		public override double desconto()
		{
			return valor - 5000;
		}
	}
}
