using System;

class Program
{
    static void Main(string[] args)
    {
        // Demander à l'utilisateur de saisir deux valeurs entières
        Console.WriteLine("Veuillez saisir les deux premières valeurs :");

        Console.Write("Donnez-moi votre première valeur entière : ");
        int premiereValeur = Convert.ToInt32(Console.ReadLine());

        Console.Write("Donnez-moi votre deuxième valeur entière : ");
        int deuxiemeValeur = Convert.ToInt32(Console.ReadLine());
      
      // Demander à l'utilisateur de saisir une troisième valeur entière
        Console.Write("Veuillez saisir une Troisième valeur entière : ");
        int troisiemeValeur = Convert.ToInt32(Console.ReadLine());

        // Comparaison de la troisième valeur entière avec les deux autres
        if (troisiemeValeur < Math.Min(premiereValeur, deuxiemeValeur))
        {
            Console.WriteLine("You have entered " + troisiemeValeur + " which is lower than " + Math.Min(premiereValeur, deuxiemeValeur) + " which is the minimum\n" + "Resulting integer : " +Math.Min(premiereValeur, deuxiemeValeur));
          
        }
        else if (troisiemeValeur > Math.Max(premiereValeur, deuxiemeValeur))
        {
            Console.WriteLine("You have entered " + troisiemeValeur + " which is greater than " + Math.Max(premiereValeur, deuxiemeValeur) + " which is the maximum\n" + "Resulting integer :" + Math.Max(premiereValeur, deuxiemeValeur));
        }
        else
        {
            Console.WriteLine("The third value lies between minimum " + Math.Min(premiereValeur, deuxiemeValeur) + " and the Maximum " + Math.Max(premiereValeur, deuxiemeValeur));
        }
    }
}



