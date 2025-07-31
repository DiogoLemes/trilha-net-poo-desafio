using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("----------------------");

Smartphone nokia1 = new Nokia("11912345678", "Nokia3310", "123456789012345", 64);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Whatsapp");

Console.WriteLine("----------------------");

Smartphone iphone1 = new Iphone("11912345678", "Iphone 15", "123456789012345", 64);
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Google Chrome");

Console.WriteLine("----------------------");