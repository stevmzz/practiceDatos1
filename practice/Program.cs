using System;
using System.Security.Cryptography.X509Certificates;
using practice;
using practice.recursive;

class Program
{
    static void Main(string[] args)
    {
        Conditionals conditionals = new Conditionals();
        BasicStackRecursive recursive = new BasicStackRecursive();
        NumbersStackRecursive numbers = new NumbersStackRecursive();
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
                    ManejarMenuRecursividadAux(recursive, numbers);
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
        Console.WriteLine("2. Recursividad");
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

    static void MostrarMenuRecursividadAux()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("      EJERCICIOS RECURSIVIDAD     ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" 1. Recursividad de pila");
        Console.WriteLine(" 2. Recursividad de cola");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Ingrese una opción: ");
    }

    static void MostrarMenuCategoriasRecursividadPila()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("  CATEGORÍAS RECURSIVIDAD DE PILA  ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" 1. Ejercicios Básicos");
        Console.WriteLine(" 2. Ejercicios con Números");
        Console.WriteLine(" 3. Ejercicios con Listas");
        Console.WriteLine(" 4. Ejercicios con Arrays");
        Console.WriteLine(" 5. Ejercicios Avanzados");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Ingrese una opción: ");
    }

    static void MostrarMenuRecursividadPilaBasica()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("  EJERCICIOS BÁSICOS DE RECURSIVIDAD  ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" 1. Concatenar 'unos'");
        Console.WriteLine(" 2. Concatenar dígitos");
        Console.WriteLine(" 3. Multiplicación por sumas");
        Console.WriteLine(" 4. Suma mayor a diez");
        Console.WriteLine(" 5. Suma pares e impares");
        Console.WriteLine(" 6. Clasificador");
        Console.WriteLine(" 7. Todos dentro del segundo");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Ingrese una opción: ");
    }

    static void MostrarMenuRecursividadPilaNumeros()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("  EJERCICIOS NUMÉRICOS RECURSIVOS  ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" 1. Suma de dígitos impares");
        Console.WriteLine(" 2. Contar dígitos pares");
        Console.WriteLine(" 3. Primer y último dígito iguales");
        Console.WriteLine(" 4. Suma de dígitos mayor a diez");
        Console.WriteLine(" 5. Contar ocurrencias de un dígito");
        Console.WriteLine(" 6. Análisis de dígitos (bajos/altos)");
        Console.WriteLine(" 7. Verificar si todos son pares");
        Console.WriteLine(" 8. Verificar si hay al menos un par");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Ingrese una opción: ");
    }

    static void MostrarMenuRecursividadPilaListas()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("  EJERCICIOS RECURSIVOS CON LISTAS ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" [Ejercicios pendientes de implementar]");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Presione cualquier tecla para volver...");
    }

