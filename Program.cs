using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n = new Nokia(numero: "123321",modelo: "NokiaTijolo",imei: "00012",memoria: 128);
Console.WriteLine("Seu número: "+n.Numero);
n.Numero = "332211";
Console.WriteLine("Novo número: "+n.Numero);
//n.Modelo = "nokia 1"; - inacessivel
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Instagram");

Console.WriteLine("__________");

Iphone ip = new Iphone(numero: "098797",modelo: "IPhone 8",imei: "02018",memoria: 256);
Console.WriteLine("Seu número: "+ip.Numero);
ip.Numero = "990191";
Console.WriteLine("Novo número: "+ip.Numero);
ip.Ligar();
ip.ReceberLigacao();
ip.InstalarAplicativo("Spotify");