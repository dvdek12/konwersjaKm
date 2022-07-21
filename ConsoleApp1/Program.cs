using ConsoleApp1;

Console.WriteLine("Podaj dystans w km: ");

Kilometers distance = new Kilometers(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"{distance.value} km => {distance.ConvertToMeters()} m");

distance.SaveValueToFile(@"C:\Users\buzz\source\repos\ConsoleApp1\ConsoleApp1\file.txt", distance.ConvertToMeters());



