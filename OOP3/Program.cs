namespace OOP3;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Interface'lerde o interface'i implemente eden class'ın referans numarasını tutabilir.
         */
        ICreditManager personalLoan = new PersonalLoan();
        ICreditManager vehicleLoan = new VehicleLoan();
        MortgageLoad mortgage = new MortgageLoad();

        ILoggerService databaseLoggerService = new DatebaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        
        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(personalLoan, databaseLoggerService);
        // basvuruManager.BasvuruYap(vehicleLoan, new DatebaseLoggerService());
        
        List<ICreditManager> credits = new List<ICreditManager>() {personalLoan, vehicleLoan, mortgage};
        // basvuruManager.KrediOnBilgilendirmesiYap(credits);
    }
}