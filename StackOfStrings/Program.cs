using System;

namespace StackOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("Tisho");
            stack.Push("Dobri");
            stack.Push("Diqn");

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsEmpty());
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
