// See https://aka.ms/new-console-template for more information


/* Calcola la somma e la media dei numeri da 2 a 10 */

int somma = 0;

int media;

for (int i = 2; i <= 10; i++)
{
    somma += i;

}

media = somma / (10 - 2);

Console.WriteLine("la somma è: " + somma);

Console.WriteLine("la media è: " + media);


return;
/*Il software deve chiedere per 10 volte all’utente di inserire un numero.
Il programma stampa la somma di tutti i numeri inseriti.*/

int richiesta = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero");
    richiesta += Int32.Parse(Console.ReadLine());
}

Console.WriteLine("La somma dei numeri inseriti è " + richiesta);