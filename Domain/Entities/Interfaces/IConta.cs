namespace DIO.Bank.Domain
{
    interface IConta
    {
        bool Sacar(Dinheiro valorSaque);

        void Depositar(Dinheiro valorDeposito);

        bool Transferir(Dinheiro valorTransferencia, Conta contaDestino);
    }
}
