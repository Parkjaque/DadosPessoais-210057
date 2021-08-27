using System;
using System.Globalization;

namespace Dados_Pessoais
{
	class Program
	{
		static void Main(string[] args)
		{
			pessoa A;
			A = new pessoa();
			pessoa B;
			B = new pessoa();

			Console.WriteLine("Digite o nome da primeira pessoa:");
			A.Nome = Console.ReadLine();
			Console.WriteLine("Digite a idade da primeira pessoa:");
			A.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.WriteLine("Digite o nome da segunda pessoa:");
			B.Nome = Console.ReadLine();
			Console.WriteLine("Digite a idade da segunda pessoa:");
			B.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			if (A.Idade > B.Idade)
			{
				Console.WriteLine("A pessoa mais velha é: " + A.Nome);
			}
			else if (A.Idade == B.Idade)
			{
				Console.WriteLine("As duas pessoas tem a mesma idade");

			}
			else
			{
				Console.WriteLine("A pessoa mais velha é: " + B.Nome);
			}
				

		

		}
	}
}
