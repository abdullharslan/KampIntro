namespace OOP3;

public class BasvuruManager
{
    /*
     * Parametre alarak başvuruyu hangi krediye göre yapmam gerektiğini bana söyle demek için ICreditManager kullanırız.
     */ 
    public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)
    {
        // Başvuran bilgileri
        
        /*
         * MortgageLoad mortageLoad = new MortgageLoad();mortageLoad.Calculate();
         * Bu şekilde kullanılması durumunda hepsini konut kredisi olarak kullanır.
         * Parametre olarak interface'i vererecek artık istediğimiz kredi işlemini burada yapabiliriz.
         */
        creditManager.Calculate();
        // Method Injection
        loggerService.Log();
    }
    
    // Belirsiz bir sayıda bir veri grubu oluşturmak için List kullanıyoruz.
    public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
    {
        foreach (var credit in credits)
        {
            credit.Calculate();
        }
    }
}