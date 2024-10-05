// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Text;

// exercices 1 start

/*

Console.Write("Quel est votre prénom ? :");
var prenom = Console.ReadLine();
Console.Write("Quel est votre nom ? :");
var nom = Console.ReadLine();
Console.Write("Quel est votre âge ? :");
var age = Console.ReadLine();
Console.WriteLine($"Bonjour {prenom} {nom} ! vous avez {age} ans.");

*/

// exercices 2 start

/*

float num1 = 5;
float num2 = 3;
var somme = num1 + num2;
var difference = num1 - num2;
var produit = num1 * num2;
var division = num1 / num2;
Console.WriteLine($"{somme} ; {difference} ; {produit} ; {division}");

*/

// exercices 3 start

/*

Console.Write("Entrez un nombre décimal");
var entry = Console.ReadLine();
double entry_d = Convert.ToDouble(entry);

*/

// exo conversion 1

/*

Console.WriteLine("Entrez un nombre entier : ");
Console.WriteLine(int.TryParse(Console.ReadLine(), out int nb_entry) 
? $"ce nombre donne {nb_entry*2} une fois multiplié par 2." 
: "La valeur entrée n'est pas un nombre entier");

// if (int.TryParse(Console.ReadLine(), out int nb_entry)) {
//     Console.WriteLine($"{nb_entry*2}");
// }
// else {
//     Console.WriteLine("La valeur entrée n'est pas un nombre entier");
// }

*/

// exo convertion 2

/*

Console.WriteLine("Entrez un nombre décimal : ");
if (float.TryParse(Console.ReadLine(), out float nb_entry_c)) {
    nb_entry_c = Convert.ToInt32(nb_entry_c);
    Console.WriteLine($"rendu en entier : {nb_entry_c}");
}
else {
    Console.WriteLine("La valeur entrée n'est pas un nombre décimal");
}

*/

// exo convertion 3

/*

Console.WriteLine("Entrez une température en Celsius : ");
Console.WriteLine(int.TryParse(Console.ReadLine(), out int nb_entry_b) 
    ? $"Voici la température en Fahrenheit : {(nb_entry_b * (1.8))+ 32}" 
    : "C'est pas un nombre convertissable.");

// if (int.TryParse(Console.ReadLine(), out int nb_entry)) {
//     Console.WriteLine($"Voici la température en Fahrenheit : {(nb_entry * (1.8))+ 32}");
// }
// else {
//     Console.WriteLine("C'est pas un nombre convertissable.");
// }

*/

// exo condition 1

/*

Console.WriteLine("Entrez un nombre : ");
Console.WriteLine(
    int.TryParse(Console.ReadLine(), out var nb_mod) ?
        nb_mod % 2 == 0 
        ? "C'est un nombre pair." 
        : "C'est un nombre impair."
    : "Ce n'est pas un nombre entier.");

*/

// exo condition 2

/*

bool good = true;
Console.Write("Entrez le premier nombre : ");
Console.WriteLine(float.TryParse(Console.ReadLine(), out var nb_1) ? "" : $"Ce nombre est invalide . {good = false}");
Console.Write("Entrez l'opérateur : ");
var ope_cal = Console.ReadLine();
Console.Write("Entrez le deuxième nombre : ");
Console.WriteLine(float.TryParse(Console.ReadLine(), out var nb_2) ? "" : $"Ce nombre est invalide . {good = false}");
if (good) {
    switch (ope_cal) {
        case "+":
            Console.WriteLine($"{nb_1 + nb_2}");
            break;
        case "-":
            Console.WriteLine($"{nb_1 - nb_2}");
            break;
        case "*":
            Console.WriteLine($"{nb_1 * nb_2}");
            break;
        case "/":
            Console.WriteLine($"{nb_1 / nb_2}");
            break;
        default:
            Console.WriteLine($"Ce n'est pas un symbole arithmétique.");
            break;
    }
}
else {
    Console.WriteLine("L'opération n'a pas pu se faire.");
}

*/

// prof version avec switch condensé exo condition 2

/*

Console.WriteLine("Entrez les deux nombres de l'opération");
if (float.TryParse(Console.ReadLine(), out var nbs_1) && float.TryParse(Console.ReadLine(), out var nbs_2)) {
    Console.Write("Entrez l'opérateur : ");
    string? operateur = Console.ReadLine();
    var result = operateur switch {
        "+" => nbs_1 + nbs_2,
        "-" => nbs_1 - nbs_2,
        "*" => nbs_1 * nbs_2,
        "/" => nbs_1 / nbs_2,
        _ => throw new InvalidOperationException(),
    };
    Console.WriteLine($"{result}");
}
else {
    Console.WriteLine("Nombres invalide.");
}

*/

// exo opérateur

/*

Console.WriteLine("Entrez le BBAN.");
string? bban = Console.ReadLine();
if (bban.Length == 12 && bban is string) {
    string last_nb = bban[10..11];
    string ten_f_nb = bban[0..9];
    int.TryParse(last_nb, out int last_nb_int);
    int.TryParse()
}

*/

/*

Le marché
Créez un jeu de gestion de panier de fruits au marché à l'aide d'un tableau de chaînes de caractères.
L'utilisateur peut ajouter maximum 5 fruits, les retirer, les afficher et les rechercher.
Gérez les doublons lors de l'ajout.
Permettez à l'utilisateur de quitter le jeu via le menu. ---> PAS FINI

*/

/*

void Market() 
{
    Console.WriteLine("Bonjour et bienvenue au marché !!!");
    Console.WriteLine("Vous pouvez cherché un produit et le mettre dans votre panier. \n 1. Ajouter un produit \n 2. Retirer un produit \n 3. Afficher mon panier \n 4. Rechercher un produit");
}

*/