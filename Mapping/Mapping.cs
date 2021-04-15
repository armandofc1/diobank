using DIO.Bank.Domain;
using DIO.Bank.DTO;

namespace DIO.Bank.Application
{
	public static class Mapping
	{
		public static ContaDTO ContaToContaDTO(Conta conta)
		{
			return new ContaDTO()
			{
				TipoConta = conta.TipoConta,
				Nome = conta.Pessoa.Nome,
				Saldo = conta.Saldo.Valor,
				Credito = conta.Credito.Valor
			};
		}
	}
}
