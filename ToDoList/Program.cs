Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?!");
Console.WriteLine("[S]ee all TODOs!");
Console.WriteLine("[A]dd a TODO!");
Console.WriteLine("[R]emove a TODO!");
Console.WriteLine("[E]xit!");


Console.WriteLine("Provide a number:");

int userChoice = int.Parse(Console.ReadLine());

Console.WriteLine(userChoice.GetTypeCode());
Console.ReadKey();