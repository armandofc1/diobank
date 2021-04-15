using System.Collections.Generic;
using DIO.Bank.Domain;

namespace DIO.Bank.Services
{
	public static class ContaService
	{
		public static List<Conta> listContas = new List<Conta>();

		public static void InserirConta(TipoConta tipoConta, double saldo, double credito, string nome)
		{
			Conta novaConta = new Conta(tipoConta: tipoConta,
										saldo: saldo,
										credito: credito,
										nome: nome);
			listContas.Add(novaConta);
		}

		public static List<Conta> ListarContas()
		{
			return ContaService.listContas;
		}

		public static Conta ObterConta(int indiceConta)
        {
			return ContaService.listContas[indiceConta];
		}

		public static void Depositar(int indiceConta, double valorDeposito)
		{
			ContaService.listContas[indiceConta].Depositar(new Dinheiro(valorDeposito));
		}

		public static bool Sacar(int indiceConta, double valorSaque)
        {
			return ContaService.listContas[indiceConta].Sacar(new Dinheiro(valorSaque));
		}

		public static bool Transferir(int indiceContaOrigem, int indiceContaDestino, double valorTransferencia)
        {
			return ContaService.listContas[indiceContaOrigem].Transferir(new Dinheiro(valorTransferencia), ContaService.listContas[indiceContaDestino]);
		}
	}
}
