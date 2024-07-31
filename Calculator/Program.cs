// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Enter the first number");
            decimal num1 = 0;
            if ((decimal.TryParse(Console.ReadLine(), out num1)) == false)
                Console.WriteLine("numbers is only available \nfirst number = 0");


            Console.WriteLine("Choose the operator");
            Console.WriteLine(" 1. +\n 2. -\n 3. *\n 4. /");
            int operatorChoosen = 0;

            while (true)
            {

                try
                {
                    operatorChoosen = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("please select the number of operator");

                }

            }


            Console.WriteLine("Enter the second number");
            decimal num2 = 0;
            if ((decimal.TryParse(Console.ReadLine(), out num2)) == false)
                Console.WriteLine("numbers is only available \nsecond number = 0");


            Console.WriteLine();
            switch (operatorChoosen)
            {
                case 1:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    {
                        try
                        {
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        }
                        catch
                        {
                            Console.WriteLine("Canot devide by zero");
                        }

                        break;

                    }


                default:
                    Console.WriteLine("The number of operator is not available");
                    break;
            }


            Console.WriteLine("Do you want to continue");
            Console.WriteLine("1.yes \n2.No");
            int continue1;

            if (int.TryParse(Console.ReadLine(), out continue1) && continue1 == 2)
            {
                break;

            }
            else if (continue1 != 1)
            {
                Console.WriteLine("Not available");
            }

        }
    }
}