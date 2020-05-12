using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugNS
{
    public class Users

    {

        public string Nom { get; set; }

        public int Age { get; set; }

        public double ArgentDePoche { get; set; }

        public Users(string nom, int age)

        {

            Nom = nom;

            Age = age;

        }

        public void GetUserDetails()

        {

            Console.WriteLine("Nom: {0}, Age: {1}", Nom, Age);

        }

        public void Credite(double montant)
        {
            ArgentDePoche += montant;
        }


        public void Retire(double montant)
        {
            if (ArgentDePoche >= montant)
            {
                ArgentDePoche -= montant;
            }
            else
            {
                throw new ArgumentException(nameof(montant), " en retrait, c'est trop !");
            }
        }

    }
}
