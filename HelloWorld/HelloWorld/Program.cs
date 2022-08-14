using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    // A Simple Program to display the words Hello World
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, how are you?");
            int userAge = 30;
            Console.WriteLine(userAge);
            Console.WriteLine("userAge");
            Console.WriteLine("Hello, " + "how are you?" + " I love C#.");
            int results = 79;
            Console.WriteLine("You scored " + results + " marks for your test.");
            //Console.WriteLine("{0}! You Scored {1} marks for your test.", "Good morning", results);
            Console.WriteLine("{1}! You Scored {0} marks for your test.", "Good morning", results);
            Console.WriteLine("The number is {0:F3}.", 123.45678);
            Console.WriteLine("Deposite = {0:C}. Account balance = {1:C}.", 2125, 12345.678);
            Console.WriteLine("Microsoft".Substring(1, 3));
            Console.WriteLine("Hello World".Length);
            Console.WriteLine("Hello\tWorld");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("\\");
            Console.WriteLine("I am 6'5\" tall");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            int newUserInput = Convert.ToInt32(userInput);
            //Console.WriteLine("How are you?");
            //Console.Read(); // reads the next character
            //Console.ReadLine();
            //Console.Write("Hello");
            //Console.Write("How are you");
        }
    }
}

namespace First
{
    class MyClass
    {
        // This is a comment
        // This is another comment
        // This is yet another comment

        /* int (hold numbers -2,147,483,648 to 2,147,483,647.) Example include 15, 407, -908, 6150 etc
         * byte (narrowed range from 0 to 255.)
         * float (numbers with decimal places such as 12.43, 5.2 and -9.12.) float can store numbers from -3.4 x 10'38 to +3.4 x 10'38.
         * It uses 8 bytes of storage and has a precision of approximity 7 digits. If you uses float to store number like 1.23456789 (10 digits), the number will be rounded
         * off to 1.234568 (7 digits).
         * Double (float number but can store a much wider range of numbers) It can store numbers from (+/-)5.0 x 10-324 to (+/-)1.7 x 10308 and has a
         * precision of about 15 to 16 digits. Double is the default floating point data type in C#. In other words, if you write a
         * number like 2.34, C# treats it as a double by default.
         * Decimal but has a smaller range than float and double. However, it has a much greater precision of approximately 28-29 digits.
         * If your program requires a high degree of precision when storing non integral
         * numbers, you should use a decimal data type. An example is when you are
         * writing a financial application where precision is very important.
         * Char stands for character and is used to store single Unicode characters such as ‘A’, ‘%’, ‘@’ and ‘p’ etc.
         * Bool stands for boolean and can only hold two values: true and false. It is commonly used in control flow statements.
         * Naming a variable you can name your variables userName, user_name or userName2 but not 2userName.
         * there are some reserved words that you cannot use as a variable name because they already have preassigned meanings in C#. 
         * These reserved words include words like Console, if, while etc. Variabel names is case sensitive, username is not the same as userName
         * There are two conventions when naming a variable in C#. We can either use the camel case notation or use underscores. 
         * Camel casing is the practice of writing compound words with mixed casing, capitalising the first letter of each word except the first word (e.g. thisIsAVariableName).
         * This is the convention that we’ll be using in the rest of the book. Alternatively, another common practice is to use underscores (_) to separate the words. 
         * If you prefer, you can name your variables like this: this_is_a_variable_name.
         * Initialize Variable Every time you declare a new variable, you need to give it an initial value. 
         * This is known as initializing the variable. You can change the value of the variable in your program later.
         * Assignment Sign (x = 5; y = 10;)
         * Basic Operator (+ addition, - substraction, * multiplication, / division, and % modulus)
         * More Assignment Operators (+=, -=, *=) The program will first evaluate the expression on the right (x + 2) and assign the answer to the left. So eventually the statement above becomes x <- 12.
         * Instead of writing x = x + 2, we can also write x += 2 to express the same meaning.
         * The += sign is actually a shorthand that combines the assignment sign with the addition operator. Hence, x += 2 simply means x = x + 2.
         * Similarly, if we want to do a subtraction, we can write x = x - 2 or x -= 2. The same works for all the 5 operators mentioned in the section above.
         * Most programming languages also have the ++ and –– operators. The ++ operator is used when you want to increase the value of a variable by 1.
         * The ++ operator can be placed in front of or behind the variable name. This affects the order in which tasks are performed. 
         * Suppose we have an integer named counter. If we write Console.WriteLine(counter++);
         * the program first prints the original value of counter before incrementing counter by 1. In other words, it executes the tasks in this order Console.WriteLine(counter); 
         * counter = counter + 1; On the other hand, if we write Console.WriteLine(++counter); 
         * the program first increments counter by 1 before printing the new value of counter. 
         * In other words, it executes the tasks in this order counter = counter + 1; Console.WriteLine(counter);
         */
    }
}

namespace Second
{
    class MyClass
    {
        /* This is also a comment
         * This also a comment
         * This is yet another comment
         */

        /* Array An array is simply a collection of data that are normally related to each other.
         * Suppose we want to store the ages of 5 users. 
         * Instead of storing them as user1Age, user2Age, user3Age, user4Age and user5Age, we can store them as an array.
         * An array can be declared and initialized as follows: int[] userAge = {21, 22, 23, 24, 25};
         * We can declare an array first and initialize it later, To do that, we need to use the new operator:
         * int[] userAge = new int[5]; 
         * userAge = new [] {21, 22, 23, 24, 25};
         */
    }
}