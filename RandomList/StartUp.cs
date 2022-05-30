using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           RandomList list = new RandomList();
            list.Add("Tosho");
            list.Add("Tosho1");
            list.Add("Tosho2");
            list.Add("Tosho3");

            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
        }
    }
}
