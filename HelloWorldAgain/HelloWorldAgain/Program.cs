using System;

namespace HelloWorldAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int pay;

            // Instantiating an Object
            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatedPay(1000, 400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Jane", "Lee");
            staff2.HoursWorked = 160;
            pay = staff2.CalculatedPay();
            Console.WriteLine("Pay = {0}", pay);

            Staff staff3 = new Staff("Carol");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatedPay();
            Console.WriteLine("Pay = {0}", pay);

            //string userName = "";
            //int userAge;
            //int currentYear = 0;

            //Console.Write("Please enter your name: ");
            //userName = Console.ReadLine();
            //Console.Write("Please enter your age: ");
            //userAge = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter the current year: ");
            //currentYear = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.", userName, userAge, currentYear - userAge);
            //Console.Read();
            //Console.ReadLine();

            //Console.Write("Please enter your age: ");
            //userAge = Convert.ToInt32(Console.ReadLine());

            //if (userAge < 0 || userAge > 100)
            //{
            //    Console.WriteLine("Invalid Age");
            //    Console.WriteLine("Age must be between 0 to 100");
            //}
            //else if (userAge < 18)
            //    Console.WriteLine("Sorry you are underage");
            //else if (userAge < 21)
            //    Console.WriteLine("You need parental consent");
            //else
            //{
            //    Console.WriteLine("Congratulations");
            //    Console.WriteLine("You may sign up for the event!");
            //}

            //int mynum = 3 > 2 ? 10 : 5;

            //Console.Write("Enter your grade: ");
            //string userGrade = Console.ReadLine();

            //switch (userGrade)
            //{
            //    case "A+":
            //    case "A":
            //        Console.WriteLine("Distinction");
            //        break;
            //    case "B":
            //        Console.WriteLine("B Grade");
            //        break;
            //    case "C":
            //        Console.WriteLine("C Grade");
            //        break;
            //    default:
            //        Console.WriteLine("Fail");
            //        break;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] myNumbers = { 10, 20, 30, 40, 50 };

            //for (int i = 0; i < myNumbers.Length; i++)
            //{
            //    Console.WriteLine(myNumbers[i]);
            //}

            //char[] message = { 'H', 'e', 'l', 'l', 'o' };
            //foreach (char i in message)
            //    Console.Write(i);

            //int counter = 100;
            //int i = 0;

            //while (counter > 5)
            //{
            //    Console.WriteLine("Counter = {0}", counter);
            //    counter = counter - 1;
            //}

            //for (i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("i = {0}", i);
            //    if (i == 2)
            //        break;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("i = {0}", i);
            //    if (i == 2)
            //        continue;
            //    Console.WriteLine("I will not be printed if i = 2. \n");
            //}

            //do
            //{
            //    Console.WriteLine("Counter = {0}", counter);
            //    counter++;
            //} while (counter < 0);

            //int numerator, denominator;

            //Console.Write("Please enter the numerator: ");
            //numerator = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter the denominator: ");
            //denominator = Convert.ToInt32(Console.ReadLine());

            //try
            //{
            //    Console.WriteLine("The result is {0}.", numerator/denominator);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("---- End of Error Handling Example ----");
            //}

            //int choice = 0;
            //int[] numbers = { 10, 11, 12, 13, 14, 15 };
            //Console.Write("Please enter the index of the array: ");

            //try
            //{
            //    choice = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("numbers[{0}] = {1}", choice, numbers[choice]);
            //} catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error: Index should be from 0 to 5.");
            //} catch (FormatException)
            //{
            //    Console.WriteLine("Error: You did not enter an Integer.");
            //} catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }

    // OOP
    class Staff
    {
        // Only can be access inside staff class
        // Properties // Fields simply a variable that is declared inside a class to store data
        private string nameOfStaff; // Access modifier
        private const int hourlyRate = 30; // Access modifier
        
        //public int HoursWorked { get; set; } // declare auto-implemented property
        //public int HoursWorked { get; private set; } // Read only Property

        // Method
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public int CalculatedPay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hworked * hourlyRate;

            if (hworked > 0)
                return staffPay;
            else
                return 0;
        }

        // Overloading
        public int CalculatedPay(int bonus, int allowence)
        {
            PrintMessage();

            if (hworked > 0)
                return hworked * hourlyRate + bonus + allowence;
            else
                return 0;
        }

        // ToString() Method
        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hworked = " + hworked;
        }

        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("---------------------------");
        }

        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("---------------------------");
        }
        // This is equivalent to
        /* how to declare access private property */
        private int hworked; // Access modifier 
        public int HoursWorked
        {
            get
            {
                return hworked;
            }
            set
            {
                if (value > 0)
                    hworked = value;
                else
                    hworked = 0;
            }
        }
    }

    class MyClass
    {
        // Non static members
        public string message = "Hello World";
        public string Name { get; set; }
        public void DisplayName()
        {
            Console.WriteLine("Name = {0}", Name);
        }

        // Static members
        public static string greetings = "Good morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }
    }
}

