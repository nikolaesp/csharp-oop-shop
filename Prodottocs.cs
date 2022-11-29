using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private int prezzo;
        private int iva;


        public Prodotto(string name,string description,int price,int vat)
        {
            Random rnd = new Random();
            int myRandomNo = rnd.Next(00000000, 99999999); // crea random numero di 8 cifre
            this.codice = myRandomNo;
            this.nome = name;
            this.descrizione = description;
            this.prezzo = price;
            this.iva = vat;
        }
        public int getCodice() { return this.codice; }
        public void setNome(string name) {

           this.nome = name;
        }
        public string getNome() { return this.nome; }
        public void setDescrizione(string des)
        {
            this.descrizione = des;
        }
        public string getDescrizione() { return this.descrizione; }
        public void setPrezzo(int price)
        {
            this.prezzo = price;
        }
        public int getPrezzo() { return this.prezzo; }
        public void setIva(int vat)
        {
            this.iva = vat;
        }
        public int getIva() { return this.iva; }

        public double prezzoTotale()
        {
            return this.prezzo + (this.prezzo * (this.iva/100.0));
        }
        public void nomeCompleto()
        {
            Console.WriteLine("Nome completo: " +this.nome+this.codice);
        }
        public void StampaProdotto()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Codice: "+this.codice);
            Console.WriteLine("Descrizione: " + this.descrizione);
            Console.WriteLine("Prezzo: " + this.prezzo+ "eur");
            Console.WriteLine("IVA: " + this.iva+"%");
        }
    }
}
