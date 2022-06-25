using System;

namespace classwork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string heroName = "Superman";
            int heroPower = 20 ;

            string villanName = "joker";
            int villanPower = 25 ;

            if (heroPower > villanPower)
            {
                Console.WriteLine( heroName + " is more powerful");

            }
            else if (heroPower < villanPower)
            {
                Console.WriteLine("The " + villanName+ " is more powerful ");
            }
            else
            {
                Console.WriteLine("the hero and the villan are equally powerful ");
            }


        }
    }
}
