using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePratique4_RichardnakUCH
{
    public struct Etudiant
    {
        public string nom;
        public string prenom;

        public char sexe; //@@@@@@@@
        public int programme; //@@@@@@@@

        public Date dateNaissance;
        public Adresse adresse;

        public struct Adresse
        {
            public int numero;
            public string rue;
            public string ville;
            public string codePostal;
        }

        public struct Date
        {
            public int mois;
            public int jour;
            public int annee;

        }

        //public static Array sexRandom(int length)
        //{
        //    string sex = "MF";
        //    Random rdnsexe = new Random();
        //    int sexs = rdnsexe.Next(maxValue);

        //    return sex[sexs];
        //}
        public static char GetRandomGender()
        {
            char[] genders = { 'M', 'F' };
            Random randGender = new Random();
            return genders[randGender.Next(genders.Length)];
        }

        //    return sex[sexRandom];
        //}

        //public int valProgramme(int p)
        //{
        //    Random random = new Random();
        //    int rndProgramme = random.Next(1, 401);
        //    return programme;
        //}

        //static void TabSexEtudiant(char x)
        //{
        //    if (sexetudiant == M)
        //        Console.Write(Etudiant1);
        //    else
        //        Console.Write(Etudiant1);
        //}

        static void TabProgrammeEtudiant(int prog)
        {
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant etudiant1;
            Etudiant etudiant2;
            Etudiant etudiant3;
            Etudiant etudiant4;
            Etudiant etudiant5;
            Etudiant etudiant6;
            Etudiant etudiant7;
            Etudiant etudiant8;

            //              COMMENCEMENT DE IDENTIFICATEURS
            //              COMMENCEMENT DE IDENTIFICATEURS


            // Déclaration des noms
            etudiant1.nom = "Lara";
            etudiant2.nom = "Ronny";
            etudiant3.nom = "Andy";
            etudiant4.nom = "Rich";
            etudiant5.nom = "Bob";
            etudiant6.nom = "Billy";
            etudiant7.nom = "mario";
            etudiant8.nom = "lucas";

            // Déclaration des prénoms
            etudiant1.prenom = "Aral";
            etudiant2.prenom = "Ynnor";
            etudiant3.prenom = "Ydna";
            etudiant4.prenom = "Hcir";
            etudiant5.prenom = "Bob";
            etudiant6.prenom = "Yllib";
            etudiant7.prenom = "Oiram";
            etudiant8.prenom = "Sacul";

            //              COMMENCEMENT DE SEXE
            //              COMMENCEMENT DE SEXE



            //string sex = "MF";
            //int firstLetter = 0;
            //int lastLetter = 0;
            //int sexRandom;
            //firstLetter = Convert.ToInt32(sex.Substring(0, 0));
            //lastLetter = Convert.ToInt32(sex.Substring(1, 1));
            //Random rdnsexe = new Random();
            //sexRandom = rdnsexe.Next(firstLetter, lastLetter);

            //Console.WriteLine(sexRandom);

            //etudiant1.sexe = Convert.ToChar(sexRandom);


            //              COMMENCEMENT DE PROGRAMME
            //              COMMENCEMENT DE PROGRAMME

            etudiant1.sexe = Get


            //              COMMENCEMENT DE LA DATE DE NAISSANCE
            //              COMMENCEMENT DE LA DATE DE NAISSANCE


            // Déclaration des jours
            etudiant1.dateNaissance.jour = 01;
            etudiant2.dateNaissance.jour = 01;
            etudiant3.dateNaissance.jour = 01;
            etudiant4.dateNaissance.jour = 01;
            etudiant5.dateNaissance.jour = 01;
            etudiant6.dateNaissance.jour = 01;
            etudiant7.dateNaissance.jour = 01;
            etudiant8.dateNaissance.jour = 01;

            // Déclaration des mois
            etudiant1.dateNaissance.mois = 12;
            etudiant2.dateNaissance.mois = 12;
            etudiant3.dateNaissance.mois = 12;
            etudiant4.dateNaissance.mois = 12;
            etudiant5.dateNaissance.mois = 12;
            etudiant6.dateNaissance.mois = 12;
            etudiant7.dateNaissance.mois = 12;
            etudiant8.dateNaissance.mois = 12;

            // Déclaration des années
            etudiant1.dateNaissance.annee = 2000;
            etudiant2.dateNaissance.annee = 2000;
            etudiant3.dateNaissance.annee = 2000;
            etudiant4.dateNaissance.annee = 2000;
            etudiant5.dateNaissance.annee = 2000;
            etudiant6.dateNaissance.annee = 2000;
            etudiant7.dateNaissance.annee = 2000;
            etudiant8.dateNaissance.annee = 2000;


            //               CCOMMENCEMENT DES ADDRESSES
            //               CCOMMENCEMENT DES ADDRESSES


            // Déclaration des numéros
            etudiant1.adresse.numero = 2;
            etudiant2.adresse.numero = 2;
            etudiant3.adresse.numero = 2;
            etudiant4.adresse.numero = 2;
            etudiant5.adresse.numero = 2;
            etudiant6.adresse.numero = 2;
            etudiant7.adresse.numero = 2;
            etudiant8.adresse.numero = 2;

            // Déclaration de rues
            etudiant1.adresse.rue = "Rue Sherbroom";
            etudiant2.adresse.rue = "Rue Sherbroom";
            etudiant3.adresse.rue = "Rue Sherbroom";
            etudiant4.adresse.rue = "Rue Sherbroom";
            etudiant5.adresse.rue = "Rue Sherbroom";
            etudiant6.adresse.rue = "Rue Sherbroom";
            etudiant7.adresse.rue = "Rue Sherbroom";
            etudiant8.adresse.rue = "Rue Sherbroom";

            // Déclaration de ville
            etudiant1.adresse.ville = "ville Laval";
            etudiant2.adresse.ville = "ville Laval";
            etudiant3.adresse.ville = "ville Laval";
            etudiant4.adresse.ville = "ville Laval";
            etudiant5.adresse.ville = "ville Laval";
            etudiant6.adresse.ville = "ville Laval";
            etudiant7.adresse.ville = "ville Laval";
            etudiant8.adresse.ville = "ville Laval";

            // Déclaration de Code Postal
            etudiant1.adresse.codePostal = "Y3E T3R ";
            etudiant2.adresse.codePostal = "Y3E T3R ";
            etudiant3.adresse.codePostal = "Y3E T3R ";
            etudiant4.adresse.codePostal = "Y3E T3R ";
            etudiant5.adresse.codePostal = "Y3E T3R ";
            etudiant6.adresse.codePostal = "Y3E T3R ";
            etudiant7.adresse.codePostal = "Y3E T3R ";
            etudiant8.adresse.codePostal = "Y3E T3R ";

            Console.WriteLine("Ya yeeeeeeeeeeeeeeeeeeeeeeeeeet");
        }
    }
}