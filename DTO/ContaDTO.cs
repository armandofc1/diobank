using DIO.Bank.Domain;

namespace DIO.Bank.DTO
{
    public class ContaDTO
    {
        public TipoConta TipoConta { get; set; }
        public double Saldo { get; set; }
        public double Credito { get; set; } 
        public string Nome { get; set; }

    }
}
