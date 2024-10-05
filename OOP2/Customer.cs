namespace OOP2;
/*
 * Class'lar iki tane özelliği vardır.. Özellikler(prop) tutar, operasyon tutarlar. Özellik tutulan yerde
 * operasyon tutulmamalı, operasyon tuttuğumuz yerde özellik tutulmamalıdır.
 */
public class Customer
{
    /*
     * Sayılardan oluşan veri üstünde matematiksel işlem yapılmıyorsa ona sayı görevi verilmiyorsa, metinsel
     * olarak planlanırsa daha iyi sonuç alınır. Farklı sistemlerle veri uyumluluğunu sağlamaya çalışırken.
     */
    /*
     * Eğer bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan. O nesneye ait değilmiş gibi duruyorsa
     * o an demek ki orada soyutlama hatası yapıyorum demektir.
     * Gerçek Müşteri - Tüzel Müşteri bunlar birbirinin yerine kullanılamaz. public string SirketAdi { get; set; }
     * olmamalıdır.
     * public int Id { get; set; }
       public string MusteriNo { get; set; }
       public string Adi { get; set; }
       public string Soyadi { get; set; }
       public string SirketAdi { get; set; }
       public string TcNo { get; set; }
       public string VergiNo { get; set; }
       burada yazmamalıyız.
     */
    public int Id { get; set; }
    public string CustomerNo { get; set; }
    /*
     * Biz bunu neden yapıyoruz?
     * Polymorphism (çok biçimlilik) sayesinde Customer referansı ile IndividualCustomer ve CoorporateCustomer gibi alt sınıfların
     * nesnelerini yönetebiliriz. Bu da daha esnek ve genişletilebilir bir yapı oluşturur.
     * Kalıtım (Inheritance) ile Customer sınıfındaki ortak özellik ve davranışları tüm alt sınıflar paylaşır.
     * Bu da kod tekrarını önler ve ortak davranışları merkezi bir yerden yönetmeyi kolaylaştırır
     */
    
    // Eğer bir base sınıfım varsa, o sınıf referans tutucudur.
}