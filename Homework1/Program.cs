using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        class Money
        {
            private int Grivn;
            private int Cop;

            public Money()
            {
                Console.Write("MConstructor");
                Grivn = Cop = 0;
            }
            public Money(int grivn,int cop)
            {
                Grivn = grivn;
                Cop = cop;
            }
            public double Norm()
            {
                return Math.Sqrt(Grivn * Grivn + Cop * Cop);
            }
            public void Print()
            {
                Console.Write($"{Grivn} гривен {Cop} Копеек");
            }
            public static Money operator +(Money a, Money b)
            {
                int res_grivn = a.Grivn + b.Grivn;
                int res_cop = a.Cop + b.Cop;
                return new Money(res_cop, res_grivn);
            }
            public static Money operator -(Money a, Money b)
            {
                int res_grivn = a.Grivn - b.Grivn;
                int res_cop = a.Cop - b.Cop;
                return new Money(res_cop, res_grivn);
            }
            public static Money operator *(Money a, int b)
            {
                int res_grivn = a.Grivn * b;
                int res_cop = a.Cop * b;
                return new Money(res_cop, res_grivn);
            }
            public static Money operator /(Money a, int b)
            {
                int res_grivn = a.Grivn / b;
                int res_cop = a.Cop / b;
                return new Money(res_cop, res_grivn);
            }
            public static Money operator ++(Money a)
            {
                int res = a.Cop + 1;
                return new Money(a.Grivn, res);
            }
            public static Money operator --(Money a)
            {
                int res = a.Cop - 1;
                return new Money(a.Grivn, res);
            }
            public static bool operator <(Money a, Money b)
            {
                return a.Norm() < b.Norm();
            }
            public static bool operator >(Money a, Money b)
            {
                return a.Norm() > b.Norm();
            }
            public static bool operator ==(Money a, Money b)
            {
                return a.Equals(b);
            }
            public static bool operator !=(Money a, Money b)
            {
                return !a.Equals(b);
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
