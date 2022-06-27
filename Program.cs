// See https://aka.ms/new-console-template for more information

/* Fai inserire un numero che chiamaeremo N all'utente, genera N array ognuno formato da 10 numeri casuali tra 1 e 100, ogni volta che ne crei uno stampalo a schermo */
Console.WriteLine("Quanti array vuoi creare?");
int N = Int32.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    int[] arrayi = new int[10];
    for(int j = 0; j < 10; j++)
    {
        var rand = new Random();

        arrayi[j] = rand.Next(1, 101);
    }
    Console.WriteLine("ARRAY" + (i+1));
    for (int l = 0; l < arrayi.Length; l++)
    {
        Console.WriteLine(arrayi[l]);
    }
}





return;

/* Il software chiede all'utente di inserire un numero, se è pari stampa un numero, se dispari stampa il successivo */

int numeroRichiesto = Int32.Parse(Console.ReadLine());

if (numeroRichiesto % 2 == 0)
{
    Console.WriteLine("PARI! Il numero inserito è: " + numeroRichiesto);
} else
{
    Console.WriteLine("DISPARI! Il numero successivo a quello dispari è: " + (numeroRichiesto + 1));
}



return;

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