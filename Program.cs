// See https://aka.ms/new-console-template for more information
using CSharpShop;

Console.WriteLine("Libro1---**---**----**------");
Prodotto libro1 = new Prodotto("Arthur","Libro science fiction 264 pagine",26,22);
libro1.StampaProdotto();
Console.WriteLine("Mistery box////////////////////////");
Prodotto mysterybox = new Prodotto("Mystery box", "Cartone con ogetti", 120, 22);
mysterybox.StampaProdotto();