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
        // Entrada: 
        // Salida: 
        // Restricción: 
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
        // Entrada: 
        // Salida: 
        // Restricción: 
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
        // Entrada: 
        // Salida: 
        // Restricción: 


    }
}
