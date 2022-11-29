// See https://aka.ms/new-console-template for more information
using CSharpShop;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Libro1---**---**----**------");
        Prodotto libro1 = new Prodotto("Arthur", "Libro science fiction 264 pagine", 26, 22);
        libro1.nomeCompleto();
        libro1.setNome("Clean Code");
        libro1.StampaProdotto();
        Console.WriteLine("Mistery box////////////////////////");
        Prodotto mysterybox = new Prodotto("Mystery box", "Cartone con ogetti", 120, 22);
        mysterybox.StampaProdotto();
        double totalprice = mysterybox.prezzoTotale();
        Console.WriteLine(mysterybox.getPrezzo());
        Console.WriteLine("Prezzo totale: " + totalprice);
        int gennum = int.Parse(Console.ReadLine());
        mysterybox.codiceFormat(gennum);
        Prodotto bottiglia = new Prodotto("Coca Colla", "Bottiglia con soft drink", 1, 22);

        List<Prodotto> items = new List<Prodotto>();
        items.Add(libro1);
        items.Add(mysterybox);
        items.Add(bottiglia);

        items.ForEach(item =>
        {
            item.StampaProdotto();
            item.codiceFormat(item.getCodice());
        });


    }
}