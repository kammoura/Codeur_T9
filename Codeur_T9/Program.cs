using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Codeur_T9
{
   public class Program
    {

       public static void Main(string[] args)
        {
            Console.WriteLine("Entrer une chaine de Caractére");
            string EntrerUneChaine = Console.ReadLine();
            ChifferementT9.Chaine(EntrerUneChaine);
        }
            
            
        }
    }
