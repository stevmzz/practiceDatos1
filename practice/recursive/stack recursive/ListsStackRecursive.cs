using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practice.recursive
{
    class ListsStackRecursive
    {
        ////// EJERCICIO #1 //////
        // Entrada: un dígito y una lista de números
        // Salida: dos listas, una con números mayores o iguales al dígito y otra con menores
        // Restricción: el dígito debe estar entre 0 y 9
        public (List<int>, List<int>) SplitListByThreshold(int threshold, List<int> list)
        {
            if (threshold < 0 || threshold > 9)
            {
                throw new ArgumentException("El dígito debe estar entre 0 y 9.");
            }
            return (GetGreaterOrEqual(threshold, list), GetLessThan(threshold, list));
        }
        public List<int> GetGreaterOrEqual(int threshold, List<int> list)
        {
            if (list.Count == 0)
                return new List<int>();
            else if (list[0] >= threshold)
                return new List<int> { list[0] }.Concat(GetGreaterOrEqual(threshold, list.GetRange(1, list.Count - 1))).ToList();
            else
                return GetGreaterOrEqual(threshold, list.GetRange(1, list.Count - 1));
        }
        public List<int> GetLessThan(int threshold, List<int> list)
        {
            if (list.Count == 0)
                return new List<int>();
            else if (list[0] < threshold)
                return new List<int> { list[0] }.Concat(GetLessThan(threshold, list.GetRange(1, list.Count - 1))).ToList();
            else
                return GetLessThan(threshold, list.GetRange(1, list.Count - 1));
        }

        ////// EJERCICIO #2 //////
        // Entrada: una lista de 10 calificaciones (escala 1-100)
        // Salida: el promedio excluyendo la calificación más alta y más baja
        // Restricción: debe contener exactamente 10 calificaciones
        public int CalculateScore(List<int> scores)
        {
            if (scores.Count != 10)
                throw new ArgumentException("Debe haber exactamente 10 calificaciones");

            int highest = GetHighest(scores);
            int lowest = GetLowest(scores);
            int sum = CalculateSum(scores, highest, lowest);
            return sum / 8;
        }
        public int GetHighest(List<int> scores)
        {
            if (scores.Count == 1)
                return scores[0];

            int max = GetHighest(scores.GetRange(1, scores.Count - 1));
            return scores[0] > max ? scores[0] : max;
        }
        public int GetLowest(List<int> scores)
        {
            if (scores.Count == 1)
                return scores[0];

            int min = GetLowest(scores.GetRange(1, scores.Count - 1));
            return scores[0] < min ? scores[0] : min;
        }
        public int CalculateSum(List<int> scores, int highest, int lowest)
        {
            if (scores.Count == 1)
                return scores[0];

            int current = scores[0];

            int sum = (current != highest && current != lowest) ? current : 0;

            return sum + CalculateSum(scores.GetRange(1, scores.Count - 1), highest, lowest);
        }

        ////// EJERCICIO #3 //////
        // Entrada: una lista de números enteros
        // Salida: dos listas, una con números pares y otra con impares
        // Restricción: la lista debe contener al menos un número
        public (List<int>, List<int>) SplitByParity(List<int> list)
        {
            if (list.Count == 0)
                return (new List<int>(), new List<int>());

            var (evens, odds) = SplitByParity(list.GetRange(1, list.Count - 1));

            if (list[0] % 2 == 0)
                evens.Insert(0, list[0]);
            else
                odds.Insert(0, list[0]);

            return (evens, odds);
        }

        ////// EJERCICIO #4 //////
        // Entrada: una lista de números enteros
        // Salida: cantidad de veces que aparecen elementos duplicados consecutivamente
        // Restricción: la lista debe contener al menos un número
        public int CountConsecutiveDuplicates(List<int> list)
        {
            if (list.Count <= 1)
                return 0;

            int restCount = CountConsecutiveDuplicates(list.GetRange(1, list.Count - 1));

            if (list[0] == list[1])
                return restCount + 1;
            else
                return restCount;
        }

        ////// EJERCICIO #5 //////
        // Entrada: una lista de números enteros
        // Salida: dos sublistas con elementos en posiciones pares e impares respectivamente
        // Restricción: la lista debe contener al menos un número
        public (List<int>, List<int>) AlternateSublists(List<int> list)
        {
            if (list.Count == 0)
                return (new List<int>(), new List<int>());

            if (list.Count == 1)
                return (new List<int> { list[0] }, new List<int>());

            var (evenPositions, oddPositions) = AlternateSublists(list.GetRange(2, list.Count - 2));

            evenPositions.Insert(0, list[0]);
            oddPositions.Insert(0, list[1]);

            return (evenPositions, oddPositions);
        }
    }
}
