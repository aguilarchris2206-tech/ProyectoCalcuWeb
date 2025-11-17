using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoCalcuWeb
{
    public class clsOperacion
    {
        public static float valor1 { get; set; }
        public static float valor2 { get; set; }

        public static bool sumar = false;
        public static bool restar = false;
        public static bool multiplicar = false;
        public static bool dividir = false;
        public static bool factorial = false;
        public static bool exponente2 = false;
        public static bool exponente3 = false;
        public static bool raizCuadrada = false;
        public static bool fibonacci = false;



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

            if (v1 != numero)
                throw new ArgumentException("El factorial requiere un número entero");
            if (numero < 0)
                throw new ArgumentException("El factorial no está definido para números negativos");
            if (numero > 20)
                throw new ArgumentException("Número demasiado grande para factorial (máx: 20)");

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
    }
}