using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Born { get; set; }
        public string Lieu { get; set; }
        public int Identifiant { get; set; }
        public double Contact { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }

        public Etudiant() // Pour la serialisation
        {
              
        }

        public Etudiant(string lastname, string firstname, string born, string lieu, int identifiant, double contact, string email, byte[] picture)
        {
            Lastname = lastname;
            Firstname = firstname;
            Born = born;
            Lieu = lieu;
            Identifiant = identifiant;
            Contact = contact;
            Email = email;
            Picture = picture;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Identifiant == etudiant.Identifiant;
        }

        public override int GetHashCode()
        {
            return 574969646 + Identifiant.GetHashCode();
        }
    }
}
