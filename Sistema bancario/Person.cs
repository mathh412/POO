using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistama_bancario
{
    public class Person
    {
        private int dinheiro = 0;
        public int Dinheiro
        {
            get
            {
                return dinheiro;
            }
            set
            {
                dinheiro = value;
            }
        }

        public bool Sacar(int valor,Banco banco)
        {
           if(banco.Sacar(this, valor))
            {
                this.dinheiro+= valor;
                return true;
            }
            return false;

        }
        public bool Depositar(int valor,Banco banco)
        {
            if (banco.Depositar(this, valor))
            {
                this.dinheiro -= valor;
                return true;
            }
            return false;
        }



    }
}
