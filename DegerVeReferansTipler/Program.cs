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
         * Sayısal veri tipleri (int, decimal, float, double, bool) değer tiplerdir. Değeri kopyalar sonrasında işi biter.
         * Ama array, class, interface bunlar ise referans tiplerdir.
         * Bellekte stack ve heap diye 2 bölüm var. Sayi1 = 10 dediğimizde işlem stackte gerçekleşiyor. sayi1=sayi2 dediğimizde sayi 2'nin değerini sayi 1'e
         * aktarır ve tüm irtibatı koparır. Sonradan sayi2 de yaptığımız değişiklikler sadece sayi2'yi bağlar. Değer tipler sadece stackte işlem görür.
         *
         * Sayilar1 dediğimizde stackte sayilar1 oluşturur. Onu new'lediğimizde heap'te yer açıp {10, 20, 30} atar. stackte sayilar1'den heap'te {10, 20, 30}
         * gösterir. sayilar1 = sayilar2 sayılar1'in referans numarası sayılar 2'nin referans numarasına eşittir. Diye okuyoruz. Bu yüzden sayılar2'de yaptığımız
         * bir değişiklik sayılar 1'de de etkisini gösterir. Çünkü sayilar1, sayilar2'nin heap'te ki değerlerini referans alır. Bu atamadan sonra sayilar1'in
         * başta ki değerini tutan herhangi bir değişken olmadığı için garbage collector veriyi heap'ten siler.
         */
        int[] sayilar1 = new int[] {10, 20, 30};
        int[] sayilar2 = new int[] {100, 200, 300};
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        Console.WriteLine(sayilar1[0]);
    }
}