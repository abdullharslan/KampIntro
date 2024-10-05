namespace OOP2;

class Program
{
    static void Main(string[] args)
    {
         IndividualCustomer customer1 = new IndividualCustomer();
         customer1.Id = 1;
         customer1.CustomerNo = "1235";
         customer1.FirstName = "John";
         customer1.LastName = "Doe";
         customer1.TcNo = "12345678901";
         
         CoorporateCustomer customer2 = new CoorporateCustomer();
         customer2.Id = 2;
         customer2.CustomerNo = "1245";
         customer2.CoorporateName = "rider";
         customer2.TaxNo = "123456";
         
         Customer customer3 = new IndividualCustomer(); // new IndividualCustomer(); referans numarasıdır.
         Customer customer4 = new CoorporateCustomer();
         
         CustomerManager customerManager = new CustomerManager();
         customerManager.Add(customer1);
         customerManager.Add(customer2);
         customerManager.Add(customer3);
         customerManager.Add(customer4);
    }
}