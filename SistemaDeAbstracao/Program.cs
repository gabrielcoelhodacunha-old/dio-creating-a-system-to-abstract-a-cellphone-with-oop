using System;
using SistemaDeAbstracao.Models;

Console.WriteLine("Smartphone iPhone:");
Iphone iPhone = new Iphone(numero: "1", modelo: "X", imei: "1", memoria: 8);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Genshin Impact");

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "2", modelo: "Y", imei: "2", memoria: 12);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tower Of Fantasy");