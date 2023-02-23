// Author: Dawson White

using System.ComponentModel;

Console.WriteLine("Give me a random number 1 throguh 10");
string ans = Console.ReadLine();
int dans;
while (int.TryParse(ans, out dans) == false)
{
    Console.WriteLine("Whoops! You didnt give me a valid answer.. try again...");
    ans = Console.ReadLine();
}

Random rand  = new Random();
int rando = rand.Next(1, 101);

int sum = rando + dans;
Console.WriteLine($"{sum} {rando}");

Console.WriteLine("Okay we are going to add your number to a random number, and you have to give us the random number.");
Console.WriteLine($"The sum of the two numbers is {sum}... What is the hidden number?>>");
int st = Convert.ToInt32(Console.ReadLine());

while (st != rando)
{
    Console.WriteLine("Yikes.... I thought this was going to be pretty easy...  Try again I guess...");
    st = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Congrats! I knew you could do it!");