using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class MainProgram
    {
        public static void Main()
        {
            try
            {
                Person pesho = new Person("Pesho", "Peshev", 24);

                //Person gosho = new Person("Gosho", string.Empty, 40);
                //Person misho = new Person(string.Empty, "Mishev", 43);
                Person paco = new Person("Ivan", "Ivanov", 121);
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Execption thrown: {0}", ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Execption thrown: {0}", ex.Message);
            }
        }

        

    }
}
