using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //method with out param
            nomMethode();
            var a = methodInt();


            //method witch Param
            MyMethodWithParam("Maroc");
            MyMethodWithParam("USA");


            //Method with Multiple Param;
            MyMethodWithMultipleParam("Maroc", 1, true);

            //Function with Param
            Console.WriteLine(Addition(10, 25));


            //Named Arguments
            //Key: Value
            MyMethodWithMultipleParam(etat: true, pays: "France", orderPays: 54);


            //Method OverLoading : 
            methodOverLoad(14);
            methodOverLoad(14.5);
            methodOverLoad(true, "MAroc");



            //Stop Program.
            Console.ReadKey();

        }




        #region "simple Method"

        /// <summary>
        /// Description My method,
        /// </summary>
        static void nomMethode()
        {
        
        }

        /// <summary>
        /// Description my method,
        /// </summary>
        /// <returns>return parameter type INT</returns>
        static int methodInt()
        {
            return 1;
        }

        string methodString()
        {
            return "1";
        }

        #endregion


        #region "Method with Parameters"

        static void MyMethodWithParam(string pays)
        {
            Console.WriteLine(pays);

        }

        /// <summary>
        /// Description my method.
        /// </summary>
        /// <param name="pays">Pass Pays Param.</param>
        /// <param name="orderPays">Order Pays</param>
        /// <param name="etat">L'etat de pays</param>
        static void MyMethodWithMultipleParam(string pays, int orderPays, bool etat)
        {
            Console.WriteLine("Pays :  {0} ,\n order : {1} ,\n etat {2}", pays, orderPays, etat);

        }

        #endregion


        #region "Function with Param"

        static int Addition(int a , int b)
        {
            return a + b;
        }

        #endregion



        #region "Method OverLoading"

        static int methodOverLoad(int x)
        {
            return x;
        }

        static float methodOverLoad(double x)
        {
            return x;
        }

        static bool methodOverLoad(bool x, string text)
        {
            if (x)
            {
                return false;
            }
            return true;
        }


        #endregion

    }
}
