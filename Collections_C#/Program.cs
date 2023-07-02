// See https://aka.ms/new-console-template for more information
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();
        // Push, Pop, Peek

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        Console.WriteLine("Poped value = " + stack.Pop());  //removes the top element in the collections

        Console.WriteLine($"Top element in the stack {stack.Peek()}");

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }


    }
}
