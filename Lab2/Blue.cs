using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double cur_x = 1;
            int i = 1;
            while (n > 0)
            {
                answer += (Math.Sin(i * x)/cur_x);
                cur_x *= x;
                n--;
                i++;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double cur_n = -5, fac_n = 1;
            double value;
            for (int i = 2; i <= n+1; i++)
            {
                value = (double)cur_n / fac_n;
                cur_n *= -5;
                fac_n *= i;
                answer += value;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fib_ra = 0, fib_gor = 1;
            while (n > 1)
            {
                answer += fib_gor;
                fib_gor = fib_gor + fib_ra;
                fib_ra = fib_gor - fib_ra;
                n--;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            long s = 0; 
            int c = 0;
            do
            {
                s += (a + (h * c));
                c++;
            } while (s <= L);
            answer = c - 1;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (S < L)
            {
                answer += h;
                S *= 2;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            int f = 0, fc = 0, ii = 7;
            for (int i = 0; i < 7; i++)
            {
                if ((S > 42) && (fc == 0))
                {
                    c = i;
                    fc = 1;
                }
                a += S;
                S = (S / 100 * (100 + I));
                if ((a > 100) && (f == 0))
                {
                    b = i;
                    f = 1;
                }
            }
            double img_a = a;
            while (img_a < 100)
            {
                ii++;
                if ((S > 42) && (fc == 0))
                {
                    c = ii;
                    fc = 1;
                }
                img_a += S;
                S = (S / 100 * (100 + I));
            }
            while (S < 42)
            {

            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}