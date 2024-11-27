using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in en addition eller subtraktion på en rad (t.ex. 4+7 eller 20-9):");
        string input = Console.ReadLine();

        try
        {

            if (input.Contains('+'))
            {

                string[] parts = input.Split('+');
                int num1 = int.Parse(parts[0]);
                int num2 = int.Parse(parts[1]);


                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            else if (input.Contains('-'))
            {

                string[] parts = input.Split('-');
                int num1 = int.Parse(parts[0]);
                int num2 = int.Parse(parts[1]);


                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else
            {
                Console.WriteLine("Ogiltigt format. Vänligen skriv en giltig addition eller subtraktion, t.ex. 4+7 eller 20-9.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ett fel inträffade: " + ex.Message);
            Console.WriteLine("Kontrollera att du skrivit en giltig uträkning.");

        }
    }
}

