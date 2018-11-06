using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Demesion
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] temperture = new double[,]
            {
                {12.50,10.45,12.30,14.60,17.70,11.20,12.50},
                {12.22,11.00,10.00,20.00,21.00,14.00,15.50},
                {13.00,14.00,14.50,14.60,12.30,14.00,14.60}
            };

            Random random = new Random();
            int a = random.Next(0, 2);
            int b = random.Next(0, 6);
            Console.WriteLine(temperture[a,b]);
            Console.ReadLine();
        }
    }
}
