using DesafioPOO.Models;

// [x]: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("2345678", "Nokia 1100", "7777777", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n");

Console.WriteLine($"AiPonei");
Smartphone aiPonei = new Iphone("753951232", "Ponei 13", "222222222", 32);
aiPonei.ReceberLigacao();
aiPonei.InstalarAplicativo("Jailbreaker");
