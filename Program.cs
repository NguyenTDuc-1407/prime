﻿int number = 1;
int i = 2;
do
{
    Console.WriteLine("Enter a number: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number < 2) { Console.WriteLine(number + " is not a prime"); }
    else
    {
        bool check = true;
        while (i <= Math.Sqrt(number))
        {
            if (number % i == 0)
            {
                check = false;
                break;
            }
            i++;
        }
        if (check)
        {
            Console.WriteLine(number + " is a prime");
        }
        else
        {
            Console.WriteLine(number + " is not a prime");
        }
    }



} while (i <= Math.Sqrt(number));

