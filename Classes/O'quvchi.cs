namespace AMALIY.Classes
{
    public class Oquvchi
    {
        private Guid id;
        private string ism;
        private string familya;
        private int sinf;
        private int baho;

        public void DataId(int n)
        {
            
            Guid[] guids = new Guid[3];

            string[] familya = new string[3];
            familya[0] = "Aduqodirov";
            familya[1] = "Jamshidov";
            familya[2] = "Gulzodayeva";

            int[] sinf = new int[3];
            sinf[0] = 9;
            sinf[1] = 11;
            sinf[2] = 10;

            int[] baho = new int[3];
            baho[0] = 4;
            baho[1] = 5;
            baho[2] = 3;
       

            for(int i=0; i<3; i++)
            {
                Console.WriteLine($"Ismi {ism[i]} Famelyasi {familya[i]} sinfi {sinf[i]} bahosi {baho[i]}");
            }

            for (int i=0; i<3; i++)
            {
                if(baho[i]==n) 
                Console.WriteLine($"Ismi {ism[i]} Famelyasi {familya[i]} sinfi {sinf[i]} bahosi {baho[i]}");
            }
        }
    }
}