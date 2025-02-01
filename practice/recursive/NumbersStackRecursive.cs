using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice.recursive;

namespace practice.recursive
{
    class NumbersStackRecursive
    {
        BasicStackRecursive _basicStackRecursive = new BasicStackRecursive();

        ////// EJERCICIO #1 //////
        // Entrada: Un número entero largo (long)
        // Salida: La suma de todos los dígitos impares del número
        // Restricción: El número debe ser no negativo
        public long SumOddDigits(long num)
        {
            if (num < 0)
                throw new ArgumentException("El número debe ser no negativo");

            if (num == 0) return 0;
            else if ((num % 10) % 2 != 0)
                return (num % 10) + SumOddDigits(num / 10);
            else return SumOddDigits(num / 10);
        }

        ////// EJERCICIO #2 //////
        // Entrada: Un número entero largo (long)
        // Salida: La cantidad de dígitos pares en el número
        // Restricción: El número debe ser un entero largo válido
        public long CountEvenDigits(long num)
        {
            if (num == 0) return 0;
            else if ((num % 10) % 2 == 0)
                return 1 + CountEvenDigits(num / 10);
            else return CountEvenDigits(num / 10);
        }

        ////// EJERCICIO #3 //////
        // Entrada: Un número entero largo (long)
        // Salida: True si el primer y último dígito son iguales, False en caso contrario
        // Restricción: El número debe ser no negativo
        public bool IsFirstLastEqual(long num)
        {
            if (num < 0)
                throw new ArgumentException("El número debe ser no negativo");

            if (num < 10) return true;
            return ((num % 10) == GetFirstDigit(num));
        }

        public long GetFirstDigit(long num)
        {
            if (num < 10) return num;
            return GetFirstDigit(num / 10);
        }

        ////// EJERCICIO #4 //////
        // Entrada: Un número entero largo (long)
        // Salida: True si la suma de todos los dígitos es mayor o igual a 10, False en caso contrario
        // Restricción: El número debe ser no negativo
        public bool IsSumAtLeastTen(long num)
        {
            if (num < 0)
                throw new ArgumentException("El número debe ser no negativo");

            return _basicStackRecursive.SumDigits(num) >= 10;
        }

        ////// EJERCICIO #5 //////
        // Entrada: Un número entero largo (long) y un dígito entero (0-9)
        // Salida: La cantidad de veces que aparece el dígito en el número
        // Restricción: El número debe ser no negativo y el dígito debe estar entre 0 y 9
        public int CountDigitOccurrences(long num, int dig)
        {
            if (num < 0)
                throw new ArgumentException("El número debe ser no negativo");
            if (dig < 0 || dig > 9)
                throw new ArgumentException("El dígito debe estar entre 0 y 9");

            if (num == 0) return 0;
            else if ((num % 10) == dig)
                return 1 + CountDigitOccurrences(num / 10, dig);
            else return CountDigitOccurrences(num / 10, dig);
        }

        ////// EJERCICIO #6 //////
        // Entrada: Un número entero largo (long)
        // Salida: Una tupla con (cantidad de dígitos bajos [0-4], cantidad de dígitos altos [5-9])
        // Restricción: El número debe ser no negativo
        public (int, int) AnalyzeDigits(long num)
        {
            if (num < 0)
                throw new ArgumentException("El número debe ser no negativo");

            return (CountLowDigits(num), CountHighDigits(num));
        }

        public int CountLowDigits(long num)
        {
            if (num == 0) return 0;
            else if (num % 10 >= 0 && num % 10 <= 4)
                return 1 + CountLowDigits(num / 10);
            else return CountLowDigits(num / 10);
        }

        public int CountHighDigits(long num)
        {
            if (num == 0) return 0;
            else if (num % 10 >= 5 && num % 10 <= 9)
                return 1 + CountHighDigits(num / 10);
            else return CountHighDigits(num / 10);
        }

        ////// EJERCICIO #7 //////
        // Entrada: Un número entero largo (long)
        // Salida: True si todos los dígitos son pares, False si hay al menos un dígito impar
        // Restricción: El número debe ser un entero largo válido
        public bool AreAllDigitsEven(long num)
        {
            if (num == 0) return true;
            else if ((num % 10) % 2 != 0)
                return false;
            else return AreAllDigitsEven(num / 10);
        }

        ////// EJERCICIO #8 //////
        // Entrada: Un número entero largo (long)
        // Salida: True si hay al menos un dígito par, False si todos son impares
        // Restricción: El número debe ser un entero largo válido
        public bool HasAtLeastOneEven(long num)
        {
            if (num == 0) return false;
            else if ((num % 10) % 2 == 0)
                return true;
            else return HasAtLeastOneEven(num / 10);
        }
    }
}