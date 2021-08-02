using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Crin: Welcome! Popcorn is £10, Please insert cash here: ");

        int cash =     Convert.ToInt32(Console.ReadLine());

        if (cash < 10)
        {
        Console.WriteLine("Card Declined.");
        Console.WriteLine("Crin: Sorry Mate, guess you can't enjoy your popcorn.");
        Console.WriteLine("Do you want to try again?");
        Console.ReadLine();
        

      }else if (cash > 10) {
        int result = cash - 10;

        Console.WriteLine($"Here's your cash :D");
        Typewrite($"Crin hands you £{result}");
        Console.ReadLine();

        }






        else
        {
        Console.WriteLine("Card Approved.");
        Console.WriteLine("Crin: Enjoy!");
        }

    }
        static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(60);
            }

        }




}
