using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCalcuWeb
{
    public partial class HTML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lresultado.Text = "0";
            }
        }

        // Métodos de números (mantener igual)
        protected void b0_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "0";
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "1";
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "2";
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "3";
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "4";
        }

        protected void b5_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "5";
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "6";
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "7";
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "8";
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0") lresultado.Text = "";
            lresultado.Text = lresultado.Text + "9";
        }

        // Botón Clear
        protected void bclear_Click(object sender, EventArgs e)
        {
            lresultado.Text = "0";
            ResetOperaciones();
        }

        // Método para resetear todas las operaciones
        private void ResetOperaciones()
        {
            clsOperacion.sumar = false;
            clsOperacion.restar = false;
            clsOperacion.multiplicar = false;
            clsOperacion.dividir = false;
            clsOperacion.factorial = false;
            clsOperacion.exponente2 = false;
            clsOperacion.exponente3 = false;
            clsOperacion.raizCuadrada = false;
            clsOperacion.fibonacci = false;
        }

        // OPERACIONES BINARIAS - VERSIÓN ORIGINAL CORREGIDA
        protected void bsuma_Click(object sender, EventArgs e)
        {
            // Guardar el primer número
            if (float.TryParse(lresultado.Text, out float valor1))
            {
                clsOperacion.valor1 = valor1;
                clsOperacion.sumar = true;
                clsOperacion.restar = false;
                clsOperacion.multiplicar = false;
                clsOperacion.dividir = false;
                lresultado.Text = "0"; // Limpiar para el segundo número
            }
        }

        protected void bresta_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor1))
            {
                clsOperacion.valor1 = valor1;
                clsOperacion.sumar = false;
                clsOperacion.restar = true;
                clsOperacion.multiplicar = false;
                clsOperacion.dividir = false;
                lresultado.Text = "0";
            }
        }

        protected void bmultiply_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor1))
            {
                clsOperacion.valor1 = valor1;
                clsOperacion.sumar = false;
                clsOperacion.restar = false;
                clsOperacion.multiplicar = true;
                clsOperacion.dividir = false;
                lresultado.Text = "0";
            }
        }

        protected void bdivide_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor1))
            {
                clsOperacion.valor1 = valor1;
                clsOperacion.sumar = false;
                clsOperacion.restar = false;
                clsOperacion.multiplicar = false;
                clsOperacion.dividir = true;
                lresultado.Text = "0";
            }
        }

        // Botón de resultado
        protected void bresultado_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.TryParse(lresultado.Text, out float valor2))
                {
                    clsOperacion.valor2 = valor2;
                    float resultado = 0;

                    if (clsOperacion.sumar)
                    {
                        resultado = clsOperacion.metodo_sumar(clsOperacion.valor1, clsOperacion.valor2);
                    }
                    else if (clsOperacion.restar)
                    {
                        resultado = clsOperacion.metodo_restar(clsOperacion.valor1, clsOperacion.valor2);
                    }
                    else if (clsOperacion.multiplicar)
                    {
                        resultado = clsOperacion.metodo_multiplicar(clsOperacion.valor1, clsOperacion.valor2);
                    }
                    else if (clsOperacion.dividir)
                    {
                        resultado = clsOperacion.metodo_dividir(clsOperacion.valor1, clsOperacion.valor2);
                    }

                    lresultado.Text = resultado.ToString();
                    ResetOperaciones();
                }
            }
            catch (Exception ex)
            {
                lresultado.Text = $"Error: {ex.Message}";
                ResetOperaciones();
            }
        }

        // Botón decimal
        protected void bdecimal_Click(object sender, EventArgs e)
        {
            if (lresultado.Text == "0")
            {
                lresultado.Text = "0.";
            }
            else if (!lresultado.Text.Contains("."))
            {
                lresultado.Text += ".";
            }
        }

        // OPERACIONES UNITARIAS - cálculo inmediato
        protected void Button1_Click(object sender, EventArgs e)
        {
            CalcularFactorialDirecto();
        }

        private void CalcularFactorialDirecto()
        {
            try
            {
                string textoActual = lresultado.Text;

                if (string.IsNullOrEmpty(textoActual) || textoActual == "0")
                {
                    lresultado.Text = "1";
                    return;
                }

                if (int.TryParse(textoActual, out int numero))
                {
                    if (numero < 0)
                    {
                        lresultado.Text = "Error: No negativo";
                        return;
                    }

                    if (numero > 20)
                    {
                        lresultado.Text = "Error: Máx 20";
                        return;
                    }

                    long resultado = 1;
                    for (int i = 2; i <= numero; i++)
                    {
                        resultado *= i;
                    }

                    lresultado.Text = resultado.ToString();
                }
                else
                {
                    lresultado.Text = "Error: Número inválido";
                }
            }
            catch (Exception ex)
            {
                lresultado.Text = $"Error: {ex.Message}";
            }
        }

        protected void bpower2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                float resultado = clsOperacion.metodo_exponente2(valor);
                lresultado.Text = resultado.ToString();
            }
        }

        protected void bpower3_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor))
            {
                float resultado = clsOperacion.metodo_exponente3(valor);
                lresultado.Text = resultado.ToString();
            }
        }

        protected void bsqrt_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.TryParse(lresultado.Text, out float numero))
                {
                    float resultado = clsOperacion.metodo_raizCuadrada(numero);
                    lresultado.Text = resultado.ToString("F6").TrimEnd('0').TrimEnd('.');
                }
            }
            catch (Exception ex)
            {
                lresultado.Text = $"Error: {ex.Message}";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string textoActual = lresultado.Text;

                if (string.IsNullOrEmpty(textoActual))
                {
                    lresultado.Text = "0";
                    return;
                }

                if (int.TryParse(textoActual, out int numero))
                {
                    if (numero < 0)
                    {
                        lresultado.Text = "Error: No negativo";
                        return;
                    }

                    if (numero > 50)
                    {
                        lresultado.Text = "Error: Máx 50";
                        return;
                    }

                    long resultado = clsOperacion.metodo_fibonacci(numero);
                    lresultado.Text = resultado.ToString();
                }
                else
                {
                    lresultado.Text = "Error: Número inválido";
                }
            }
            catch (Exception ex)
            {
                lresultado.Text = $"Error: {ex.Message}";
            }
        }
    }
}
