using System;
using System.Collections.Generic;

namespace Uppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lista = new List<double>();
            lista.Add(5);
            lista.Add(3);
            lista.Add(18);
            lista.Add(12);
            lista.Add(6);
            lista.RemoveAt(3);
            foreach (double element in lista)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.WriteLine("Medelvärdet är " + Medelvärde(lista));
        }
        public static double Medelvärde(List<double> li)
        {
            double summa = 0;
            foreach (double element in li)
            {
                summa += element;
            }
            return summa / li.Count;
        }
    }
}
