namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        /*
         * isimler[4] = "ilker" yazıp sonradan array ekleyemiyoruz. Arrayleri oluştururken oluşturduğumuz sınırlarda kalır.
         * O sınırların dışına çıkaramayız. Çözüm olarak isimler[4]=new string[5]; diyim daha sonra atamayı yaparak ekleyebileceğimizi
         * düşünsekte, tekrardan 0, 1, 2, 3 gibi indexleri yazdırmak istediğmizde ekrana boş çıktı verecektir. new dediğimiz anda yeniden
         * bir array oluşturur.
         * Mantıksal olarak anlatmak gerekirse; stackte oluşturduğumuz ilk isimler'in adresi 101 olsun. Değerlerinin heap'te ki adreside 101 olsun.
         * Daha sonradan bir şey eklemek için tekrardan newlersek 101'deki isimler'in heapteki yeni adresi 102 olur ve sadece atama yaptığımız değerleri
         * dolu olur. Geri kalanı ise boş olur. 101 heap'ten silinir.
         */
        // string[] isimler = new string[] {"Abdullah", "Ali", "Veli", "Ahmet"};
        // Console.WriteLine(isimler[0]);
        // Console.WriteLine(isimler[1]);
        // Console.WriteLine(isimler[2]);
        // Console.WriteLine(isimler[3]);
        
        // <..> buna generic yapı deniyor.
        List<string> isimler2 = new List<string>() {"Abdullah", "Ali", "Veli", "Ahmet"};
        isimler2.Add("ayşe");
        Console.WriteLine(isimler2[4]);
    }
}