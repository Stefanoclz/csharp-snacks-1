// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*Il software deve chiedere per 10 volte all’utente di inserire un numero.
Il programma stampa la somma di tutti i numeri inseriti.*/

int richiesta = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero");
    richiesta += Int32.Parse(Console.ReadLine());
}

Console.WriteLine("La somma dei numeri inseriti è " + richiesta);