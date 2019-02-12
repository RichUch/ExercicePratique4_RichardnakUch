using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePratique4_RichardnakUCH
{
    // STRUCTURE ÉTUDIANT
    public struct EtudiantDuCollege
    {
        public string nom;
        public string prenom;

        public char sexe;
        public int programme; 

        public Date dateNaissance;
        public Adresse adresse;

        // STRUCTURE ADDRESSE
        public struct Adresse
        {
            public int numero;
            public string rue;
            public string ville;
            public string codePostal;
        }

        // STRUCTURE DATE
        public struct Date
        {
            public int mois;
            public int jour;
            public int annee;
        }
    }


    class Program
    {
        // MÉTHODE POUR CLASSER LE SEXE DES ÉTUDIANTS
        static void ClasserSexeEtudiants(EtudiantDuCollege[] etudiants)
        {   
            // SI LES ÉLÈVES SONT MALES
            Console.WriteLine("=========== SECTION DES ÉLÈVES MALES ===========  \n");
            for (int i = 0; i < etudiants.Length; i++)
            {
                if (etudiants[i].sexe == 'M')
                {
                    Console.WriteLine("L'élève '" + etudiants[i].nom + etudiants[i].prenom + "' est un élève male. \n");
                }
            }
            // SI LES ÉLÈVES SONT FEMELLES
            Console.WriteLine("=========== SECTION DES ÉLÈVES FEMELLES =========== \n");
            for (int i = 0; i < etudiants.Length; i++)
            {
                if (etudiants[i].sexe == 'F')
                {
                    Console.WriteLine("L'élève '" + etudiants[i].nom + etudiants[i].prenom + "' est une élève femelle.\n");
                }
            }
            // POUR CRÉER DE L'ESPACEMENT
            Console.WriteLine("\n \n \n \n \n \n ");
        }


        // MÉTHODE POUR CLASSER LE PROGRAMME DES ÉTUDIANTS
        static void LimiterProgrammeEtudiant(EtudiantDuCollege[] tabEtudiants)
        {
            int borne1 = 0;
            int borne2 = 0;

            // DEMANDE DES BORNES DES PROGRAMMES
            Console.WriteLine("Entrer les 2 bornes pour la limite des programmes \n");
            Console.Write("Borne 1: ");
            borne1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Borne 2: ");
            borne2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // SI LES ÉLÈVES SONT PARMIS LES BORNES
            Console.WriteLine("================== SECTION DES ÉLÈVES PARMIS LES BORNES DE " + borne1 + " ET " + borne2 + " ==================== \n");
            for (int i = 0; i < tabEtudiants.Length; i++)
            {
                if (tabEtudiants[i].programme >= borne1  && tabEtudiants[i].programme <= borne2)
                {
                    Console.WriteLine("Le programme de l'élève '" + tabEtudiants[i].nom + tabEtudiants[i].prenom + ": " + tabEtudiants[i].programme +  "' est parmis les 2 bornes \n");
                }
            }

            // POUR CRÉER DE L'ESPACEMENT
            Console.WriteLine("\n \n \n \n");

            // POUR GARDER L'ÉCRAN
            Console.WriteLine("Appuyez sur  'Enter' pour continuer");
            Console.ReadLine();
        }


        //MÉTHODE POUR TRIER LES ÉTUDIANTS EN FONCTION DE LEUR NOM DE FAMILLE
        static void TrierNomFamille(EtudiantDuCollege[] tabEtudiants)
        {
            // AFFICHAGE DES NOMS DE FAMILLES EN ORDRE DE DÉPART
            Console.WriteLine(" =========== AFFICHAGE DES NOMS DE FAMILLES EN ORDRE DE DÉPART =========== \n");
            for (int i = 0; i < tabEtudiants.Length; i++)
            {
                Console.WriteLine(tabEtudiants[i].nom + tabEtudiants[i].prenom + "\n");
            }
            Console.WriteLine("\n");

            // AFFICHAGE DES NOMS DE FAMILLES TRIÉS EN ORDRE ALPHABÉTIQUE
            Console.WriteLine(" =========== AFFICHAGE DES NOMS DE FAMILLES TRIÉS EN ORDRE ALPHABÉTIQUE =========== \n");
            EtudiantDuCollege[] nomFamTrier= tabEtudiants.OrderBy(c => c.nom).ToArray(); // <== Fait avec l'aide de: https://stackoverflow.com/questions/1304278/how-to-sort-an-array-containing-class-objects-by-a-property-value-of-a-class-ins
            for (int i = 0; i < tabEtudiants.Length; i++)
            {
                Console.WriteLine(nomFamTrier[i].nom + nomFamTrier[i].prenom + "\n");
            }
            // POUR CRÉER DE L'ESPACEMENT
            Console.WriteLine("\n \n \n \n");
        }
 


        // MÉTHODE POUR LA VILLE DES ÉTUDIANTS
        static void MontrerEtudiantsDansVille(EtudiantDuCollege[] etudiants)
        {
            string villeDonner;

            // DEMANDE DE LA VILLE
            Console.WriteLine("Entrez une ville de votre choix");
            villeDonner = Console.ReadLine();

            // SI LES ÉTUDIANTS VIVENT DANS LA VILLE DONNÉE EN PARAMÈTRE
            Console.WriteLine("=========== SECTION DES ÉLÈVES QUI HABITENT DANS LA VILLE DONNÉE EN PARAMÈTRE ===========  \n");
            for (int i = 0; i < etudiants.Length; i++)
            {
                if (villeDonner.ToUpper() == etudiants[i].adresse.ville.ToUpper())
                {
                    Console.WriteLine("L'élève '" + etudiants[i].nom + etudiants[i].prenom + "' habite dans la ville donnée en paramètre. \n");
                }
            }

            // SI LES ÉTUDIANTS NE VIVENT PAS DANS LA VILLE DONNÉE EN PARAMÈTRE
            Console.WriteLine("=========== SECTION DES ÉLÈVES QUI N'HABITENT PAS DANS LA VILLE DONNÉE EN PARAMÈTRE ===========  \n");
            for (int i = 0; i < etudiants.Length; i++)
            {
                if (villeDonner.ToUpper() != etudiants[i].adresse.ville.ToUpper())
                {
                    Console.WriteLine("L'élève '" + etudiants[i].nom + etudiants[i].prenom + "' n'habite pas dans la ville donnée en paramètre. \n");
                }
            }
            Console.WriteLine("Fin du programme. Appuyez sur 'ENTER' pour continuer");
            Console.ReadLine();
        }


        // MAIN
        static void Main(string[] args)
        {
            // Déclaration du Array d'étudiant
            EtudiantDuCollege[] tabEtudiants = new EtudiantDuCollege[8];
            

                //              COMMENCEMENT DES IDENTIFICATEURS


            // Déclaration des noms
            tabEtudiants[0].nom = "Uch ";
            tabEtudiants[1].nom = "Patate ";
            tabEtudiants[2].nom = "Jungle ";
            tabEtudiants[3].nom = "Ninja ";
            tabEtudiants[4].nom = "Billy ";
            tabEtudiants[5].nom = "Tourbillon ";
            tabEtudiants[6].nom = "Hassan ";
            tabEtudiants[7].nom = "Giovanni ";

            // Déclaration des prénoms
            tabEtudiants[0].prenom = "Richardnak";
            tabEtudiants[1].prenom = "Pillée";
            tabEtudiants[2].prenom = "George";
            tabEtudiants[3].prenom = "Tortue";
            tabEtudiants[4].prenom = "Bob";
            tabEtudiants[5].prenom = "Katarina";
            tabEtudiants[6].prenom = "Vusok";
            tabEtudiants[7].prenom = "Dehbite";


            //              COMMENCEMENT DE LA DATE DE NAISSANCE


            // Déclaration des jours
            tabEtudiants[0].dateNaissance.jour = 01;
            tabEtudiants[1].dateNaissance.jour = 01;
            tabEtudiants[2].dateNaissance.jour = 01;
            tabEtudiants[3].dateNaissance.jour = 01;
            tabEtudiants[4].dateNaissance.jour = 01;
            tabEtudiants[5].dateNaissance.jour = 01;
            tabEtudiants[6].dateNaissance.jour = 01;
            tabEtudiants[7].dateNaissance.jour = 01;

            // Déclaration des mois
            tabEtudiants[0].dateNaissance.mois = 12;
            tabEtudiants[1].dateNaissance.mois = 12;
            tabEtudiants[2].dateNaissance.mois = 12;
            tabEtudiants[3].dateNaissance.mois = 12;
            tabEtudiants[4].dateNaissance.mois = 12;
            tabEtudiants[5].dateNaissance.mois = 12;
            tabEtudiants[6].dateNaissance.mois = 12;
            tabEtudiants[7].dateNaissance.mois = 12;

            // Déclaration des années
            tabEtudiants[0].dateNaissance.annee = 2000;
            tabEtudiants[1].dateNaissance.annee = 2000;
            tabEtudiants[2].dateNaissance.annee = 2000;
            tabEtudiants[3].dateNaissance.annee = 2000;
            tabEtudiants[4].dateNaissance.annee = 2000;
            tabEtudiants[5].dateNaissance.annee = 2000;
            tabEtudiants[6].dateNaissance.annee = 2000;
            tabEtudiants[7].dateNaissance.annee = 2000;


            //              COMMENCEMENT DE SEXE


            Random rdmSexe = new Random();
            char[] sexes = { 'M', 'F' };


            // Déclaration des sexes
            tabEtudiants[0].sexe = sexes[rdmSexe.Next(sexes.Length)];
            tabEtudiants[1].sexe = sexes[rdmSexe.Next(sexes.Length)];
            tabEtudiants[2].sexe = sexes[rdmSexe.Next(sexes.Length)];
            tabEtudiants[3].sexe = sexes[rdmSexe.Next(sexes.Length)];
            tabEtudiants[4].sexe = sexes[rdmSexe.Next(sexes.Length)];
            tabEtudiants[5].sexe = sexes[rdmSexe.Next(sexes.Length)];
            tabEtudiants[6].sexe = sexes[rdmSexe.Next(sexes.Length)];
            tabEtudiants[7].sexe = sexes[rdmSexe.Next(sexes.Length)];


            //              COMMENCEMENT DE PROGRAMME


            Random rdmProgramme = new Random();
            int valProgramme = 0;
            for (int i = 0; i < 8; i++)
            {
                valProgramme = rdmProgramme.Next(1, 401);
            }
            

            // Déclaration des programmes
            tabEtudiants[0].programme = rdmProgramme.Next(valProgramme);
            tabEtudiants[1].programme = rdmProgramme.Next(valProgramme);
            tabEtudiants[2].programme = rdmProgramme.Next(valProgramme);
            tabEtudiants[3].programme = rdmProgramme.Next(valProgramme);
            tabEtudiants[4].programme = rdmProgramme.Next(valProgramme);
            tabEtudiants[5].programme = rdmProgramme.Next(valProgramme);
            tabEtudiants[6].programme = rdmProgramme.Next(valProgramme);
            tabEtudiants[7].programme = rdmProgramme.Next(valProgramme);


            //               CCOMMENCEMENT DES ADDRESSES


            // Déclaration des numéros
            tabEtudiants[0].adresse.numero = 420;
            tabEtudiants[1].adresse.numero = 360;
            tabEtudiants[2].adresse.numero = 1337;
            tabEtudiants[3].adresse.numero = 3800;
            tabEtudiants[4].adresse.numero = 2019;
            tabEtudiants[5].adresse.numero = 9;
            tabEtudiants[6].adresse.numero = 10;
            tabEtudiants[7].adresse.numero = 21;

            // Déclaration de rues
            tabEtudiants[0].adresse.rue = "boul Boulette";
            tabEtudiants[1].adresse.rue = "avn de Viande";
            tabEtudiants[2].adresse.rue = "boul Bouleversé";
            tabEtudiants[3].adresse.rue = "rue Ruelle";
            tabEtudiants[4].adresse.rue = "boul 3.1416-9";
            tabEtudiants[5].adresse.rue = "boul Vanier";
            tabEtudiants[6].adresse.rue = "autoroute 649";
            tabEtudiants[7].adresse.rue = "Rue Sherbroom";

            // Déclaration de ville
            tabEtudiants[0].adresse.ville = "Laval";
            tabEtudiants[1].adresse.ville = "Laval";
            tabEtudiants[2].adresse.ville = "Montreal";
            tabEtudiants[3].adresse.ville = "Montreal";
            tabEtudiants[4].adresse.ville = "Montreal";
            tabEtudiants[5].adresse.ville = "Trois-Rivière";
            tabEtudiants[6].adresse.ville = "Gatineau";
            tabEtudiants[7].adresse.ville = "Longueuil";

            // Déclaration de Code Postal
            tabEtudiants[0].adresse.codePostal = "Y3E T3R ";
            tabEtudiants[1].adresse.codePostal = "3L1 T3S ";
            tabEtudiants[2].adresse.codePostal = "1O1 0I0 ";
            tabEtudiants[3].adresse.codePostal = "H3Y 5I5 ";
            tabEtudiants[4].adresse.codePostal = "H1N 1R1 ";
            tabEtudiants[5].adresse.codePostal = "R1P 505 ";
            tabEtudiants[6].adresse.codePostal = "B0N 7R3 ";
            tabEtudiants[7].adresse.codePostal = "R2D 2C3";

            ClasserSexeEtudiants(tabEtudiants);
            LimiterProgrammeEtudiant(tabEtudiants);
            TrierNomFamille(tabEtudiants);
            MontrerEtudiantsDansVille(tabEtudiants);
        }
    }
}
