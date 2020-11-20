using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_2
{
    public class Pair
    {
        private int _firstNumber;
        private int _secondNumber;

        public Pair(int oneNumber, int twoNumber)
        {
            _firstNumber = oneNumber;
            _secondNumber = twoNumber;
        }

        public int First
        {
            get => _firstNumber;
            set => _firstNumber = value;
        }

        public int Second
        {
            get => _secondNumber;
            set => _secondNumber = value;
        }

        public int Sum()
        {
            return _firstNumber + _secondNumber;
        }

        public static Pair SumPair(Pair firstPair, Pair secondPair)
        {
            return new Pair(firstPair.First + secondPair.First, firstPair.Second + secondPair.Second);
        }

        public static int SumField(int a, int b)
        {
            int res = a + b;
            return res;
        }
        public static void SumPair(int a,int b,int c,int d,out int onepair, out int twopair)
        {
            onepair = a + c;
            twopair = b + d;
        }
        public static int SumField(int a,int b,int c)
        {
            int res = a + b + c;
            return res;
        }
        public static void SumPair(int a, int b, int c, int d,int f,int j, out int onepair, out int twopair)
        {
            onepair = a + c + f;
            twopair = b + d + j;
        }
    }
}
