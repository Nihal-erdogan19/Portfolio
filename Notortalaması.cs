C#
  
  using system;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Öğrenci Not Ortalaması Hesaplama ===");

        Console.Write("Vize notu: ");
        double vize = Convert.ToDouble(Console.ReadLine());

        Console.Write("Final notu: ");
        double final = Convert.ToDouble(Console.ReadLine());

        double ortalama = (vize * 0.4) + (final * 0.6);

        Console.WriteLine("Ortalama: " + ortalama);

        if (ortalama >= 50)
            Console.WriteLine("Durum: Geçti");
        else
            Console.WriteLine("Durum: Kaldı");
    }
}
