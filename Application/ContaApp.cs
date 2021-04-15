using System.Collections.Generic;
using DIO.Bank.Domain;
using DIO.Bank.Services;
using DIO.Bank.DTO;

namespace DIO.Bank.Application
{
    public static class ContaApp
    {
        public static List<ContaDTO> ListarContas()
        {
            List<ContaDTO> lista = new List<ContaDTO>();
            List<Conta> listContas = ContaService.ListarContas();
            if (listContas.Count > 0)
            {
                for (int i = 0; i < listContas.Count; i++)
                {
                    Conta conta = listContas[i];
                    lista.Add(Mapping.ContaToContaDTO(conta));
                }
            }
            return lista;
        }

        public static ContaDTO ObterConta(int indiceConta)
        {
            Conta conta = ContaService.ObterConta(indiceConta);
            return Mapping.ContaToContaDTO(conta);
        }

        public static ContaDTO Depositar(int indiceConta, double valorDeposito)
        {
            ContaService.Depositar(indiceConta, valorDeposito);
            Conta conta = ContaService.ObterConta(indiceConta);
            return Mapping.ContaToContaDTO(conta);
        }

        public static bool Sacar(int indiceConta, double valorSaque)
        {
            return ContaService.Sacar(indiceConta, valorSaque);
        }

        public static bool Transferir(int indiceContaOrigem, int indiceContaDestino, double valorTransferencia)
        {
            return ContaService.Transferir(indiceContaOrigem, indiceContaDestino, valorTransferencia);
        }

        public static void InserirConta(int tipoConta, double saldo, double credito, string nome)
        {
            ContaService.InserirConta(tipoConta: (TipoConta)tipoConta,
                            saldo: saldo,
                            credito: credito,
                            nome: nome);
        }
    }
}
