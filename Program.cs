using DesafioPOO.Models;

System.Console.WriteLine("\nSmartphone Nokia: Lumia 1020");
Nokia nokia = new Nokia("123456789", "Lumia 1020", "IMEI123456789", 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("\nSmartphone iPhone: iPhone 13");
Iphone iphone = new Iphone("987654321", "iPhone 13", "IMEI987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");