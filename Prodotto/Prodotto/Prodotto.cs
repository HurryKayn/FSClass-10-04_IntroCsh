using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagLibrary;
namespace EsercitazioneProdotti
{
    internal abstract class Prodotto
    {
        private string marca;
       
        private int quantita=0;
        private string descrizione;
        private decimal prezzo;

        public string Descrizione { get { return descrizione; } set { descrizione = value; } }
        public decimal Prezzo { get { return prezzo; } set {prezzo= value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public int Quantita { get { return quantita; } set { quantita = value; } }

        
        
        public Prodotto()
        {
            quantita =0;
            marca = "";
            descrizione = "";
            prezzo= 0;
        }
        public Prodotto(string marca,int prezzo):this()
        {
            this.marca = marca;
            this.prezzo =prezzo;
        }
        public Prodotto(string marca,string  descrizione):this()
        {
            
            this.marca = marca;
            this.descrizione = descrizione;
       
        }
        public bool Stato { get { return Stato; } set { Stato = false; } }
        public void Accendi()
        {
            Console.WriteLine("Il prodotto e' acceso");
            Stato = true;
        }


        public void Spegni()
        {
            Console.WriteLine("Il prodotto e' acceso");
            Stato = false;
        }

        public void Check()
        {
            if (Stato) Console.WriteLine("Il prodotto e' acceso");
            else Console.WriteLine("il prodotto e' spento");
        }

        public void AggiungiQuantita(int n)
        {
            if (n < 0) { throw new ArgumentException("Inserisci un valore maggiore di 0"); }
            else
            {
                Quantita += n;
                Console.WriteLine("Hai aggiunto " + n + " elementi al prodotto. Ora ne sono presenti" + Quantita);
            }
        }
        public void TogliiQuantita(int n)
        {
            if (n < 0) { throw new ArgumentException("Inserisci un valore maggiore di 0"); }
            else
            {
                Quantita -= n;
   
                Console.WriteLine("Hai tolto " + n + " elementi al prodotto. Ora ne sono presenti" + Quantita);
            }
        }



        
    }
}