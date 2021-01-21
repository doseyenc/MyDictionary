using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ilPlakalari = new MyDictionary<int, string>();
            ilPlakalari.add(34, "İstanbul");
            ilPlakalari.add(06, "Ankara");
            ilPlakalari.add(35, "İzmir");
            ilPlakalari.add(07, "Antalya");
            ilPlakalari.add(50, "Nevşehir");
            ilPlakalari.print();
            Console.WriteLine("***********GÜNCELLENMİŞ HALi*************");
            ilPlakalari.add(50, "Yeni Şehir");//Aynı keye sahip olan değerin valuesi güncellendi.
            ilPlakalari.print();

        }
    }
}
