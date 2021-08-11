 using System;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList random = new RandomList();
            Console.WriteLine(random.RandomString());
            random.Add("Tisho");
            random.Add("Tisho2");
            random.Add("Tisho3");
        }
    }
}
