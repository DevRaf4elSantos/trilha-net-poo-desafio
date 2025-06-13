using DesafioPOO.Models;

Nokia nokia = new Nokia("1234566789", "Nokia-1100", "111111111111111", 17);
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("VxCase");

    Iphone iphone = new Iphone("1234566789", "Iphone-11 Pro", "111111111111111", 99);
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Instagram");
    