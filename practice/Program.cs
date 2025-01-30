using System;
using practice;

class Program
{
    static void Main(string[] args)
    {
        Conditionals conditionals = new Conditionals();
        bool running = true;

        while (running)
        {
            MostrarMenuPrincipal();
            string opcionPrincipal = Console.ReadLine();

            switch (opcionPrincipal)
            {
                case "0":
                    running = false;
                    break;

                case "1":
                    ManejarMenuCondicionales(conditionals);
                    break;

                case "2":
                    Console.WriteLine("Módulo de Iteración en desarrollo...");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void MostrarMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════");
        Console.WriteLine("      MENÚ PRINCIPAL       ");
        Console.WriteLine("═══════════════════════════");
        Console.WriteLine("0. Salir");
        Console.WriteLine("1. Condicionales");
        Console.WriteLine("2. Iteración");
        Console.WriteLine("───────────────────────────");
        Console.Write("Ingrese una opción: ");
    }

    static void MostrarMenuCondicionales()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("      EJERCICIOS CONDICIONALES     ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" 1. Equipos de Fútbol");
        Console.WriteLine(" 2. Tipo de Usuario");
        Console.WriteLine(" 3. Cálculo de Salario");
        Console.WriteLine(" 4. Mes a Cuatrimestre");
        Console.WriteLine(" 5. Número Menor");
        Console.WriteLine(" 6. Exención de Impuestos");
        Console.WriteLine(" 7. Cálculo Basado en Comparación");
        Console.WriteLine(" 8. Ley de Ohm");
        Console.WriteLine(" 9. Recomendación de Bebidas");
        Console.WriteLine("10. Conversión de Medidas");
        Console.WriteLine("11. Números Romanos");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Ingrese una opción: ");
    }

    static void ManejarMenuCondicionales(Conditionals conditionals)
    {
        MostrarMenuCondicionales();
        string opcion = Console.ReadLine();
        Console.Clear();

        switch (opcion)
        {
            case "1":
                Console.Write("Ingrese el nombre del equipo (LDA/SAP/HER/CAR): ");
                string team = Console.ReadLine()?.ToUpper();
                Console.Clear();
                Console.WriteLine($"Resultado: {conditionals.EvaluateTeamQuality(team)}");
                break;

            case "2":
                Console.Write("Ingrese el monto a pagar: ");
                if (int.TryParse(Console.ReadLine(), out int money))
                {
                    Console.Clear();
                    Console.WriteLine($"Resultado: {conditionals.DetermineConsumerLevel(money)}");
                }
                break;

            case "3":
                Console.Write("Ingrese el salario: ");
                if (double.TryParse(Console.ReadLine(), out double salary))
                {
                    Console.Clear();
                    Console.WriteLine($"Resultado: {conditionals.CalculateNetSalary(salary)}");
                }
                break;

            case "4":
                Console.Write("Ingrese un mes: ");
                string month = Console.ReadLine()?.ToLower();
                Console.Clear();
                Console.WriteLine($"Resultado: {conditionals.DetermineQuarter(month)}");
                break;

            case "5":
                Console.Write("Ingrese primer número: ");
                string num1 = Console.ReadLine();
                Console.Write("Ingrese un segundo número: ");
                string num2 = Console.ReadLine();
                Console.Write("Ingrese un último número: ");
                string num3 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Resultado: {conditionals.FindSmallestNumber(int.Parse(num1), int.Parse(num2), int.Parse(num3))}");
                break;

            case "6":
                Console.Write("Ingrese el monto del producto: ");
                if (int.TryParse(Console.ReadLine(), out int price))
                {
                    Console.Clear();
                    Console.WriteLine($"Resultado: {conditionals.CheckTaxExemption(price)}");
                }
                break;

            case "7":
                Console.Write("Ingrese primer número: ");
                string numb1 = Console.ReadLine();
                Console.Write("Ingrese un segundo número: ");
                string numb2 = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Resultado: {conditionals.PerformNumberOperation(int.Parse(numb1), int.Parse(numb2))}");
                break;

            case "8":
                Console.Write("Ingrese la resistencia: ");
                string resistance = Console.ReadLine();
                Console.Write("Ingrese la intensidad: ");
                string current = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Resultado: {conditionals.CalculateOhmVoltage(double.Parse(resistance), double.Parse(current))}");
                break;

            case "9":
                Console.Write("Ingrese la edad: ");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.Write("Ingrese el género (hombre/mujer): ");
                    string gender = Console.ReadLine()?.ToLower();
                    Console.Clear();
                    Console.WriteLine($"Resultado: {conditionals.GetDrinkRecommendation(age, gender)}");
                }
                break;

            case "10":
                Console.Write("Ingrese la cantidad en metros: ");
                if (double.TryParse(Console.ReadLine(), out double meters))
                {
                    Console.Write("Ingrese el indicador (1-4): ");
                    if (int.TryParse(Console.ReadLine(), out int indicator))
                    {
                        Console.Clear();
                        Console.WriteLine($"Resultado: {conditionals.ConvertMeasurement(meters, indicator)}");
                    }
                }
                break;

            case "11":
                Console.Write("Ingrese un número (1-7): ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.Clear();
                    Console.WriteLine($"Resultado: {conditionals.ConvertToRomanNumeral(number)}");
                }
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}