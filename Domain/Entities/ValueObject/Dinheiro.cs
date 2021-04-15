namespace DIO.Bank.Domain
{
    public class Dinheiro
    {
        public double Valor { get; set; }

        public Dinheiro(double valor)
        {
            this.Valor = valor;
        }

        public override string ToString()
        {
            return this.Valor.ToString();
        }
    }
}
