using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_2
{
    public class Pair
    {

        /// <summary>
        /// Поля данных
        /// </summary>
        private int _firstNumber;
        private int _secondNumber;

        /// <summary>
        /// Присваивание значения полям
        /// </summary>
        /// <param name="oneNumber"></param>
        /// <param name="twoNumber"></param>
        
        public Pair(int oneNumber, int twoNumber)
        {
            _firstNumber = oneNumber;
            _secondNumber = twoNumber;
        }

        /// <summary>
        /// Свойства первого числа
        /// </summary>
        
        public int First
        {
            get => _firstNumber;
            set => _firstNumber = value;
        }
        
        /// <summary>
        /// Свойства второго числа
        /// </summary>

        public int Second
        {
            get => _secondNumber;
            set => _secondNumber = value;
        }

        /// <summary>
        /// Сложение полей
        /// </summary>
        /// <returns></returns>

        public int Sum()
        {
            return _firstNumber + _secondNumber;
        }

        /// <summary>
        /// Сложение пар чисел
        /// </summary>
        /// <param name="firstPair"></param>
        /// <param name="secondPair"></param>
        /// <returns></returns>

        public static Pair SumPair(Pair firstPair, Pair secondPair)
        {
            return new Pair(firstPair.First + secondPair.First, firstPair.Second + secondPair.Second);
        }
    }
}
