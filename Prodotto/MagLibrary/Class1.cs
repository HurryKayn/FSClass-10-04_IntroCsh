namespace MagLibrary
{
    public class Magazzino
    {
        public decimal CalcolaValoreMagazzino(int prezzo, int quantita)
        {
            return prezzo * quantita;
        }

        public decimal CalcolaIVA(int prezzo, int quantita)
        {
            return prezzo + (prezzo*22/100);
        }
    }
}