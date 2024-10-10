// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualBasic;

// exercices 1 start

void exo_1() 
{
    Console.Write("Quel est votre prénom ? :");
    var prenom = Console.ReadLine();
    Console.Write("Quel est votre nom ? :");
    var nom = Console.ReadLine();
    Console.Write("Quel est votre âge ? :");
    var age = Console.ReadLine();
    Console.WriteLine($"Bonjour {prenom} {nom} ! vous avez {age} ans.");
}

// exercices 2 start

void exo_2() 
{
    float num1 = 5;
    float num2 = 3;
    var somme = num1 + num2;
    var difference = num1 - num2;
    var produit = num1 * num2;
    var division = num1 / num2;
    Console.WriteLine($"{somme} ; {difference} ; {produit} ; {division}");
}

// exercices 3 start

void exo_3() 
{
    Console.Write("Entrez un nombre décimal");
    var entry = Console.ReadLine();
    double entry_d = Convert.ToDouble(entry);
}

// exo conversion 1

void exo_conv_1() {
Console.WriteLine("Entrez un nombre entier : ");
Console.WriteLine(int.TryParse(Console.ReadLine(), out int nb_entry) 
? $"ce nombre donne {nb_entry*2} une fois multiplié par 2." 
: "La valeur entrée n'est pas un nombre entier");
}
// if (int.TryParse(Console.ReadLine(), out int nb_entry)) {
//     Console.WriteLine($"{nb_entry*2}");
// }
// else {
//     Console.WriteLine("La valeur entrée n'est pas un nombre entier");
// }


// exo convertion 2

void exo_conv_2() 
{
    Console.WriteLine("Entrez un nombre décimal : ");
    if (float.TryParse(Console.ReadLine(), out float nb_entry_c)) {
        nb_entry_c = Convert.ToInt32(nb_entry_c);
        Console.WriteLine($"rendu en entier : {nb_entry_c}");
    }
    else {
        Console.WriteLine("La valeur entrée n'est pas un nombre décimal");
    }
}

// exo convertion 3

void exo_conv_3() 
{
    Console.WriteLine("Entrez une température en Celsius : ");
    Console.WriteLine(int.TryParse(Console.ReadLine(), out int nb_entry_b) 
        ? $"Voici la température en Fahrenheit : {(nb_entry_b * (1.8))+ 32}" 
        : "C'est pas un nombre convertissable.");
}

// if (int.TryParse(Console.ReadLine(), out int nb_entry)) {
//     Console.WriteLine($"Voici la température en Fahrenheit : {(nb_entry * (1.8))+ 32}");
// }
// else {
//     Console.WriteLine("C'est pas un nombre convertissable.");
// }

// exo condition 1

void exo_condi_1()
{
    Console.WriteLine("Entrez un nombre : ");
    Console.WriteLine(
        int.TryParse(Console.ReadLine(), out var nb_mod) ?
            nb_mod % 2 == 0 
            ? "C'est un nombre pair." 
            : "C'est un nombre impair."
        : "Ce n'est pas un nombre entier.");
}

// exo condition 2

void exo_condi_2()
{
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
}

// prof version avec switch condensé exo condition 2

void exo_condi_2_alter() 
{
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
}

// exo opérateur

void exo_ope()
{
    Console.WriteLine("Entrez le BBAN.");
    string? bban = Console.ReadLine();
    if (bban.Length == 12 && bban is string) {
        string last_nb = bban[10..11];
        string ten_f_nb = bban[0..9];
        int.TryParse(last_nb, out int last_nb_int);
        // int.TryParse() --> TODO
    }
}

// Le marché
// Créez un jeu de gestion de panier de fruits au marché à l'aide d'un tableau de chaînes de caractères.
// L'utilisateur peut ajouter maximum 5 fruits, les retirer, les afficher et les rechercher.
// Gérez les doublons lors de l'ajout.
// Permettez à l'utilisateur de quitter le jeu via le menu. ---> PAS FINI

