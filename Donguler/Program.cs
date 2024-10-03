namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays - Diziler
            string[] kurslar = new string[]{"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java"};
            
            // kurslar.Length yaparak uzunluğu dinamik hale getirdim. Bir şey eklenmesi silinmesi durumunda ona göre sınırlar değişiyor.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("Sayfa Sonu - footer");
            
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**************************\n");
            
            // Burada kurs ismi takma isim (alyans) oluyor. İstediğimiz ismi verebiliriz. For döngüsünün alternatifidir.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}