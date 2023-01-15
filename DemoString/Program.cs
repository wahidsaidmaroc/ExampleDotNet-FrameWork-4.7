using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {

            #region "Exemples string vide ou null"

            string message1;
            string messageNull = null;
            string messageVide = System.String.Empty;

            #endregion

            #region "Exemple '\' "

            string urlType = @"http://wwww.google.com";
            string pathNew = "c:\\rossier\\naid";
            string pathOld = @"c:\rossier\naid";
            Console.WriteLine(pathOld);

            #endregion




            string sMin = "Said wahid";
            Console.WriteLine(sMin);

            String sMaj = "Wahid";
            Console.WriteLine(sMaj);
            Console.WriteLine(sMaj.Length);
            Console.WriteLine(sMaj.ToLower());

            Console.WriteLine(sMaj.ToUpper());


            Console.WriteLine(sMaj.Substring(2, 2));


            #region "Concat"

            Console.WriteLine(sMaj + " " + sMin);
            string result = string.Concat(sMaj, sMin);

            #endregion


            #region "Interpolation"

            string nom = "WAHID";
            string prenom = "Said";
            string phrase = $"Mon nom est  {nom} ::: Mon Prénom est {prenom}";
            Console.WriteLine(phrase);

            #endregion




            #region "Access"

            string accessVar = "OUMDIN ACADEMY";
            Console.WriteLine(accessVar[5]);
            Console.WriteLine(accessVar.IndexOf("a"));


            #endregion


            #region "Access"
            string replaceVar = "OUMDIN ACADEMY";
            Console.WriteLine(replaceVar.Replace("A", "B") );
            #endregion


            Console.ReadKey();





        }
    }
}
