// Metotlar Tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
// Dont repeat yourself - DRY
// Clean Code - Best Practice

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class'ın örneği denir. 
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.Id = 1;
            
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Id = 2;
            
            Urun[] urunler = new Urun[] {urun1, urun2};
            
            // type-safe -- tip güvenliği
            // Urun class'ı yerine var'da yazabiliriz.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(" ");
            }

            Console.WriteLine("---------------Metotlar--------------");
            
            // Instance - Class öğreği oluşturmak. Bir örneğini oluşturuyoruz.
            // encapsulation budur. Bu da encapsulation, yani bir nesnenin iç detaylarının gizlenip sadece gerekli fonksiyonların dışarıya açılması demektir.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            
            /* Böylede gönderebilirdik. Neden illa class ile kullanıyoruz? Ekle2 methodunda yapacağım değişlikte aşağıdaki kod
             * tümden patlar. Her biri için değişiklik yapmam gerekir.
             */
            sepetManager.Ekle2("Armut", "yeşil armut", 12, 10);
        }
    }
}