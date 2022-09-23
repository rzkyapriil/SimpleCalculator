using System;

namespace Program
{
    class Calculator
    {
        public static void Main()
        {
            int a, b;
            int pilih;
            Console.Clear();
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine("|           CALCULATOR           |");
            Console.WriteLine("+--------------------------------+");
            Console.WriteLine("| 1. Pertambahan                 |");
            Console.WriteLine("| 2. Pengurangan                 |");
            Console.WriteLine("| 3. Perkalian                   |");
            Console.WriteLine("| 4. Pembagian                   |");
            Console.WriteLine("| 5. Keluar                      |");
            Console.WriteLine("+--------------------------------+");
            do
            {
                Console.Write("  Operasi [1/2/3/4/5]: ");
                pilih = Convert.ToInt32(Console.ReadLine());
                switch(pilih)
                {
                    case 1:
                        Console.WriteLine("+--------------------------------+");
                        Console.WriteLine("  Pertambahan: A + B");
                        Console.Write("  A: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("  B: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("  Hasil: " + (a+b));
                        Console.WriteLine("+--------------------------------+");
                        break;
                    case 2:
                        Console.WriteLine("+--------------------------------+");
                        Console.WriteLine("  Pengurangan: A - B");
                        Console.Write("  A: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("  B: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("  Hasil: " + (a-b));
                        Console.WriteLine("+--------------------------------+");
                        break;
                    case 3:
                        Console.WriteLine("+--------------------------------+");
                        Console.WriteLine("  Perkalian: A x B");
                        Console.Write("  A: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("  B: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("  Hasil: " + (a*b));
                        Console.WriteLine("+--------------------------------+");
                        break;
                    case 4:
                        Console.WriteLine("+--------------------------------+");
                        Console.WriteLine("  Pembagian: A / B");
                        Console.Write("  A: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("  B: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("  Hasil: " + ((float)a/(float)b));
                        Console.WriteLine("+--------------------------------+");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("  Pesan: Keluar Program");
                        System.Threading.Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("+--------------------------------+");
                        Console.WriteLine("  Pesan: Masukan Angka 1-5!");
                        Console.WriteLine("+--------------------------------+");
                        break;
                }
                
            } while(pilih != 5);
        }
    }
}