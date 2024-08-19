using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456", "Modelo 1", "1111111111111", 64);
        Smartphone iphone = new Iphone("654321", "Modelo 2", "2222222222222", 128);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
    }
}
