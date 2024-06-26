﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ComportamentoComposto
{
	public class Orcamento
	{
		public double Valor { get; set; }
		public IList<Item> Itens { get; private set; }

		public Orcamento(double valor)
		{
			Valor = valor;
			Itens = new List<Item>();
		}

		public void AdicionaItem(Item item)
		{
			Itens.Add(item);
		}
	}
}

