using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Celular da Nokia");
Smartphone nokia = new Nokia(numero: "(99) 99999-9999", modelo: "Nokia 3310", imei: "1111111111", memoria: 1);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da Cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone(numero: "(77) 77777-7777", modelo: "iPhone", imei: "5555555555", memoria: 4);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");