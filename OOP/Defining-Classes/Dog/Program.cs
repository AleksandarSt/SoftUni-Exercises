using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Program
    {
        static void Main()
        {
            Dog unnamedDog = new Dog();
            Dog unnamedSmallDog = new Dog();
            Dog someDog = new Dog("Lassy", "Pekinez");

            unnamedDog.Breed = "Doberman";

            unnamedDog.Bark();
            unnamedSmallDog.Bark();
            someDog.Bark();
        }
    }
}
