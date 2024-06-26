﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DesingPatterns2.Cap7
{
	public class FilaDeTrabalho
	{
		private IList<IComando> Comandos = new List<IComando>();	

		public void Adiciona(IComando comando)
		{
			Comandos.Add(comando);
		}

		public void Processa()
		{
			foreach(var comando in Comandos)
			{
				comando.Executa();
			}
		}
	}
}
