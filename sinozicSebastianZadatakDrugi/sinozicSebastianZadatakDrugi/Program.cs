using System;

namespace sinozicSebastianZadatakDrugi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sek;
            int min;
            int s;


            Console.WriteLine("Upisi sekunde");
            sek = Convert.ToInt32(Console.ReadLine());
            min = sek / 60;
            s = sek % 60;
            Console.WriteLine("{0} minuta i {1} sekundi", min, s);
            Console.ReadKey();


        }
    }
}