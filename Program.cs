// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

// while nombre premier inférieur au nombre entré par l'user

void coll_exo_1()
{
    List<int> values = [];
    Console.WriteLine("Entrez un nombre : ");
    var entry = Console.ReadLine();
    bool fine = int.TryParse(entry, out int entry_int);
    int start_nb = 2;
    if (fine && (entry_int > 1 || entry_int < -1)) {
        while (start_nb <= entry_int)
        {
            int count = 0;
            for (int i = 2; i <= entry_int; i++)
            {
                if (start_nb % i == 0) 
                {
                    count++;
                }
            }
            if (count == 1 && start_nb > 1) {
                values.Add(start_nb);
            }
            start_nb++;
        }
        foreach (int i in values) 
        {
            Console.Write($"| {i} |");
        }
    }
    else {
        Console.WriteLine("l'entrée n'est pas un nombre ou un nombre non divisable (0,1,-1).");
    }
}

coll_exo_1();