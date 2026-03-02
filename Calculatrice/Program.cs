namespace Calculatrice
{ 
    class Program
    {
        private static void Main(string[] arg)
        {
            int choix = 0;
            int nbre1 = 0;
            int nbre2 = 0;
            double nbre3;
            double nbre4;
            double resultat1;
            int reste;
            float div;
            float div2;
            float resultat;
            int x,y = 0;

            // tab[0,0] = nombre 1
            // tab[0,1] = nombre 2
            // tab[0,2] = résultat

            while (choix != 11)
            {
                Console.WriteLine("==================================================================================================");
                Console.WriteLine("1.Additionner");
                Console.WriteLine("2.Soustraire");
                Console.WriteLine("3.Multiplier");
                Console.WriteLine("4.Diviser avec reste");
                Console.WriteLine("5.Diviser sans reste");
                Console.WriteLine("6.Opposé d'un nombre");
                Console.WriteLine("7.Calcul de la puissance d'un nombre");
                Console.WriteLine("8.Addition de deux matrices de tailles égales (Pas fini)");
                Console.WriteLine("9.Calcul de l'hypoténuse d'un triangle rectangle");
                Console.WriteLine("10.Savoir si un triangle est rectangle");
                Console.WriteLine("11.Exit");
                Console.WriteLine("==================================================================================================");
                Console.Write("> ");

                try
                {
                    choix = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Rentrer un nombre valide !");
                }

                Console.WriteLine(" ");

                
                void initialisation_calcul()
                {
                    Console.WriteLine("Entrer le premier nombre");
                    Console.Write("> ");
                    nbre1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entrer le deuxieme nombre");
                    Console.Write("> ");
                    nbre2 = Convert.ToInt32(Console.ReadLine());
                }
                void scan()
                {
                    try
                    {
                        initialisation_calcul();
                    }
                    catch
                    {
                        Console.WriteLine("Rentrer un nombre valide !");
                    }
                }

                switch (choix)
                {
                    // Addition
                    case 1:
                        Console.WriteLine("*Addition*");
                        //scan();
                        initialisation_calcul();
                        
                        choix = nbre1 + nbre2;
                        Console.WriteLine($"Le résultat de {nbre1} + {nbre2} = {choix}");
                        break;

                    // Soustraction
                    case 2:
                        Console.WriteLine("*Soustraction*");
                        initialisation_calcul();
                        choix = nbre1 - nbre2;
                        Console.WriteLine($"La différence de {nbre1} - {nbre2} = {choix}");
                        break;

                    // Multiplication
                    case 3:
                        Console.WriteLine("*Multiplication*");
                        initialisation_calcul();
                        choix = nbre1 * nbre2;
                        Console.WriteLine($"Le produit de {nbre1} x {nbre2} = {choix}");
                        break;

                    // Division avec reste
                    case 4:
                        Console.WriteLine("*Division avec reste*");
                        initialisation_calcul();
                        choix = nbre1 / nbre2;
                        reste = nbre1 % nbre2;
                        Console.WriteLine($"Le quotient de {nbre1} / {nbre2} = {choix}");
                        Console.WriteLine($"Et il reste {reste}");
                        break;

                    // Division sans reste
                    case 5:
                        Console.WriteLine("*Division sans reste*");
                        Console.WriteLine("Entrer le premier nombre");
                        nbre1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer le deuxieme nombre");
                        div = Convert.ToInt32(Console.ReadLine());
                        resultat = nbre1 / div;
                        Console.WriteLine($"Le résultat de {nbre1} / {div} = {resultat:F2}");
                        break;

                    // Opposé d'un nombre
                    case 6:
                        Console.WriteLine("*Opposé d'un nombre*");
                        Console.WriteLine("Entrer le nombre");
                        nbre1 = Convert.ToInt32(Console.ReadLine());
                        if (nbre1 < 0)
                        {
                            choix = Math.Abs(nbre1);
                        }
                        else
                        {
                            choix = nbre1 - nbre1 * 2;
                        }

                        Console.WriteLine($"L'opposé de {nbre1} est {choix}");
                        break;

                    // Calcul de la puissance d'un nombre
                    case 7:
                        Console.WriteLine("*Calcul de la puissance d'un nombre*");
                        Console.WriteLine("Entrer le nombre");
                        nbre3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Entrer la puissance");
                        nbre4 = Convert.ToDouble(Console.ReadLine());
                        resultat1 = Math.Pow(nbre3, nbre4);
                        Console.WriteLine($"Le résultat de {nbre3} ** {nbre4} = {resultat1}");
                        break;

                    case 8:
                        Console.WriteLine("Entrer la taille des matrices ex : 2 puis 3 à la deuxème réponse");
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

                        // Affichage du tableau 1
                        for (int i = 0; i < x; i++)
                        {
                            Console.WriteLine(" ");
                            for (int j = 0; j < y; j++)
                            {
                                Console.Write($"{tab[i, j]} ");
                            }
                        }

                        Console.WriteLine(" ");

                        // Affichage du tableau 2
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
                        break;

                    // Calcul de l'hypoténuse d'un triangle rectangle
                    case 9: 
                        Console.WriteLine("*Calcul de l'hypoténuse d'un triangle rectangle*");
                        Console.WriteLine("Entrer la longeur de votre triangle rectangle");
                        div = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrer la largeur de votre triangle rectangle");
                        div2 = Convert.ToInt32(Console.ReadLine());

                        div = div * div;
                        div2 = div2 * div2;
                        resultat = div + div2;
                        resultat = (float)Math.Sqrt(resultat);

                        Console.WriteLine($"L'hypoténuse est égale à {resultat:F2}");
                        break;

                    // Savoir si un triangle est rectangle
                    case 10:
                        Console.WriteLine("*Savoir si un triangle est rectangle*");
                        Console.WriteLine("Entrer l'hypoténuse du triangle");
                        Console.Write("> ");
                        nbre1 = Convert.ToInt32(Console.ReadLine());
                        nbre1 = nbre1 * nbre1;

                        Console.WriteLine("Entrer la longeur du triangle");
                        Console.Write("> ");
                        nbre2 = Convert.ToInt32(Console.ReadLine());
                        nbre2 = nbre2 * nbre2;

                        Console.WriteLine("Entrer la largeur du triangle");
                        Console.Write("> ");
                        reste = Convert.ToInt32(Console.ReadLine());
                        reste = reste * reste;

                        reste = reste + nbre2;

                        if (reste == nbre1)
                        {
                            Console.WriteLine("Le triangle est rectangle");
                        }
                        else
                        {
                            Console.WriteLine("Le triangle n'est pas rectangle");
                        }
                            break;
                }
            }
        }
    }
}