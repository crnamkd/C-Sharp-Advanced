using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dogs
            //Dog dog1 = new Dog("Timi", 10, Race.Shi_Tsu);
            //Dog dog2 = new Dog("Tobi", 5, Race.Shi_Tsu);
            //Dog dog3 = new Dog("Spajk", 8, Race.Bulldog);

            //List<Dog> dogs = new List<Dog>()
            //{

            //};

            //Console.WriteLine(dog1.ToString());
            //Console.WriteLine(dog1.Bark());
            //Console.WriteLine(dog2.ToString());
            //Console.WriteLine(dog2.Bark());
            //Console.WriteLine(dog3.ToString());
            //Console.WriteLine(dog3.Bark());
            #endregion

            #region Enter country get the capital or reversed ( enter capital to get the country )
            var capitals = new Dictionary<string, string>()
            {
                {"Greece","Athens" },
                {"Serbia", "Belgrade" },
                {"Macedonia","Skopje" },
                {"Bulgaria","Sofia" },
                {"Chile", "Santiago" }

            };

            while (true)
            {
                Console.WriteLine("Enter the name of the country or city: ");
                var input = Console.ReadLine();


                if (capitals.ContainsKey(input))
                {
                    Console.WriteLine($"The capital of {input} is {capitals[input]}");
                }
                else if (capitals.ContainsValue(input))

                {
                    var result = capitals.FirstOrDefault(x => x.Value == input).Key;
                    Console.WriteLine($"The city {input} is capital of {result}");
                }
                else
                {
                    Console.WriteLine("We dont have that in our database !!!");
                }
                Console.ReadLine();
            }
            #endregion

            #region Adora-Construction

            // Empty Region !!!

            #endregion

        }
    }
}
