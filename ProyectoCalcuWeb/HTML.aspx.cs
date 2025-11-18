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

        // MÉTODOS PARA NÚMEROS (se mantienen igual)
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

        // BOTÓN CLEAR
        protected void bclear_Click(object sender, EventArgs e)
        {
            lresultado.Text = "0";
            clsOperacion.ResetOperaciones();
        }

        // OPERACIONES BINARIAS - Versión simplificada usando la clase
        protected void bsuma_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor1))
            {
                clsOperacion.valor1 = valor1;
                clsOperacion.ResetOperaciones();
                clsOperacion.sumar = true;
                lresultado.Text = "0";
            }
        }

        protected void bresta_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor1))
            {
                clsOperacion.valor1 = valor1;
                clsOperacion.ResetOperaciones();
                clsOperacion.restar = true;
                lresultado.Text = "0";
            }
        }

        protected void bmultiply_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor1))
            {
                clsOperacion.valor1 = valor1;
                clsOperacion.ResetOperaciones();
                clsOperacion.multiplicar = true;
                lresultado.Text = "0";
            }
        }

        protected void bdivide_Click(object sender, EventArgs e)
        {
            if (float.TryParse(lresultado.Text, out float valor1))
            {
                clsOperacion.valor1 = valor1;
                clsOperacion.ResetOperaciones();
                clsOperacion.dividir = true;
                lresultado.Text = "0";
            }
        }

        // BOTÓN DE RESULTADO - Ahora usa el método unificado de la clase
        protected void bresultado_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.TryParse(lresultado.Text, out float valor2))
                {
                    clsOperacion.valor2 = valor2;
                    float resultado = clsOperacion.EjecutarOperacionBinaria();
                    lresultado.Text = resultado.ToString();
                    clsOperacion.ResetOperaciones();
                }
            }
            catch (Exception ex)
            {
                lresultado.Text = $"Error: {ex.Message}";
                clsOperacion.ResetOperaciones();
            }
        }

        // BOTÓN DECIMAL
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

        // OPERACIONES UNITARIAS - Todas llaman a los métodos de la clase
        protected void Button1_Click(object sender, EventArgs e) // Factorial
        {
            try
            {
                if (float.TryParse(lresultado.Text, out float valor))
                {
                    long resultado = clsOperacion.metodo_factorial(valor);
                    lresultado.Text = resultado.ToString();
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
                if (float.TryParse(lresultado.Text, out float valor))
                {
                    float resultado = clsOperacion.metodo_raizCuadrada(valor);
                    lresultado.Text = resultado.ToString("F6").TrimEnd('0').TrimEnd('.');
                }
            }
            catch (Exception ex)
            {
                lresultado.Text = $"Error: {ex.Message}";
            }
        }

        protected void Button2_Click(object sender, EventArgs e) // Fibonacci
        {
            try
            {
                if (float.TryParse(lresultado.Text, out float valor))
                {
                    long resultado = clsOperacion.metodo_fibonacci(valor);
                    lresultado.Text = resultado.ToString();
                }
            }
            catch (Exception ex)
            {
                lresultado.Text = $"Error: {ex.Message}";
            }
        }
    }
}