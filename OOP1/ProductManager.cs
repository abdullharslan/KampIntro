namespace OOP1;

public class ProductManager
{
    // Void olarak belirttiğimiz metotları emir kipinde git yap bitir demek oluyor.
    public void Add(Product product)
    {
        // Console.WriteLine(Product.ProductName + " added");
    }
    
    public void Update(Product product)
    {
        // Console.WriteLine(Product.ProductName + " upgraded");
    }
    
    /*
     * "Topla" methodu bir değer döndürür. Bu nedenle, başka bir yerde bu methodu çağırdığımızda
     * toplama sonucunu alıp üzerinde işlemler yapabiliriz veya bir değişkene atayabiliriz.
     * Örneğin:
     * int sonuc = Topla(3, 5);
     * Console.WriteLine(sonuc * 2); // Sonucu başka bir yerde kullanma esnekliği sağlar.
     */
    public int Topla(int num1, int num2)
    {
        return num1 + num2;
    }
    
    /*
     * "Topla2" methodu ise geriye herhangi bir değer döndürmez, sadece konsola sonucu yazar.
     * Yani bu methodu çağırdığımızda sonucu doğrudan görebiliriz, fakat o sonucu başka bir
     * yerde tekrar kullanma şansımız olmaz. Geri dönüş değeri 'void' olduğu için sonucu saklayamayız.
     */
    public void Topla2(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }
}