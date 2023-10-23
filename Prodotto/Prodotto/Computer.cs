using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagLibrary;
namespace EsercitazioneProdotti
{
    internal class Computer:Prodotto
    {
        private int capacita;
        public int Capacita { get { return capacita; } set { capacita = value; } }
        
        public Computer() : base() { }
        public Computer(string marca, int prezzo) : base(marca,prezzo)
        {
           
        }

        public Computer(string marca,string descrizione) : base() { 
        }
    }
}
