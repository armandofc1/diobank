using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Bank.Domain
{
    public class Pessoa : Base
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            this.Nome = nome;
            this.DataInclusao = DateTime.Now;
        }

        public override string ToString()
        {
            return this.Nome.ToString();
        }
    }
}
