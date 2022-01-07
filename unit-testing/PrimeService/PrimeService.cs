using System;

namespace Prime.Services
{
    public class PrimeService
    {
       public bool IsPrime(int candidate)
        {
            if (candidate % 2 ==0)
            {
                return true;
            }
            else return false;
        }
        public bool equal(int a, int b )
        {
            if(a == b)
            {
                return true;
            }
            else return  false;
        
        }
        public bool equal1(int a, int b )
        {
            if(a % 2 == 0 && b % 2 ==0)
            {
                return true;
            }
            else return  false;
        }

        public bool equal2(int a, int b,int c)
        {
            if(a +b +c <= 8)
            {
                return true;
            }
            else return false;
        }
        public bool equal3(int a)
        {
            if(a + 4 ==5)
                return true;
            else return false;
        }
    }
}
