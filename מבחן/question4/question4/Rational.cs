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
            if (!check && !number.check)
                return false;
            else if (!check && number.check)
                return false;
            else if (check && !number.check)
                return true;
            else
            {
                if(P * number.Q > Q * number.P)
                return true;
                else
                return false;
            }
        }

        public bool equals(Rational number)
        {
            if (!check && !number.check)
                return true;
            else if (!check && number.check)
                return false;
            else if (check && number.check)
                return false;
            else
            {
                if (P / Q == number.P / number.Q)
                return true;
                else
                return false;
            }
        }

        public static Rational operator +(Rational a, Rational b)
        {
            if (!a.check && !b.check)
                return new Rational(0, 0);
            else if (!a.check && b.check)
                return b;
            else if (a.check && !b.check)
                return a;
            else
                return new Rational((a.P * b.Q) + (a.Q * b.P), a.Q * b.Q);

        }

        public static Rational operator -(Rational a, Rational b)
        {
            if (!a.check && !b.check)
                return new Rational(0, 0);
            else if (!a.check && b.check)
                return b;
            else if (a.check && !b.check)
                return a;
            else
            return new Rational((a.P * b.Q) - (a.Q * b.P), a.Q * b.Q);
        }

        public static Rational operator *(Rational a, Rational b)
        {
            if (!a.check && !b.check)
                return new Rational(0, 0);
            else if (!a.check && b.check)
                return new Rational(0, 0);
            else if (a.check && !b.check)
                return new Rational(0, 0);
            else
            return new Rational(a.P * b.P, a.Q * b.Q);
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