    static void MostrarMenuRecursividadPilaArrays()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("  EJERCICIOS RECURSIVOS CON ARRAYS ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" [Ejercicios pendientes de implementar]");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Presione cualquier tecla para volver...");
    }

    static void MostrarMenuRecursividadPilaAvanzados()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("  EJERCICIOS RECURSIVOS AVANZADOS  ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" [Ejercicios pendientes de implementar]");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Presione cualquier tecla para volver...");
    }

    static void MostrarMenuRecursividadCola()
    {
        Console.Clear();
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine("  EJERCICIOS RECURSIVIDAD DE COLA     ");
        Console.WriteLine("═══════════════════════════════════");
        Console.WriteLine(" 1. Ejercicio 1");
        Console.WriteLine(" 2. Ejercicio 2");
        Console.WriteLine("───────────────────────────────────");
        Console.Write("Ingrese una opción: ");
    }

    static void ManejarMenuRecursividadAux(BasicStackRecursive basicStackRecursive, NumbersStackRecursive numbersStackRecursive)
    {
        MostrarMenuRecursividadAux();
        string opcion = Console.ReadLine();
        Console.Clear();

        switch (opcion)
        {
            case "1":
                MostrarMenuCategoriasRecursividadPila();
                string opcionCategoria = Console.ReadLine();
                Console.Clear();

                switch (opcionCategoria)
                {
                    case "1": // Ejercicios Básicos
                        MostrarMenuRecursividadPilaBasica();
                        string opcionPila = Console.ReadLine();
                        Console.Clear();
                        switch (opcionPila)
                        {
                            case "1":
                                Console.Write("Ingrese el número: ");
                                string num = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"Resultado de solo 'unos': {basicStackRecursive.ExtractOnes(long.Parse(num))}");
                                break;

                            case "2":
                                Console.Write("Ingrese un número: ");
                                string num1 = Console.ReadLine();
                                Console.Write("Ingrese un segundo número: ");
                                string num2 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"Resultado de los dos números concatenados: {basicStackRecursive.AppendDigits(long.Parse(num1), long.Parse(num2))}");
                                break;

                            case "3":
                                Console.Write("Ingrese un número: ");
                                string numb1 = Console.ReadLine();
                                Console.Write("Ingrese un segundo número: ");
                                string numb2 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"Resultado de multiplicación por sumas sucecivas: {basicStackRecursive.RecursiveMultiply(long.Parse(numb1), long.Parse(numb2))}");
                                break;

                            case "4":
                                Console.Write("Ingrese el número: ");
                                string numb = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"Resultado de si la suma de los dígitos es >= 10: {basicStackRecursive.IsSumGreaterOrEqualTen(long.Parse(numb))}");
                                break;

                            case "5":
                                Console.Write("Ingrese el número: ");
                                string numbe = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"Resultado de (suma pares, suma impares): {basicStackRecursive.SumEvenOddDigits(long.Parse(numbe))}");
                                break;

                            case "6":
                                Console.Write("Ingrese el número: ");
                                string number = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"Resultado: {basicStackRecursive.ClassifyNumber(long.Parse(number))}");
                                break;

                            case "7":
                                Console.Write("Ingrese un número: ");
                                string number1 = Console.ReadLine();
                                Console.Write("Ingrese un segundo número: ");
                                string number2 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"¿Todos los digitos de {number1} están en {number2}?: {basicStackRecursive.AreDigitsContained(long.Parse(number1), long.Parse(number2))}");
                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                        break;

                    case "2": // Ejercicios con Números
                        MostrarMenuRecursividadPilaNumeros();
                        string opcionPilaNum = Console.ReadLine();
                        Console.Clear();
                        switch (opcionPilaNum)
                        {
                            case "1":
                                Console.Write("Ingrese un número: ");
                                string number = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"La suma de los dígitos impares es: {numbersStackRecursive.SumOddDigits(long.Parse(number))}");
                                break;

                            case "2":
                                Console.Write("Ingrese un número: ");
                                string number1 = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"El número contiene {numbersStackRecursive.CountEvenDigits(long.Parse(number1))} dígitos pares");
                                break;

                            case "3":
                                Console.Write("Ingrese un número: ");
                                string numbe1 = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"¿El primer y último dígito son iguales?: {numbersStackRecursive.IsFirstLastEqual(long.Parse(numbe1))}");
                                break;

                            case "4":
                                Console.Write("Ingrese un número: ");
                                string numb1 = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"¿La suma de los dígitos es mayor o igual a 10?: {numbersStackRecursive.IsSumAtLeastTen(long.Parse(numb1))}");
                                break;

                            case "5":
                                Console.Write("Ingrese un número: ");
                                string n1 = Console.ReadLine();
                                Console.Write("Ingrese el dígito a buscar (0-9): ");
                                string n2 = Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine($"El dígito {n2} aparece {numbersStackRecursive.CountDigitOccurrences(long.Parse(n1), int.Parse(n2))} veces en el número");
                                break;

                            case "6":
                                Console.Write("Ingrese un número: ");
                                string nu1 = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                var (bajos, altos) = numbersStackRecursive.AnalyzeDigits(long.Parse(nu1));
                                Console.WriteLine($"Análisis de dígitos:");
                                Console.WriteLine($"- Dígitos bajos (0-4): {bajos}");
                                Console.WriteLine($"- Dígitos altos (5-9): {altos}");
                                break;

                            case "7":
                                Console.Write("Ingrese un número: ");
                                string num = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"¿Todos los dígitos son pares?: {numbersStackRecursive.AreAllDigitsEven(long.Parse(num))}");
                                break;

                            case "8":
                                Console.Write("Ingrese un número: ");
                                string numberOne = Console.ReadLine()?.ToUpper();
                                Console.Clear();
                                Console.WriteLine($"¿Hay al menos un dígito par?: {numbersStackRecursive.HasAtLeastOneEven(long.Parse(numberOne))}");
                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                        break;

                    case "3": // Ejercicios con Listas
                        MostrarMenuRecursividadPilaListas();
                        Console.ReadKey();
                        break;

                    case "4": // Ejercicios con Arrays
                        MostrarMenuRecursividadPilaArrays();
                        Console.ReadKey();
                        break;

                    case "5": // Ejercicios Avanzados
                        MostrarMenuRecursividadPilaAvanzados();
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                break;

            case "2": // Recursividad de cola
                MostrarMenuRecursividadCola();
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
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