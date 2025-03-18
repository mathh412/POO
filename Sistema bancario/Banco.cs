using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistama_bancario
{
    public class Banco
    {
       Dictionary<Person,int> saldos = new Dictionary<Person, int>();

        public bool CriarConta(Person p)
        {
            if (!saldos.ContainsKey(p))
            {
                saldos.Add(p, 0);
                return true;
            }
            return false;
        }

        public bool Sacar(Person p, int valor)
        {
            if (saldos.ContainsKey(p))
            {
                if (saldos[p] >= valor)
                {
                    saldos[p] -= valor;
                    return true;
                }
            }
            return false;
        }
        public bool Depositar(Person p, int valor)
        {
            if (saldos.ContainsKey(p))
            {
                saldos[p] += valor;
                return true;
            }
            return false;
        }
        public int GetSaldo(Person p)
        {
            if (saldos.ContainsKey(p))
            {
                return saldos[p];
            }
            return 0;
        }
    }
}
