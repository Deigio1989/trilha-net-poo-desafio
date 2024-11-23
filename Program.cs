using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("11 123123123","modelo 1","123456781",512);
nokia.Ligar();
nokia.InstalarAplicativo("Duolingo");

Console.WriteLine('\n');

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("12 112233445","modelo 1","098765431",512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("AppTeste");
