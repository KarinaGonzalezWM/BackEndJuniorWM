﻿using System;
using System.Security.Policy;

namespace _07_ByteBank {

	public class ContaCorrente {
		public Cliente Titular { get; set; }
		public int Agencia { get; set; }
		public int Numero { get; set; }
		private double _saldo = 1000;

		public double Saldo {
			get {
				return _saldo;
			}
			set {
				if (value < 0) {
					return;
				}
				else {
					_saldo += value;
				}
			}
		}
		public bool Sacar(double valor) {
			if (_saldo < 100) {
				return false;
			}
			else {
				_saldo -= valor;
				return true;
			}
		}

		// metodo sem retorno
		public void Depositar(double valor) {
			_saldo += valor;
		}

		public bool Transferir(double valor, ContaCorrente contaDestino) {
			if (_saldo < valor) {
				return false;
			}
			else {
				_saldo -= valor;
				contaDestino.Depositar(valor);
				return true;
			}
		}

	}
}