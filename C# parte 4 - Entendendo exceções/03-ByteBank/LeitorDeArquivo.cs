﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank {
	public class LeitorDeArquivo : IDisposable {
		public string Arquivo { get; }

		public LeitorDeArquivo(string arquivo) {
			Arquivo = arquivo;
			//throw new FileNotFoundException();            
			Console.WriteLine("Abrindo arquivo: " + arquivo);
		}

		public string LerProximaLinha() {
			Console.WriteLine("Lendo linha...");

			throw new IOException();
		}

		public void Fechar() {
			Console.WriteLine("Fechando arquivo.");
		}
		public void Dispose() {
			Console.WriteLine("Fechando arquivo.");
		}
	}
}