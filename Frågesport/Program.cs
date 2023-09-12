// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

string choice = "";

Console.WriteLine("Gomorron, gomorron, gomorron!");
Console.WriteLine("Det här är Wieron i Ottan! Klockan är 03:30, upp och hoppa!");
Console.WriteLine("Vem e de jag tjötar med?");
Console.WriteLine();           //skriv ut meddelanden
choice = Console.ReadLine();

Console.WriteLine($"Tjenare {choice}, de va la trevligt.");
Console.WriteLine("Nu har jag några frågor till dig här va.");
Console.WriteLine("Fråga 1:");
Console.WriteLine("");
Console.WriteLine("Vilket djur förlorade Australienska soldater ett krig mot år 1932?");
Console.WriteLine("Var det:");
Console.WriteLine("a) Känguru");
Console.WriteLine("b) Dingo");
Console.WriteLine("c) Emu");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "a")
{
Console.WriteLine("Intressant val du. Kriget varade bara en månad.");
Console.WriteLine("Jaha då. Här kommer fråga 2:");
Console.WriteLine("");
Console.WriteLine("");
}

else if (choice == "b")
{
Console.WriteLine("Mhmm, okej. Kriget var ett riktigt kort ett.")
Console.WriteLine("Jaja, här kommer fråga 2:");



}

else if (choice == "c")
{

    
}


Console.ReadLine();