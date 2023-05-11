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
        private string email;

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
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public Contato()
        {
            PrimeiroNome = "Ana";
            sobreNome = "Santos";
            Telefone = "0012345678";
            Email = "@hotmail";
        }
        public Contato(string primeiroNome, string sobreNome,  string telefone, string email)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
            Telefone = telefone;
            Email = email;
        }
        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}",PrimeiroNome, SobreNome);
            saida += String.Format("{0}-{1}-{2})",
                 Telefone.Substring(0, 1),
                 Telefone.Substring(2, 6),
                 Telefone.Substring(7, 10));
            saida += " ";
            saida += string.Format("{0}", Email) ;
            return saida;
        }
    }
}
