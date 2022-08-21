using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> cities = new Dictionary <int,string> ();
            
            cities.Add(06, "Ankara");
            cities.Add(01, "Adana");
            
            Console.WriteLine(cities.Count);
            


            MyDictionary<int, string> cities2 = new MyDictionary<int, string>();
            
            cities2.Add(75, "Ardahan");
            cities2.Add(76, "Iğdır");
            
            Console.WriteLine(cities2.Count);
           
        }


    }
}
