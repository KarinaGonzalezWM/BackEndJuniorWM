﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atualizacoes
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] menus = new string[] {
				"1. Propriedades Automáticas Somente-Leitura",
				"2. Inicializadores De Propriedade Automática",
				"3. Membros Com Corpo De Expressão",
				"4. Using Static",
				"5. Operadores Null-Condicionais",
				"6. Interpolação De Cadeia De Caracteres",
				"7. Expressões nameOf",
				"8. Filtros De Exceção",
				"9. Await Em Blocos Catch E Finally"
			};

			Console.WriteLine("ÍNDICE DE PROGRAMAS");
			Console.WriteLine("===================");


			int programa = 0;
			string line;
			do
			{
				foreach (var menu in menus)
				{
					Console.WriteLine(menu);
				}

				Console.WriteLine();
				Console.WriteLine("Escolha um programa:");

				line = Console.ReadLine();
				Int32.TryParse(line, out programa);
				switch (programa)
				{
					case 1:
						new SomenteLeitura.Programa().Main();
						break;
					case 2:
						new Inicializadores.Programa().Main();
						break;
					case 3:
						new Sintaxe.Programa().Main();
						break;
					case 4:
						new UsingStatic.Programa().Main();
						break;
					case 5:
						new OperadoresNull.Programa().Main();
						break;
					case 6:
						new Interpolacao.Programa().Main();
						break;
					case 7:
						new NameOf.Programa().Main();
						break;
					case 8:
						new Excecao.Programa().Main();
						break;
					case 9:
						new AwaitCatchFinally.Programa().Main();
						break;
					default:
						break;
				}

				Console.WriteLine();
				Console.WriteLine("PRESSIONE UMA TECLA PARA CONTINUAR...");
				Console.ReadKey();
				Console.Clear();
			} while (line.Length > 0);
		}
	}
}
