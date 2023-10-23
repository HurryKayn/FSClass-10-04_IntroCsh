using MagLibrary;


namespace EsercitazioneProdotti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer asus = new Computer();

            Archiviazione disco = new Archiviazione();

            Magazzino magazzino = new Magazzino();
            /*
            disco.TogliiQuantita(30);
         
            disco.Prezzo = 10;
            asus.Capacita = 10;
            Console.WriteLine(disco.ToString());
            Console.WriteLine(disco.Prezzo);
            asus.AggiungiQuantita(20);
            */

            Console.WriteLine(magazzino.CalcolaValoreMagazzino(10,20));
            

        }
    }
}