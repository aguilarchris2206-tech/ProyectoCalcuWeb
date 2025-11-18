using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalcuWeb
{
    public class clsOperacion
    {
        // Propiedades para almacenar valores y operaciones
        public static float valor1 { get; set; }
        public static float valor2 { get; set; }

        // Flags para operaciones binarias
        public static bool sumar = false;
        public static bool restar = false;
        public static bool multiplicar = false;
        public static bool dividir = false;

        // OPERACIONES BINARIAS
        public static float metodo_sumar(float v1, float v2)
        {
            return v1 + v2;
        }

        public static float metodo_restar(float v1, float v2)
        {
            return v1 - v2;
        }

        public static float metodo_multiplicar(float v1, float v2)
        {
            return v1 * v2;
        }

        public static float metodo_dividir(float v1, float v2)
        {
            if (v2 == 0)
                throw new DivideByZeroException("No se puede dividir por cero");
            return v1 / v2;
        }

        // OPERACIONES UNITARIAS
        public static float metodo_exponente2(float v1)
        {
            return v1 * v1;
        }

        public static float metodo_exponente3(float v1)
        {
            return v1 * v1 * v1;
        }

        public static float metodo_raizCuadrada(float v1)
        {
            if (v1 < 0)
                throw new ArgumentException("No existe raíz cuadrada de números negativos");
            return (float)Math.Sqrt(v1);
        }

        public static long metodo_factorial(float v1)
        {
            int numero = (int)v1;
            // Validaciones
            if (v1 != numero)
                throw new ArgumentException("El factorial requiere un número entero");
            if (numero < 0)
                throw new ArgumentException("El factorial no está definido para números negativos");
            if (numero > 20)
                throw new ArgumentException("Número demasiado grande para factorial (máx: 20)");

            // Cálculo del factorial
            if (numero == 0 || numero == 1) return 1;

            long resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public static long metodo_fibonacci(float v1)
        {
            int numero = (int)v1;
            // Validaciones
            if (v1 != numero)
                throw new ArgumentException("Fibonacci requiere un número entero");
            if (numero < 0)
                throw new ArgumentException("Fibonacci no está definido para números negativos");
            if (numero > 50)
                throw new ArgumentException("Número demasiado grande para Fibonacci (máx: 50)");

            // Casos base
            if (numero == 0) return 0;
            if (numero == 1) return 1;

            // Cálculo de Fibonacci
            long a = 0;
            long b = 1;
            long resultado = 0;

            for (int i = 2; i <= numero; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }

            return resultado;
        }

        // Método para resetear todas las operaciones
        public static void ResetOperaciones()
        {
            sumar = false;
            restar = false;
            multiplicar = false;
            dividir = false;
        }

        // Método para ejecutar la operación binaria seleccionada
        public static float EjecutarOperacionBinaria()
        {
            if (sumar)
                return metodo_sumar(valor1, valor2);
            else if (restar)
                return metodo_restar(valor1, valor2);
            else if (multiplicar)
                return metodo_multiplicar(valor1, valor2);
            else if (dividir)
                return metodo_dividir(valor1, valor2);
            else
                throw new InvalidOperationException("No se ha seleccionado ninguna operación");
        }
    }
}