namespace DegerVeReferansTipler;

class Program
{
    static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        Console.WriteLine(sayi1);
        
        /*
         * Sayısal veri tipleri (int, decimal, float, double, bool) değer tiplerdir.
         * Ama array, class, interface bunlar ise referans tiplerdir.
         * Bellekte stack ve heap diye 2 bölüm var. Sayi1 = 10 dediğimizde işlem stackte gerçekleşiyor. sayi1=sayi2 dediğimizde değeri aktarır ve
         * tüm irtibatı koparır. Sonradan sayi2 de 
         */
        int[] sayilar1 = new int[] {10, 20, 30};
        int[] sayilar2 = new int[] {100, 200, 300};
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        Console.WriteLine(sayilar1[0]);
    }
}