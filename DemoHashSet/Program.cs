using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");

            Console.WriteLine("Elements of myhash1:");

            // Accessing elements of HashSet
            // Using foreach loop
            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

            // Creating another HashSet
            // using collection initializer
            // to initialize HashSet
            HashSet<int> myhash2 = new HashSet<int>() {10,
                               100,1000,10000,100000};

            // Display elements of myhash2
            Console.WriteLine("Elements of myhash2:");
            foreach (var value in myhash2)
            {
                Console.WriteLine(value);
            }

            #region "Remove"
            // Creating HashSet
            // Using HashSet class
            HashSet<string> myhash = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash.Add("C");
            myhash.Add("C++");
            myhash.Add("C#");
            myhash.Add("Java");
            myhash.Add("Ruby");

            // Before using Remove method
            Console.WriteLine("Total number of elements present (Before Removal)" +
                                " in myhash: {0}", myhash.Count);
            #endregion



            #region "Union"
            // Creating HashSet
            // Using HashSet class
            HashSet<string> myhashD1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhashD1.Add("C");
            myhashD1.Add("C++");
            myhashD1.Add("C#");
            myhashD1.Add("Java");
            myhashD1.Add("Ruby");

            // Creating another HashSet
            // Using HashSet class
            HashSet<string> myhashD2 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhashD2.Add("PHP");
            myhashD2.Add("C++");
            myhashD2.Add("Perl");
            myhashD2.Add("Java");

            // Using UnionWith method
            myhash1.UnionWith(myhashD2);
            foreach (var ele in myhashD1)
            {
                Console.WriteLine(ele);
            }
            #endregion



            #region "IntersectWith"
            //This method combines the elements that are common
            //to both the collections.
            HashSet<string> names = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit"
            };
            HashSet<string> names1 = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit",
                "Deepak",
                "Mohit"
            };
            names.IntersectWith(names1);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            #endregion


            #region "ExceptWith"

            //This method removes all the elements that are present in the other collections from the collection on which it is called.
            HashSet<string> namesExceptWith = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit"
            };


            HashSet<string> names1ExceptWith = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit",
                "Deepak",
                "Mohit"
            };
            names1ExceptWith.ExceptWith(names);
            foreach (var name in names1ExceptWith)
            {
                Console.WriteLine(name);
            }
            #endregion

        }
    }
}
