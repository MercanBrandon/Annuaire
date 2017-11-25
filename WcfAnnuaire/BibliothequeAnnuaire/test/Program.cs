using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliothequeAnnuaire;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact unContact = new Contact("Nelson", "Vladimir", "0768408959", "");
            Console.WriteLine("nouveau contact : {0} {1} avec le numéro de téléphone: {2}",unContact.NomContact,unContact.PrenomContact,unContact.TelPortContact);
            Console.ReadKey();
        }
    }
}
