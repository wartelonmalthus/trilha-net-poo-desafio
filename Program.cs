using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone Nokia: ");
Smartphone Nokia = new Nokia(numero: "13154", modelo: "Modelo 01", imei: "11111111", memoria: 64);

Nokia.Ligar();
Nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n"):

Console.WriteLine("Smarthphone Iphone");
Smartphone iphone = new Iphone(numero: "46854", modelo: "modelo 02", imei: "11111111", memoria: 124);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");