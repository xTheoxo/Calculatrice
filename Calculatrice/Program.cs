namespace Calculatrice
{ 
    class Program
    {
        private static void Main(string[] arg)
        {

            int choix = 1;
            int nbre1 = 0;
            int nbre2 = 0;
            int reste = 0;
            float div = 0;
            float resultat;

            while (choix != 6)
            {
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("1.Additionner");
                Console.WriteLine("2.Soustraire");
                Console.WriteLine("3.Multiplier");
                Console.WriteLine("4.Diviser avec reste");
                Console.WriteLine("5.Diviser sans reste");
                Console.WriteLine("6.Exit");
                Console.WriteLine("==================================================================================================");
                Console.Write("> ");

                choix = Convert.ToInt32(Console.ReadLine());
                
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Entrer le premier nombre");
                        nbre1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le deuxieme nombre");
                        nbre2 = Convert.ToInt32(Console.ReadLine());
                        choix = nbre1 + nbre2;
                        Console.WriteLine($"Le résultat de {nbre1} + {nbre2} = {choix}");
                        break;

                    case 2:
                        Console.WriteLine("Entrer le premier nombre");
                        nbre1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le deuxieme nombre");
                        nbre2 = Convert.ToInt32(Console.ReadLine());
                        choix = nbre1 - nbre2;
                        Console.WriteLine($"La différence de {nbre1} - {nbre2} = {choix}");
                        break;

                    case 3:
                        Console.WriteLine("Entrer le premier nombre");
                        nbre1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le deuxieme nombre");
                        nbre2 = Convert.ToInt32(Console.ReadLine());
                        choix = nbre1 * nbre2;
                        Console.WriteLine($"Le produit de {nbre1} x {nbre2} = {choix}");
                        break;

                    case 4:
                        Console.WriteLine("Entrer le premier nombre");
                        nbre1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le deuxieme nombre");
                        nbre2 = Convert.ToInt32(Console.ReadLine());
                        choix = nbre1 / nbre2;
                        reste = nbre1 % nbre2;
                        Console.WriteLine($"Le quotient de {nbre1} / {nbre2} = {choix}");
                        Console.WriteLine($"Et il reste {reste}");
                        break;

                    case 5:
                        Console.WriteLine("Entrer le premier nombre");
                        nbre1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le deuxieme nombre");
                        div = Convert.ToInt32(Console.ReadLine());
                        resultat = nbre1 / div;
                        Console.WriteLine($"Le résultat de {nbre1} / {div} = {resultat:F2}");
                        break;
                }
            }
        }
    }
}