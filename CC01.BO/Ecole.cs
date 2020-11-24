using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class Ecole
    {
        public string Nomecole;

        public string Abreviation;

        public byte[] Logo;

        public string Ville;

        public string Quartier;

        public Ecole(string nomecole, string abreviation, byte[] logo, string ville, string quartier)
        {
            Nomecole = nomecole;
            Abreviation = abreviation;
            Logo = logo;
            Ville = ville;
            Quartier = quartier;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Abreviation == ecole.Abreviation;
        }

        public override int GetHashCode()
        {
            return 1089366679 + EqualityComparer<string>.Default.GetHashCode(Abreviation);
        }
    }
}
