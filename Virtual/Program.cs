using System;

namespace Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Mouse());
            Mouse mouse = new Mouse();
            Elephant elephant = new Elephant();

            Eat(mouse);
            Eat(elephant);
        }

        public static void Eat(Animal animal)
        {

            animal.Eat();
            Console.WriteLine(animal.Food);
        }
    }
}
