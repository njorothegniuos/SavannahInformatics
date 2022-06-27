using System;
using System.Collections;

namespace SavannahInformatics
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Stack my_stack = new Stack();

            //push implementation
            my_stack.Push("Savannah");
            my_stack.Push("Informatics");
            my_stack.Push("making");
            my_stack.Push("healthcare");
            my_stack.Push("simple");
            my_stack.Push(null);
            my_stack.Push(490.98);

            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
            }

            //pop implementation

            //get total item count
            Console.WriteLine("Total elements present in" +
                     " my_stack: {0}", my_stack.Count);

            // view the first element
            Console.WriteLine("Topmost element of my_stack " +
                                  "is: {0}", my_stack.Peek());

            // remove the first element
            Console.WriteLine("Pop Topmost element of my_stack"
                              + " is: {0}", my_stack.Pop());

            //get total item count after removal of first element
            Console.WriteLine("Total elements present in" +
                        " my_stack: {0}", my_stack.Count);


            //check for a specific element in the stack

            if (my_stack.Contains("Savannah") == true)
            {
                Console.WriteLine("Element is found...!!");
            }

            else
            {
                Console.WriteLine("Element is not found...!!");
            }

            //check item in stack from user input:

            string name;

            Console.WriteLine("Enter a value: ");
            name = Console.ReadLine();

            Console.WriteLine($"You entered ...!! {name}");

            //check for a specific element in the stack
            if (my_stack.Contains($"{name}") == true)
            {
                Console.WriteLine($"Element is found...{name}");
            }

            else
            {
                Console.WriteLine($"Element is not found... {name}");
            }
        }
    }
}
