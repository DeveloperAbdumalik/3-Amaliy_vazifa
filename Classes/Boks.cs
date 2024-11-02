using System.Collections.Generic;
using System.Linq;

public class Bokschi
{
    public Guid Id { get; set; }
    public string Familiya { get; set; }
    public string Ism { get; set; }
    public int Yosh { get; set; }
    public decimal Vazn { get; set; }

    public Bokschi(string familiya, string ism, int yosh, decimal vazn)
    {
        Id = Guid.NewGuid();
        Familiya = familiya;
        Ism = ism;
        Yosh = yosh;
        Vazn = vazn;
    }

    // Bokschilar ro'yxati
    public static List<Bokschi> GetBokschilarList()
    {
        return new List<Bokschi>
        {
            new Bokschi("Aliyev", "Ali", 22, 48),
            new Bokschi("Karimov", "Bekzod", 24, 55),
            new Bokschi("Sodiqov", "Jasur", 28, 75),
            new Bokschi("Mahmudov", "Davron", 30, 92),
            new Bokschi("Ismatov", "Javohir", 19, 49),
            new Bokschi("Rahmonov", "Olim", 26, 78),
            new Bokschi("To'laganov", "Zafar", 27, 53),
            new Bokschi("Azizov", "G'iyos", 25, 95),
            new Bokschi("Soliev", "Miraziz", 21, 66),
            new Bokschi("Rustamov", "Farrux", 23, 91)
        };
    }

    public static IEnumerable<Bokschi> YengilVaznBokschilar(List<Bokschi> bokschilar)
    {
        return bokschilar.Where(b => b.Vazn < 50);
    }

    public static IEnumerable<Bokschi> OrtaVaznBokschilar(List<Bokschi> bokschilar)
    {
        return bokschilar.Where(b => b.Vazn >= 50 && b.Vazn < 76);
    }

    public static IEnumerable<Bokschi> OgirVaznBokschilar(List<Bokschi> bokschilar)
    {
        return bokschilar.Where(b => b.Vazn >= 90);
    }
}