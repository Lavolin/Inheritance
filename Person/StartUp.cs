namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            
            if (age <= 15)
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            else
            {
                Person person = new Person(name, age);
                Console.WriteLine(person);
                
            }

        }
    }
}

namespace Person
{
    public class Person
    {
        // 1. Add Fields

        // 2. Add Constructor

        // 3. Add Properties

        // 4. Add Methods

    }
}

namespace Child : Person
{
    public class Child
    {
       

    }
}