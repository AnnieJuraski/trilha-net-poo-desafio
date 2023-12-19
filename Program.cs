using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone testNokia = new Nokia("11980001234", "Nokia X", "A12B345", 128);
Smartphone testIPhone = new Iphone("11980102030", "Iphone ZFlip", "Z01Z000", 64);

//O output deve ser "Ligando..."
testNokia.Ligar();
testIPhone.Ligar();

Console.WriteLine("\n");

//O output deve ser "Recebendo ligação..."
testNokia.ReceberLigacao();
testIPhone.ReceberLigacao();

Console.WriteLine("\n");

//Teste de aplicação de instalar um app

testNokia.InstalarAplicativo("Telegram");
testIPhone.InstalarAplicativo("Telegram");



