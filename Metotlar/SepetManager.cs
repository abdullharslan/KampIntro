namespace Metotlar;
// Manager, service, Dal, Date Access, controller gibi ifadeler görürsek, operasyon tutuyor demektir.
public class SepetManager
{
    // naming convention
    // syntax
    public void Ekle(Urun urun)
    {
        Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
    }
    
    // İçinde eklediğim parametrelerin hepsini istiyor. Bu hatalı bir kullanım.
    public void Ekle2(string urunAdi, string aciklama, decimal fiyat, int stokAdedi)
    {
        Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
    }
}