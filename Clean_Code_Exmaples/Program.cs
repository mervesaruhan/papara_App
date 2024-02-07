// See https://aka.ms/new-console-template for more information

//1. örnek
//İYİ KOD:


using System;

class Program
{
    static void ana()
    {
        int s = 0;
        Console.Write("Bir sayı girin: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bir sayı daha girin: ");
        int b = Convert.ToInt32(Console.ReadLine());
        s = a + b;
        Console.WriteLine("Toplam: " + s);
    }
}

//isimlendirme anlaşılır değil. Fonskiyon neye hizmet ediyor belirsiz. Prompt mesajları ve çıktılar 
// açıklama eksikliği taşıyor. Mantıksal bir sistemi yok.

//İYİ KOD:


class HesapMakinesi
{
    static void Maine()
    {
        Console.WriteLine("Toplama İşlemi");
        int sayi1 = KullanicidanSayiAl("Birinci sayıyı girin: ");
        int sayi2 = KullanicidanSayiAl("İkinci sayıyı girin: ");

        int toplam = Topla(sayi1, sayi2);

        SonucuGoster(toplam);
    }

    static int KullanicidanSayiAl(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToInt32(Console.ReadLine());
    }

    static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    static void SonucuGoster(int sonuc)
    {
        Console.WriteLine("Toplam: " + sonuc);
    }
}

//Doğru isimlendirme ile kodun ne yapmak istediği daha anlaşılır hale geldi. Kod uygulamayı temsil 
//eden bir sınıfa tasındı. İşlemler ayrı meodlara bölündü. Böylece her bir metoda tek görev veirldir. (SRP)

//KÖTÜ ÖRNEK

class HesapMakinesi2
{
    void ToplamaIslemiYap(int a, int b)
    {
        Console.WriteLine("Toplam: " + (a + b));
    }

    void CikarmaIslemiYap(int a, int b)
    {
        Console.WriteLine("Fark: " + (a - b));
    }

    void CarpmaIslemiYap(int a, int b)
    {
        Console.WriteLine("Çarpım: " + (a * b));
    }
}

//İYİ ÖRNEK

class HesapMakinesi3
{
    void IslemSonucunuGoster(string islemAdi, int sonuc)
    {
        Console.WriteLine($"{islemAdi}: {sonuc}");
    }

    void ToplamaIslemiYap(int a, int b)
    {
        IslemSonucunuGoster("Toplam", a + b);
    }

    void CikarmaIslemiYap(int a, int b)
    {
        IslemSonucunuGoster("Fark", a - b);
    }

    void CarpmaIslemiYap(int a, int b)
    {
        IslemSonucunuGoster("Çarpım", a * b);
    }
}

//Burada koddaki tekrarlar azaltılarak daha anlaşılır ve sürdürebilir hale getirilmeye çalışılmıştır.


//KÖtü KOD (ISP):

class KtISP
{
    interface IWorker
    {
        void Work();
        void Eat();
        void Sleep();
    }

    class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }

    static void Main2()
    {
        IWorker worker = new Worker();
        worker.Work();
        worker.Eat();
        worker.Sleep();
    }
}


//İYİ KOD (ISP):

class IyISP2
{
    interface IWorkable
    {
        void Work();
    }

    interface IEatable
    {
        void Eat();
    }

    interface ISleepable
    {
        void Sleep();
    }

    class Worker : IWorkable, IEatable, ISleepable
    {
        public void Work()
        {
            Console.WriteLine("Working");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }

    static void Main()
    {
        IWorkable worker = new Worker();
        worker.Work();

        IEatable eater = new Worker();
        eater.Eat();

        ISleepable sleeper = new Worker();
        sleeper.Sleep();
    }
}


//KÖTÜ ÖRNEK:


public class ShoppingCart
{
    private List<Item> items;
    private double totalAmount;

    public ShoppingCart()
    {
        items = new List<Item>();
        totalAmount = 0.0;
    }

    public void AddItem(string itemName, double itemPrice, int quantity)
    {
        Item newItem = new Item(itemName, itemPrice, quantity);
        items.Add(newItem);
        totalAmount += newItem.TotalPrice();
    }

    public void RemoveItem(string itemName)
    {
        Item? itemToRemove = items.FirstOrDefault(item => item.Name == itemName);

        if (itemToRemove != null)
        {
            totalAmount -= itemToRemove.TotalPrice();
            items.Remove(itemToRemove);
        }
    }

    public double CalculateDiscountedTotal(double discountPercentage)
    {
        double discountFactor = 1 - discountPercentage / 100;
        return totalAmount * discountFactor;
    }
} 

public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Item(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public double TotalPrice()
    {
        return Price * Quantity;
    }
}



//İYİ ÖRNEK:

public class ShoppingCart2
{
    private List<Item2> items;

    public ShoppingCart2()
    {
        items = new List<Item2>();
    }

    public void AddItem(string name, double price, int quantity)
    {
        Item2 newItem = new Item2(name, price, quantity);
        items.Add(newItem);
    }

    public void RemoveItem(string name)
    {
        Item2? itemToRemove = items.FirstOrDefault(item => item.Name == name);

        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
        }
    }

    public double CalculateTotal()
    {
        return items.Sum(item => item.TotalPrice());
    }

    public double CalculateDiscountedTotal(double discountPercentage)
    {
        double totalAmount = CalculateTotal();
        double discountFactor = 1 - discountPercentage / 100;
        return totalAmount * discountFactor;
    }
}

public class Item2
{
    public string Name { get; }
    public double Price { get; }
    public int Quantity { get; }

    public Item2(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public double TotalPrice()
    {
        return Price * Quantity;
    }
}


//Burada kod tekrarları azaltılmaya çalışılmış, SRP'ye dikkat edilmiş, fonksiyon 
//ve parametre  isimlendirmesi anlaşılır hale getirilmiştir. Kod daha okunaklı hale 
//getirilmeye çalışılmıştır.


//KÖTÜ ÖRNEK:

public class ProcessData
{
    public string Process(int value)
    {
        if (value > 0)
        {
            if (value % 2 == 0)
            {
                return "Positive Even";
            }
            else
            {
                return "Positive Odd";
            }
        }
        else
        {
            if (value % 2 == 0)
            {
                return "Negative Even";
            }
            else
            {
                return "Negative Odd";
            }
        }
    }
}


//İYİ ÖRNEK:

public class ProcessData2
{
    public string Process(int value)
    {
        if (value > 0 && IsEven(value))
        {
            return "Positive Even";
        }

        if (value > 0 && !IsEven(value))
        {
            return "Positive Odd";
        }

        if (value <= 0 && IsEven(value))
        {
            return "Negative Even";
        }

        return "Negative Odd";
    }

    private bool IsEven(int value)
    {
        return value % 2 == 0;
    }
}







