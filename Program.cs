Console.WriteLine("=== Hesap Makinesi ===");
Console.WriteLine("İki sayı girin:");

Console.Write("1. Sayı: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("2. Sayı: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nİşlem seçin:");
Console.WriteLine("1. Toplama");
Console.WriteLine("2. Çıkarma");
Console.WriteLine("3. Çarpma");
Console.WriteLine("4. Bölme");

Console.Write("Seçiminiz: ");
int secim = Convert.ToInt32(Console.ReadLine());

double sonuc = 0;

if (secim == 1)
    sonuc = sayi1 + sayi2;
else if (secim == 2)
    sonuc = sayi1 - sayi2;
else if (secim == 3)
    sonuc = sayi1 * sayi2;
else if (secim == 4)
    sonuc = sayi1 / sayi2;

Console.WriteLine("Sonuç: " + sonuc);

