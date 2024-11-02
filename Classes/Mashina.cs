using System.Collections;

namespace AMALIY.Classes
{
    public class Mashina
    {
        public int Narx1 { get; set; }
        public int Narx2 { get; set; }
        
        public Mashina(int narx1, int narx2)
        {
            Narx1 = narx1;
            Narx2 = narx2;
        }
        public void MashinaMalumoti()
        {
            string[] model = new string[3];
            model[0]="Gentra";
            model[1]="Ferrare 269f";
            model[2]="Mersdes SLS";

            string[] marka = new string[3];
            marka[0]="Chevrolet";
            marka[1]="Ferrare";
            marka[2]="Mersdes";

            int[] narxi = new int[3];
            narxi[0]=150000;
            narxi[1]=200000;
            narxi[2]=170000;

            for(int i=0; i<3; i++)
            {
                if(narxi[i]>Narx1)
                {
                    if(narxi[i]<Narx2) Console.WriteLine($"Mashina modeli {model[i]} markasi {marka[i]} narxi {narxi[i]}");
                }
                if(narxi[i]>Narx2)
                {
                    if(narxi[i]<Narx1) Console.WriteLine($"Mashina modeli {model[i]} markasi {marka[i]} narxi {narxi[i]}");
                }
            }
        }

    }
}