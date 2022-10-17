using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp
{
    class Contato
    {
        private string nome, email, telefone;
        public Contato(string n, string e, string t)
        {
            nome = n;
            email = e;
            telefone = t;
        }
        public override string ToString()
        {
            return $"{nome} - {email} - {telefone}";
        }
    }
}
