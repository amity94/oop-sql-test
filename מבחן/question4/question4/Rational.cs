using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    class Rational
    {
      
        public int P { get; set; }
        public int Q { get; set; }
        private bool check;

        public Rational(int p, int q)
        {
            this.P = p;
            this.Q = q;

            if (q <= 0 || p <= 0)
            {
                check = false;
            }
            else
                check = true;

        }

        public bool greaterThan (Rational number)
        {
            if (P / Q > number.P / number.Q)
                return true;
            else
                return false;    
        }

        public bool equals(Rational number)
        {
            if (P / Q == number.P / number.Q)
                return true;
            else
                return false;
        }

        public static Rational operator +(Rational a, Rational b)
        {
            Rational c = new Rational((a.P*b.Q) + (a.Q*b.P), a.Q*b.Q);
            return c;
        }

        public static Rational operator -(Rational a, Rational b)
        {
            Rational c = new Rational((a.P * b.Q) - (a.Q * b.P), a.Q * b.Q);
            return c;
        }

        public static Rational operator *(Rational a, Rational b)
        {
            Rational c = new Rational(a.P * b.P, a.Q * b.Q);
            return c;
        }

        public int getNumerator()
        {
            return this.P;
        }

        public int getDenominator()
        {
            return this.Q;
        }

        public override string ToString()
        {
            return $"your numbers are {P}/{Q}";
        }



    }
}
