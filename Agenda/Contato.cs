using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Contato
    {
        private string primeiroNome;
        private string sobreNome;
        private string telefone;

        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
        public string SobreNome
        {
            get { return sobreNome; }
            set { sobreNome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    Telefone = "00-1234-56789";
                }
            }
        }
        public Contato()
        {
            PrimeiroNome = "Ana";
            sobreNome = "Santos";
            Telefone = "11-6666-6666";
        }
        public Contato(string primeiroNome, string sobreNome, string telefoneome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
            Telefone = telefone;
            
        }
        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}",PrimeiroNome, SobreNome);
            saida += String.Format("{0}-{1}-{2})",
                 Telefone.Substring(0, 1),
                 Telefone.Substring(2, 6),
                 Telefone.Substring(7, 10));

        }
    }
}
