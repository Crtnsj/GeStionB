using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeStionB.Medecin
{
    internal class Bcrypt
    {
        public string Encryption (string pswd)
        {
            string hash = BCrypt.Net.BCrypt.EnhancedHashPassword(pswd,13);
            //hash le mot de passe avec 13 "tours de boucle", ce qui prends environ 800ms
            return hash;
            //renvoie le hash
        }
        public bool Descryption(string pswd, string hash)
        {
            bool result = BCrypt.Net.BCrypt.EnhancedVerify(pswd, hash);
            //compare le mot de passe du formulaire au hash de la BDD
            return result;
            //renvoie true ou false
        }
    }
}