void Market() 
{
    Console.WriteLine("Bonjour et bienvenue au marché !!!");
    Console.WriteLine("Vous pouvez cherché un produit et le mettre dans votre panier. \n 1. Ajouter un produit \n 2. Retirer un produit \n 3. Afficher mon panier \n 4. Rechercher un produit");
    // TODO
}

// exercice Collection while nombre premier inférieur au nombre entré par l'user

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

// deux structures Celcius et Fahrenheit et convertion <=>

public struct Celcius
{
    public double celcius;
    public double convert_F() 
    {
        return (celcius * (1.8))+ 32;
    }
}

public struct Fahrenheit
{
    public double fahrenheit;
    public double convert_C()
    {
        double cinq_neuv = 5 / 9;
        return (fahrenheit * (cinq_neuv)) -32;
    }
}

// vue du chapitre sur les classes et les énumérations.

enum Jour {Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche}
public enum Activite {Etude, Emploi, Retraite}
public enum GroupeSanguin {O_plus, O_moins, A_plus, A_moins, B_plus, B_moins, AB_plus, AB_moins}

public class Personne (string nom, string prenom, string nrn, GroupeSanguin gs, Activite status, string nationality, string adresse, string ville, string code_postal) {
    public string name = nom;
    public string surname = prenom;
    public string numero_registre_national = nrn;
    public GroupeSanguin groupe_sanguin = gs;
    public Activite activité = status;
    public string nationality = nationality;
    public string adresse = adresse;
    public string ville = ville;
    public string code_postal = code_postal;

    public void parler() {

    }
    public void travailler() {

    }
}

public class Etudiant() {

}

// transformer les objets théoriquement vu au début de cours

/*

Class Personne(animal):
	- nom
	- prénom
	- numéro_registre_national
	- pointure
	- activité[étudiant,travailleur,retraité]
	- groupe sanguin
	- nationalité
	- adresse
	- ville
	- code postal

	def parler(phrase: string):

	def travailler(type_travail: object):

*/

/*

class Étudiant(Personne):
	- Diplômes[]
	- Certificat[]
	- école_actuelle

	def étudier(matière: object):

	def réviser(matière: object):

	def écrire(phrase: string):

class Animal:
	- appellation
	- poids
	- taille
	- age
	- nombre_de_membre_inférieur
	- vitesse_de_déplacement_marche
	- vitesse_de_déplacement_course
	- vitesse_de_déplacement_nage
	- régime_alimentaire
	- Statut_cladistique{}
	- genre
	- moyen_déplacement
	
	def marcher(distance: float):

	def se_reproduire(conjoint: object):

	def courir(distance: float):

	def manger(aliment: object):

	def boire(liquide: object):

	def nager(distance: float):

	def set_default_human():

class Produit:
	- libellé
	- description
	- prix
	- code bar

class CompteBancaire:
	- propriétaire
	- banque
	- dépots

	def retrait(somme: decimal):

	def déposer(somme: decimal):

Cédric = Personne (
	- nom = Delval
	- prénom = Cédric
	- numéro_registre_national = blk
	- pointure = default
	- activité = étudiant
	- groupe sanguin = idk
	- nationalité = Belgique
	- adresse = Rue de l'hôtel de ville 1
	- ville = Perwez
	- code postal = 1360
)
Alain = Personne (
	- nom = Delval
	- prénom = Alain
	- numéro_registre_national = blk
	- pointure = default
	- activité = Travailleur
	- groupe sanguin = idk
	- nationalité = Belgique
	- adresse = Rue de l'hôtel de ville 1
	- ville = Perwez
	- code postal = 1360
)
Cédric.set_default_human()
Alain.set_default_human()

Nutella = Produit (
	- libellé = Nutella
	- description = Chocolat à tartiné particulièrement gras
	- prix = 5€
	- code bar = blk
)

Cédric.manger(Nutella)

Fuze_Tea : Black Tea Lemon = Produit (
	- libellé = Fuze Tea : Black Tea Lemon
	- description = Boisson sucrée low calorie pour random gamer
	- prix = 2€
	- code bar = blk
)

Cédric.boire(Fuze_Tea)

*/