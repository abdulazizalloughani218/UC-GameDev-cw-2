using System;

namespace Functions_Cw
{
    class Program
    {
        static void Main(string[] args)
        {
            double playerSpeed = 1 ;
            double newplayerspeed;
            double SetSpeed()
            {
                double additinalspeed = 2.5;
                double newplayerSpeed = playerSpeed + additinalspeed;
                Console.WriteLine("the old speed is " + playerSpeed + " and the new speed is " + newplayerSpeed);

                return newplayerSpeed;

            }
            newplayerspeed = SetSpeed();

            Console.WriteLine(newplayerspeed);
        }
    }
}
