namespace GenericIntro;

/*
 * "T" burada bir "generic" tiptir. Yani, bu sınıf veya method herhangi bir veri tipinde
 * çalışabilir. "MyList<T>" sınıfı T (bir placeholder (yer tutucu)) tipinde elemanları tutan bir liste oluşturur,
 * ve "Add" methodu da listeye T tipinde bir eleman ekler. T, bu sınıfın nasıl kullanılacağına
 * bağlı olarak bir int, string, double, ya da herhangi başka bir veri tipi olabilir.
 * Örneğin:
 * MyList<int> intListesi = new MyList<int>(); // int türünde bir liste
 * MyList<string> stringListesi = new MyList<string>(); // string türünde bir liste
 */
public class MyList<T>
{
    T[] items;
    
    // CONSTRUCTOR (ctor ile oluşturdum.) ben class'ı bir yerde newlersem bu otomatik çalışıyor.
    public MyList()
    {
        // new'lediğimizde oluşturuyor ve 0 elemanlı veriyor.
        items = new T[0];
    }
    public void Add(T[] item)
    {
        T[] tempArray = items;
        item = new T[items.Length + 1];
        for (int i = 0; i < tempArray.Length; i++)
        {
            item[i] = tempArray[i];
        }
        items[items.Length - 1] = item;
    }
}