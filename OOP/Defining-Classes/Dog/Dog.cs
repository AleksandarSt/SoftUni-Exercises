using System;
namespace Dog
{
    class Dog
    {
        public Dog()
            :this(null,null)
        {

        }

        public Dog(string name,string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("{0} is {1} and barks: WOW-WOW!",this.Name??"Unnamed dog",this.Breed??"Unknown breed");
        }
    }
}
