namespace OOP1;

public class Product
{
    // snippet
    // Primary Key
    public int Id { get; set; }
    public string ProductName { get; set; }
    public double UnitPrice { get; set; }
    // Foreign Key
    public int CategoryId { get; set; }
    public int UnitsInStock { get; set; }
    
    // CRUD operasyonları
}