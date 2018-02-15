// Mert Yıldırır 14253072
// Yigit Recep Kader 15253027

using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            int sayi1 = 0;
            int sayi2 = 0;
            Operations op = new Operations();

            while (flag == true)
            {
                Console.WriteLine("Islemler : Toplama(+) - Cikarma(-) - Carpma(*) - Bolme(/) - Kare Alma(q)");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Islemi seciniz ");
                string deger = Console.ReadLine();
                Console.WriteLine("1. sayiyi giriniz");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                if (deger == "q")
                {
                    Console.WriteLine("Sonuc: " + op.KareAl(sayi1));
                    Console.WriteLine("Devam etmek (e) ye basınız");
                    string deger2 = Console.ReadLine();

                    if (deger2 == "e")
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }

                else
                {
                    Console.WriteLine("2. sayiyi giriniz");
                    sayi2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();



                    if (deger == "+")
                    {
                        Console.WriteLine("Sonuc: " + op.Topla(sayi1, sayi2));
                    }


                    else if (deger == "-")
                    {
                        Console.WriteLine("Sonuc: " + op.Cikar(sayi1, sayi2));
                    }

                    else if (deger == "*")
                    {
                        Console.WriteLine("Sonuc :" + op.Carp(sayi1, sayi2));
                    }


                    else if (deger == "/")
                    {
                        Console.WriteLine("Sonuc:" + op.Bol(sayi1, sayi2));
                    }
                    else
                    {
                        Console.WriteLine("Tanımsız işlem");
                    }
                    Console.WriteLine("Devam etmek (e) ye basınız");
                    string deger2 = Console.ReadLine();

                    if (deger2 == "e")
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }


            }

        }
    }
}
