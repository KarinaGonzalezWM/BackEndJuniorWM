﻿using _02_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank.Funcionarios {
	public class GerenteDeConta : FuncionarioAutenticavel {
		public GerenteDeConta(string cpf) : base(cpf, 4000) {
			Console.WriteLine("CRIANDO GERENTE DE CONTA");
		}

		public override void AumentarSalario() {
			Salario *= 1.05;
		}

		public override double GetBonificacao() {
			return Salario * 0.25;
		}
	}
}
