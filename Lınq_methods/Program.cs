// See https://aka.ms/new-console-template for more information
namespace Lınq_methods
{
    class Program
    {
        static void Main()
        {

            List<int> numbers = new List<int> { 1, 20, 33, 674, 58, 7, 89, 9, 10 };

            // LINQ sorgusu kullanarak çift sayıları seçme(2'ye bölümünden kalan 0 olanları seçiyorum)
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Çift Sayılar:");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // LINQ sorgusu kullanarak sayıları küçükten büyüğe sıralama
            var sortedNumbers = numbers.OrderBy(n => n);

            Console.WriteLine("Sıralı Sayılar:");
            foreach (var number in sortedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // LINQ sorgusu kullanarak sayıların toplamını bulma
            var sum = numbers.Sum();

            Console.WriteLine("Toplam: " + sum);

            // LINQ sorgusu kullanarak belirli bir koşulu sağlayan ilk elemanı bulma
            var firstGreaterThanFive = numbers.FirstOrDefault(n => n > 5);

            Console.WriteLine("İlk 5'ten Büyük Sayı: " + firstGreaterThanFive);

            // LINQ sorgusu kullanarak sayıların ortalamasını bulma
            var average = numbers.Average();

            Console.WriteLine("Ortalama: " + average);


            //####################################################################################//



            string[] fruits = { "Elma", "Çilek", "Kiraz", "Şeftali", "Erik", "Karpuz" };

            // LINQ sorgusu kullanarak meyve isimlerini uzunluğuna göre sıralama
            var sortedFruitsByLength = fruits.OrderBy(fruit => fruit.Length);

            Console.WriteLine("Meyveler (Uzunluğa Göre Sıralı):");
            foreach (var fruit in sortedFruitsByLength)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // LINQ sorgusu kullanarak belirli bir koşulu sağlayan meyveleri seçme
            var fruitsStartingWithE = fruits.Where(fruit => fruit.StartsWith("E", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("E Harfi ile Başlayan Meyveler:");
            foreach (var fruit in fruitsStartingWithE)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // LINQ sorgusu kullanarak meyve isimlerini büyük harfe çevirme
            var uppercasedFruits = fruits.Select(fruit => fruit.ToUpper());

            Console.WriteLine("Büyük Harfle Yazılmış Meyve İsimleri:");
            foreach (var fruit in uppercasedFruits)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // LINQ sorgusu kullanarak meyve isimlerinden bir dizi oluşturma
            var fruitArray = fruits.ToArray();

            Console.WriteLine("Meyvelerin Oluşturduğu Dizi:");
            foreach (var fruit in fruitArray)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }


    }

}
