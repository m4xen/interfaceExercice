using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new CarsForSale();
            
            repo.ListCars();

            Console.WriteLine("🤡🔫");
            Console.ReadLine();
        }
    }
    interface Repository
    {
        void ListCars();
    }
    class CarsForSale : Repository
    {
        string[] car = new string[]
        {
            "Audi quattro",
            "Ford rs200",
            "Peugeot 205",
            "MG Metro 6R4",
            "Lancia 037",
            "Subaru impreza",
            "Opel manta"
        };

        //int i;

        public void ListCars()
        {
            int i;
            for (i = 0; i < car.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + car[i]);
            }
        }
    }
}