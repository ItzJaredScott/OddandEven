

Console.WriteLine("Give me a number!");
    int x = Convert.ToInt32(Console.ReadLine()); //converts the number given to an int

if (x % 2 == 0) //finds if there is a remainder using 2
{
    Console.WriteLine($"{x} is even."); 
}
else
{
    Console.WriteLine($"{x} is odd.");
}

Console.ReadLine();