using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.conditionals
{
    class Conditionals
    {
        ////// EJERCICIO #1 //////
        // Entrada: nombre del equipo (string)
        // Salida: descripción de la calidad del equipo
        // Restricción: debe ser un equipo válido (LDA, SAP, HER, CAR)
        public string EvaluateTeamQuality(string team)
        {
            if (team == "LDA")
            {
                return "La Liga Deportiva Alajuelense es el segundo mejor equipo";
            }
            else if (team == "SAP")
            {
                return "El Deportivo Saprissa es el primer mejor equipo";
            }
            else if (team == "HER")
            {
                return "El Club Sport Herediano está en término medio";
            }
            else if (team == "CAR")
            {
                return "El Club Sport Cartaginés es el equipo glorioso";
            }
            return "Equipo no reconocido. Use: LDA, SAP, HER o CAR";
        }

        public string DetermineConsumerLevel(int amount)
        {
            if (amount < 0)
            {
                return "Error: El monto no puede ser negativo";
            }
            if (amount < 10000)
            {
                return "Categoría: Usuario Moderado (Consumo Bajo)";
            }
            else if (amount < 20000)
            {
                return "Categoría: Usuario Nivel 1 (Consumo Medio-Bajo)";
            }
            else if (amount < 25000)
            {
                return "Categoría: Usuario Nivel 2 (Consumo Medio)";
            }
            else if (amount < 30000)
            {
                return "Categoría: Usuario Nivel 3 (Consumo Medio-Alto)";
            }
            return "Categoría: Usuario Nivel 4 (Alto Consumo)";
        }

        ////// EJERCICIO #3 //////
        // Entrada: salario bruto (double)
        // Salida: salario neto después de impuestos
        // Restricción: salario debe ser mayor o igual a 100000
        public string CalculateNetSalary(double grossSalary)
        {
            double netSalary;
            if (grossSalary < 100000)
            {
                return "Error: El salario debe ser mayor o igual a 100,000";
            }
            if (grossSalary < 300000)
            {
                netSalary = grossSalary * 0.90;
                return $"Salario neto (reducción 10%): {netSalary}";
            }
            else if (grossSalary < 500000)
            {
                netSalary = grossSalary * 0.85;
                return $"Salario neto (reducción 15%): {netSalary}";
            }
            else if (grossSalary < 700000)
            {
                netSalary = grossSalary * 0.75;
                return $"Salario neto (reducción 25%): {netSalary}";
            }
            netSalary = grossSalary * 0.70;
            return $"Salario neto (reducción 30%): {netSalary}";
        }

        ////// EJERCICIO #4 //////
        // Entrada: nombre del mes (string)
        // Salida: cuatrimestre al que pertenece el mes
        // Restricción: mes debe ser válido en español
        public string DetermineQuarter(string month)
        {
            string[] firstQuarter = { "enero", "febrero", "marzo", "abril" };
            string[] secondQuarter = { "mayo", "junio", "julio", "agosto" };
            string[] thirdQuarter = { "septiembre", "octubre", "noviembre", "diciembre" };

            if (firstQuarter.Contains(month))
            {
                return "Pertenece al Primer Cuatrimestre (Enero-Abril)";
            }
            else if (secondQuarter.Contains(month))
            {
                return "Pertenece al Segundo Cuatrimestre (Mayo-Agosto)";
            }
            else if (thirdQuarter.Contains(month))
            {
                return "Pertenece al Tercer Cuatrimestre (Septiembre-Diciembre)";
            }
            return "Error: Mes no válido. Ingrese el mes en español";
        }

        ////// EJERCICIO #5 //////
        // Entrada: tres números enteros
        // Salida: el menor de los tres números
        // Restricción: deben ser valores enteros
        public string FindSmallestNumber(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return $"El número menor es: {num1}";
            }
            else if (num2 < num1 && num2 < num3)
            {
                return $"El número menor es: {num2}";
            }
            return $"El número menor es: {num3}";
        }

        ////// EJERCICIO #6 //////
        // Entrada: precio del producto (int)
        // Salida: estado de exención de impuestos
        // Restricción: precio debe ser un valor válido
        public string CheckTaxExemption(int price)
        {
            int[] exemptPrices = { 10, 20, 30, 40, 50, 60, 1000, 2000, 3000 };

            if (price < 0)
            {
                return "Error: El precio no puede ser negativo";
            }
            if (exemptPrices.Contains(price))
            {
                return $"El producto con precio {price} está exento de impuestos";
            }
            return $"El producto con precio {price} debe pagar impuestos";
        }

        ////// EJERCICIO #7 //////
        // Entrada: dos números enteros
        // Salida: resultado de la operación según las condiciones
        // Restricción: división no permite divisor cero
        public string PerformNumberOperation(int num1, int num2)
        {
            if (num1 == num2)
            {
                if (num2 == 0)
                {
                    return "Error: No se puede dividir entre cero";
                }
                return $"Números iguales | División: {num1 / num2}";
            }
            else if (num1 > num2)
            {
                return $"Primer número mayor | Suma: {num1 + num2}";
            }
            else if (num2 > num1)
            {
                return $"Segundo número mayor | Resta: {num2 - num1}";
            }
            return $"Números diferentes | Multiplicación: {num1 * num2}";
        }

        ////// EJERCICIO #8 //////
        // Entrada: resistencia y corriente (double)
        // Salida: caída de voltaje según ley de Ohm
        // Restricción: resistencia entre 0 y 1000Ω
        public string CalculateOhmVoltage(double resistance, double current)
        {
            if (resistance < 0)
            {
                return "Error: La resistencia no puede ser negativa";
            }
            if (resistance > 1000)
            {
                return "Error: La resistencia no puede superar 1000Ω";
            }
            double voltage = resistance * current;
            return $"Voltaje calculado: {voltage}V";
        }

        ////// EJERCICIO #9 //////
        // Entrada: edad (int) y género (string)
        // Salida: recomendación de bebida
        // Restricciones: edad válida y género debe ser "hombre" o "mujer"
        public string GetDrinkRecommendation(int age, string gender)
        {
            if (age < 18)
            {
                return "Recomendación: Gaseosa (Menor de edad)";
            }

            if (gender == "hombre")
            {
                if (age < 60)
                {
                    return "Recomendación: Tequila";
                }
                return "Recomendación: Leche";
            }
            else if (gender == "mujer")
            {
                if (age >= 60)
                {
                    return "Recomendación: Sustagen";
                }
                return "Recomendación: Margarita";
            }
            return "Error: Género no válido.";
        }

        ////// EJERCICIO #10 //////
        // Entrada: metros (double) e indicador (int 1-4)
        // Salida: conversión según el indicador
        // Restricciones: indicador debe estar entre 1 y 4
        public string ConvertMeasurement(double meters, int indicator)
        {
            double pulgadas = meters * 39.3701;
            double cm = meters * 100;
            double pies = meters * 3.28084;
            double yards = meters * 1.09361;

            if (indicator == 1)
            {
                return $"La cantidad en centímetros es: {cm}";
            }
            else if (indicator == 2)
            {
                return $"La cantidad en pulgadas es: {pulgadas}";
            }
            else if (indicator == 3)
            {
                return $"La cantidad en pies es: {pies}";
            }
            else if (indicator == 4)
            {
                return $"La cantidad en yardas es: {yards}";
            }
            else
            {
                return "Error: Tipo de indicador inválido (use 1-4)";
            }
        }

        ////// EJERCICIO #11 //////
        // Entrada: número entero
        // Salida: equivalente en números romanos
        // Restricciones: número debe estar entre 1 y 7
        public string ConvertToRomanNumeral(int number)
        {
            if (number < 1 || number > 7)
            {
                return "Error: El número debe estar entre 1 y 7";
            }

            string[] romanNumerals = { "I", "II", "III", "IV", "V", "VI", "VII" };
            return $"El número {number} en numeración romana es: {romanNumerals[number - 1]}";
        }
    }
}