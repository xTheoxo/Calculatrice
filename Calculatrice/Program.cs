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
            int x = 0;
            int y = 0;

            // tab[0,0] = nombre 1
            // tab[0,1] = nombre 2
            // tab[0,2] = résultat


            while (choix != 8 && choix != 7 )
            {
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("1.Additionner");
                Console.WriteLine("2.Soustraire");
                Console.WriteLine("3.Multiplier");
                Console.WriteLine("4.Diviser avec reste");
                Console.WriteLine("5.Diviser sans reste");
                Console.WriteLine("6.Additionner de matrice de tailles égales");
                Console.WriteLine("7.Calcul de l'hypoténuse d'un triangle rectangle");
                Console.WriteLine("8.Exit");
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

                    case 6:
                        Console.WriteLine("Entrer la taille dses matrices ex : 2 puis 3 à la deuxème réponse");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le deuxieme nombre");
                        y = Convert.ToInt32(Console.ReadLine());

                        // Premier tableau 
                        Console.WriteLine("Première matrice :");
                        int[,] tab = new int[x, y];

                        for (int j = 0; j < x; j++)
                        {
                            for (int i = 0; i < y; i++)
                            {
                                Console.WriteLine($"Entrer {j};{i}");

                                tab[j, i] = Convert.ToInt32(Console.ReadLine());
                            }
                        }


                        // Deuxième tableau
                        Console.WriteLine("Deuxième matrice :");
                        int[,] tab2 = new int[x, y];

                        for (int i = 0; i < x; i++)
                        {
                            for (int j = 0; j < y; j++)
                            {
                                Console.WriteLine($"Entrer {i};{j}");

                                tab[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                        }

                        for (int i = 0; i < x; i++)
                        {
                            Console.WriteLine(" ");
                            for (int j = 0; j < y; j++)
                            {
                                Console.Write($"{tab[i, j]} ");
                            }
                        }

                        Console.WriteLine(" ");

                        for (int i = 0; i < x; i++)
                        {
                            Console.WriteLine(" ");
                            for (int j = 0; j < y; j++)
                            {
                                Console.Write($"{tab[i, j]} ");
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        //div = Convert.ToInt32(Console.ReadLine());
                        //resultat = nbre1 / div;
                        //Console.WriteLine($"Le résultat de {nbre1} / {div} = {resultat:F2}");
                        break;





                    case 7: 
                        Console.WriteLine("Soon");
                        break;
                }
            }
        }
    }
}