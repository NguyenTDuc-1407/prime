int number = 1;
int i =2;
do
{
    Console.WriteLine("Enter a number: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number >= 2)
    {
        if (number % i == 0)
        {
            Console.WriteLine(number + " is not a prime");
            break;
        }
        else
        {
            Console.WriteLine(number + " is a prime");
        }
        i++;
    }else
    {
        Console.WriteLine(number + " is not a prime");
    }

} while (i <= Math.Sqrt(number));

