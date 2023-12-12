namespace SelStatementsDemoCSharp_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if/else

            bool condition = false;

            if (condition == true)
            {
                Console.WriteLine("If scope");
            }
            else
            {
                Console.WriteLine("Else scope");
            }

            int a = 200;
            int b = 20;

            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal.");
            }
            else if (b < a && a == 5)
            {
                Console.WriteLine("Else if scope");
            }
            else
            {
                Console.WriteLine("None of these were true");
            }

            // Ternary operator (inline if)

            int i = 0;

            string message = i > 0 ? "Positive" : "Zero";

            Console.WriteLine(message);

            //Switch case 

            string day = "Funday";

            switch (day)
            {
                case "Sunday":
                    Console.WriteLine("It is Sunday, my dudes.");
                    break;
                case "Monday":
                    Console.WriteLine("It is Monday, my dudes.");
                    break;
                case "Tuesday":
                    Console.WriteLine("It is Tuesday, my dudes.");
                    break;
                case "Wednesday":
                    Console.WriteLine("It is Wednesday, my dudes.");
                    break;
                case "Thursday":
                    Console.WriteLine("It is Thursday, my dudes.");
                    break;
                case "Friday":
                    Console.WriteLine("It is Friday, my dudes.");
                    break;
                case "Saturday":
                    Console.WriteLine("It is Saturday, my dudes.");
                    break;
                default:
                    Console.WriteLine("This is not a day of the week");
                    break;
            }


        }
    }
}
