// See https://aka.ms/new-console-template for more information

using AMALIY.Classes;
/**
Oquvchi uquvchi = new Oquvchi();
Console.WriteLine("Nechi baho olgan O'quvchilar ruyhati kerak: ");
int n = Convert.ToInt16(Console.ReadLine());
uquvchi.DataId(n);
*/


    Console.WriteLine("Taxminiy 2ta narx kiriteng: ");
    Console.Write("1 - narx :");
    int narx1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2 - narx :");
    int narx2 = Convert.ToInt32(Console.ReadLine());
    Mashina mashina = new Mashina(narx1,narx2);
    mashina.MashinaMalumoti();




        var bokschilar = Bokschi.GetBokschilarList();
        Console.WriteLine("Yengil vaznli bokschilar (50 kg gacha):");
        foreach (var bokschi in Bokschi.YengilVaznBokschilar(bokschilar))
        {
            Console.WriteLine($"{bokschi.Ism} {bokschi.Familiya}, Vazn: {bokschi.Vazn} kg");
        }
        Console.WriteLine("\nO'rta vaznli bokschilar (50 - 76 kg):");
        foreach (var bokschi in Bokschi.OrtaVaznBokschilar(bokschilar))
        {
            Console.WriteLine($"{bokschi.Ism} {bokschi.Familiya}, Vazn: {bokschi.Vazn} kg");
        }
        Console.WriteLine("\nOg'ir vaznli bokschilar (90 kg va undan yuqori):");
        foreach (var bokschi in Bokschi.OgirVaznBokschilar(bokschilar))
        {
            Console.WriteLine($"{bokschi.Ism} {bokschi.Familiya}, Vazn: {bokschi.Vazn} kg");
        }
