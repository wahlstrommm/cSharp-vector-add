using System;

namespace Vektor_övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej skriv in 10 tal:"); //användare skriver in 10 tal
            int[] anvandareTal = new int[10]; //ny vektor som kommer ha plats för 10.
            for (int i = 0; i < anvandareTal.Length; i++ ) // for loop. 
            {
                 anvandareTal[i]= Convert.ToInt32(Console.ReadLine()); //tar in det användaren har skrivit
            }
            foreach (int tal in anvandareTal) // foreach kommer nedanför skriva ut.
            {
                Console.Write(tal + " "); // kommer skirva ut vektor och de tal som användaren har skrivit.
            }
        }
    }
}
