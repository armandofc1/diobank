using System;

namespace DIO.Bank.Domain
{
	public class Conta: Base, IConta
	{
        // Atributos
        public TipoConta TipoConta { get; private set; }
        public Dinheiro Saldo { get; private set; }
        public Dinheiro Credito { get; private set; }
        public Pessoa Pessoa { get; private set; }

        // Métodos
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
		{
			this.TipoConta = tipoConta;
			this.Saldo = new Dinheiro(saldo);
			this.Credito = new Dinheiro(credito);
			this.Pessoa = new Pessoa(nome);
			this.DataInclusao = DateTime.Now;
		}

		public bool Sacar(Dinheiro valorSaque)
		{
            // Validação de saldo suficiente
            if (this.Saldo.Valor - valorSaque.Valor < (this.Credito.Valor *-1)){
                return false;
            }
            this.Saldo.Valor -= valorSaque.Valor;
            return true;
		}

		public void Depositar(Dinheiro valorDeposito)
		{
			this.Saldo.Valor += valorDeposito.Valor;
		}

		public bool Transferir(Dinheiro valorTransferencia, Conta contaDestino)
		{
			if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
				return true;
            }
			return false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Pessoa + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
		}
	}

}