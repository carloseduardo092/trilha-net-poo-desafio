using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia(numero: "12344321", modelo: "Nokia 1100", imei: "123321", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Iphone iphone = new Iphone(numero: "454545", modelo: "Iphone 500", imei: "909098", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();