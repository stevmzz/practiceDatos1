using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practice.recursive
{
    class BasicStackRecursive
    {
        ////// EJERCICIO #1 //////
        // Entrada: un número entero largo (long)
        // Salida: un número que contiene solo los dígitos 1 del número original, manteniendo su posición
        // Restricción: el número debe ser positivo
        public long ExtractOnes(long num)
        {
            if (num == 0)
                return 0;
            else if (num % 10 == 1)
                return 1 + 10 * ExtractOnes(num / 10);
            else
                return ExtractOnes(num / 10);
        }

        ////// EJERCICIO #2 //////
        // Entrada: dos números enteros largos (long)
        // Salida: la concatenación de los dos números
        // Restricción: los números deben ser positivos
        public long AppendDigits(long num1, long num2)
        {
            return num1 * (long)Math.Pow(10, CountDigits(num2)) + num2;
        }
        public long CountDigits(long num)
        {
            if (num == 0)
                return 0;
            else return 1 + CountDigits(num / 10);
        }

        ////// EJERCICIO #3 //////
        // Entrada: dos números decimales (double)
        // Salida: el producto de la multiplicación de los dos números usando suma recursiva
        // Restricción: los números deben ser válidos para la multiplicación
        public double RecursiveMultiply(double num2, double num1)
        {
            if (num2 == 0)
                return 0;
            else if (num2 < 0)
                return -RecursiveMultiply(num1, -num2);
            else
                return num1 + RecursiveMultiply(num1, num2 - 1);
        }

        ////// EJERCICIO #4 //////
        // Entrada: un número entero largo (long)
        // Salida: true si la suma de sus dígitos es mayor o igual a 10, false en caso contrario
        // Restricción: el número debe ser positivo
        public bool IsSumGreaterOrEqualTen(long num)
        {
            return (SumDigits(num) >= 10);
        }
        public long SumDigits(long num)
        {
            long sum = 0;
            if (num == 0)
                return 0;
            else
                sum += (num % 10) + SumDigits(num / 10);
            return sum;
        }

        ////// EJERCICIO #5 //////
        // Entrada: un número entero largo (long)
        // Salida: una tupla con la suma de dígitos pares y la suma de dígitos impares
        // Restricción: el número debe ser positivo
        public (long evenSum, long oddSum) SumEvenOddDigits(long num)
        {
            return (SumEvenDigits(num), SumOddDigits(num));
        }
        public long SumEvenDigits(long num)
        {
            if (num == 0)
                return 0;
            else if ((num % 10) % 2 == 0)
                return num % 10 + SumEvenDigits(num / 10);
            else
                return SumEvenDigits(num / 10);
        }
        public long SumOddDigits(long num)
        {
            if (num == 0)
                return 0;
            else if ((num % 10) % 2 != 0)
                return num % 10 + SumOddDigits(num / 10);
            else
                return SumOddDigits(num / 10);
        }

        ////// EJERCICIO #6 //////
        // Entrada: un número entero largo (long)
        // Salida: "Perfecto" si la suma de sus divisores es igual al número,
        //         "Abundante" si la suma es mayor,
        //         "Deficiente" si la suma es menor
        // Restricción: el número debe ser positivo
        public string ClassifyNumber(long num)
        {
            long divNum = DivisorSum(num);
            if (divNum == num)
                return "Perfecto";
            else if (divNum >= num)
                return "Abundante";
            else
                return "Deficiente";
        }
        public long DivisorSum(long num, long div = 1, long sum = 0)
        {
            if (div == num)
                return (sum + div) - num;
            else if (num % div == 0)
                return DivisorSum(num, div + 1, sum + div);
            else
                return DivisorSum(num, div + 1, sum);
        }

        ////// EJERCICIO #7 //////
        // Entrada: dos números enteros largos (long)
        // Salida: true si todos los dígitos del segundo número están contenidos en el primer número,
        //         false en caso contrario
        // Restricción: los números deben ser positivos
        public bool AreDigitsContained(long num1, long num2)
        {
            if (num2 == 0)
                return FindDigit(num1, 0);

            return CheckDigit(num1, num2);
        }
        public bool CheckDigit(long num1, long num2)
        {
            if (num2 == 0)
                return true;
            else if (FindDigit(num1, num2 % 10))
                return CheckDigit(num1, num2 / 10);
            else
                return false;
        }
        public bool FindDigit(long num1, long digit)
        {
            if (num1 == 0)
                return false;
            else if (num1 % 10 == digit)
                return true;
            else
                return FindDigit(num1 / 10, digit);
        }
    }
}
