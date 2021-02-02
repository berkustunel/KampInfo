using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1994,
                FirstName = "Berk",
                LastName = "Üstünel",
                IdentityNumber = 1234567890
            });

            //Console.WriteLine("Hello World!");
        }
    }
}
