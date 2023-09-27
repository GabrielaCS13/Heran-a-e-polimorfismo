using automovel;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main(string[] args)
	{

		Utilitario uti = new Utilitario();
		uti.marca = "Audi";
		uti.valor = 1000000.00;
		uti.modelo = "R8";
		uti.quantlugares = 5;
		uti.cor = "Preto";

		Trabalho trab = new Trabalho();
		trab.marca = "Chevrolet";
		trab.valor = 300000.00;
		trab.modelo = "Spin";
		trab.capacidadepeso = 400.0;
		trab.quanteixo = 2;


		Console.WriteLine("A marca é " + uti.marca + " o valor é " + uti.valor + " o modelo é " + uti.modelo);
		Console.WriteLine("\nA quantidade de lugares é " + uti.quantlugares + " a cor é " + uti.cor);
		Console.WriteLine("\nO valor com desconto é " + uti.desconto());

		Console.WriteLine("--------------------------------------------------\n");

		Console.WriteLine("A marca é " + trab.marca + " o valor é " + trab.valor + " o modelo é " + trab.modelo);
		Console.WriteLine("\nA capacidade de peso é " + trab.capacidadepeso + " a quantidade de peso é " + trab.quanteixo);
		Console.WriteLine("\nO valor com desconto é " + trab.desconto());
	}
}