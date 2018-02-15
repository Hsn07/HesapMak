using System;
namespace Calculator
{
    public class Operations
    {
        public Operations()
        {

        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
        public double Bol(float sayi1, float sayi2)
        {
            return sayi1 / sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        
        public int KareAl(int sayi1)
        {
            return sayi1*sayi1;
        }

       


    }
}
