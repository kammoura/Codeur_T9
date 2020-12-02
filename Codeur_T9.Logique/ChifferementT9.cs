using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codeur_T9
{
   public static class ChifferementT9
    {
        /// <summary>
        /// méthode pour vérifier si une chaine de caracéte contient un caractére particulier
        /// </summary>
        /// <param name="Chaine"></param>
        /// <param name="caractere"></param>
        /// <returns></returns>
        public static bool VerifierCaracterInChaine(string Chaine, char caractere)
        {
            return Chaine.ToLower().Contains(caractere.ToString().ToLower());
          
        }
        /// <summary>
        /// Méthode pour vérifier si la chaine de caractére saisie est not null
        /// </summary>
        /// <param name="chaineSaisie"></param> 
        public static bool Isvalide(string chaineSaisie)
        {
            return chaineSaisie != null;
           

        }
        /// <summary>
        /// Une Méthode qui retourne un message chiffrer en codeur T9
        /// </summary>
        /// <param name="chaineSaisie"></param>
        /// <returns></returns>
        public static string Chaine(string chaineSaisie)
        {
           if(! Isvalide(chaineSaisie))
                throw new ArgumentNullException(nameof(chaineSaisie), "La chaine est Vide");


            List<string> alphaTelephone = new List<string>() {"ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"};

            int GetIndex((string token, int index) couple) => couple != default ? couple.index :- 2;
            
            (string token,int index) TrouverElement(char alphabet) => alphaTelephone
                                                .Select((token, index) => (token, index))
                                                .FirstOrDefault((couple) => couple.token.Contains(alphabet));

                                               
            var result = chaineSaisie
                 .ToUpper()
                 .Select(TrouverElement)
                 .Select(GetIndex)
                 .Select(index => index + 2) 
                 .Select(code9 => code9.ToString());

            return string.Concat(result);


        }
    }
}
