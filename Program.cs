// Tanımlama
var list = new SortedSet<string>();
// ekleme
if (list.Add("Mehmet"))
{
    System.Console.WriteLine("Mehmet eklendi");
}
else
{
    System.Console.WriteLine("Ekleme başarısız.");
}
System.Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız." );
// Ahmet'i tekrar eklemeye çalışıyoruz
System.Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız." );

list.Add("Şule");
list.Add("Neslihan");
list.Add("Fahrettin");
list.Add("Fatih");

// silme
list.Remove("Şule");
//Liste içinde "F" ile başlayanları silme
list.RemoveWhere(deger => deger.StartsWith("F"));

System.Console.WriteLine("\n İsimler Listesi\n");
foreach (string item in list)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Eleman Sayısı: {0,3}", list.Count);