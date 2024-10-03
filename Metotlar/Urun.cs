namespace Metotlar;

// public erişim birdirgeci olarak bilinir.
public class Urun
{
    // Property - Özellik
    public int Id { get; set; }
    public string Adi { get; set; }
    public double Fiyati { get; set; }
    public string Aciklama { get; set; }
    public int stokAdedi { get; set; }
}