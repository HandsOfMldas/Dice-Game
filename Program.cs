// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;
// diceGame
Console.WriteLine("Press enter to roll the die");

int roll1 = 0;
int roll2 = 0;
int attempts=0;
Random nbGen = new Random();

while (roll1 != 6 || roll2 != 6)
{
    Console.ReadLine();
    roll1 = nbGen.Next(1, 7);
    roll2 = nbGen.Next(1, 7);
    Console.WriteLine($" roll1 {roll1}, roll2: {roll2}");
    attempts++;
}
Console.WriteLine($"attempts to get double sixes : {attempts}");
Console.ReadKey();
 // pardon my bad english 