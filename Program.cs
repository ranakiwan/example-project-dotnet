        using System.Reflection.Metadata;

        Console.WriteLine("enter the first number");
        int number1 =Convert.ToInt32(Console .ReadLine());   
        Console.WriteLine("enter the second number")                    ;
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the sign: + for adition, - for subtraction, * for multiplication, and / for devision");
        String sg = Console.ReadLine();
        if (sg == "+")
        {
            String result = number1 + "+" + number2 + "=";
            Console.WriteLine(result + (number1 + number2));
        }
        else if (sg == "-")
        {
            String result = number1 + "-" + number2 + "=";
            Console.WriteLine(result + (number1 - number2));

        }
        else if (sg == "*")
        {
            String result = number1 + "*" + number2 + "=";
            Console.WriteLine(result + (number1 * number2));
        }

        else if (sg == "/")
        {
            String result = number1 + "/" + number2 + "=";
            Console.WriteLine(result + (number1 / number2));
        }

else
{
   Console.WriteLine("there's an error");
}    