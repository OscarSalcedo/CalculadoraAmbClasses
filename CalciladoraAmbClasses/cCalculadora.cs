using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalciladoraAmbClasses
{
    class cCalculadora
    {

        private static int Max_Mida_Pantalla = 17;

        public static void ComprovarIMostrarNumeros(Label lblPantalla, object sender)
        {
            //Si surt error, la pantalla queda bloquejada fins que s'esborri tot
            if (lblPantalla.Text != "Error")
            {
                if (lblPantalla.Text == "0")
                {
                    lblPantalla.Text = ((Button)sender).Text;
                }
                else
                {
                    if (lblPantalla.Text.Length < Max_Mida_Pantalla)
                    {
                        lblPantalla.Text = lblPantalla.Text + ((Button)sender).Text;
                    }
                }
            }
        }

        public static Double agafarOperand(Label lblPantalla, object sender)
        {
            Double Operand;
            Operand = Double.Parse(lblPantalla.Text);
            return Operand;
        }

        public static void mostrarOperand1(Label lblPantallaSeguiment, double operand1)
        {
            lblPantallaSeguiment.Text = operand1.ToString();
        }

        public static String agafarOperador(object sender)
        {
            String Operador;

            Operador = ((Button)sender).Text;

            return Operador;

        }

        public static void mostrarOperador(Label lblPantallaSeguiment, String Operador)
        {
            
            lblPantallaSeguiment.Text += Operador;
        }

        public static Double ferOperacio(Double Operand1, Double Operand2, String Operador)
        {
            Double Resultat=0;
            switch (Operador)
            {
                case "+":
                    Resultat = Operand1 + Operand2;
                    break;
                case "-":
                    Resultat = Operand1 - Operand2;
                    break;
                case "*":
                    Resultat = Operand1 * Operand2;
                    break;
                case "/":

                    if (Operand2 == 0) // controlem la divisió per 0
                    {
                        throw new Exception();
                    }
                    else
                    {
                        Resultat = Operand1 / Operand2;
                    }
                    break;
            }

            return Resultat;
        }

        public static void mostrarResultat(Label lblPantalla, Double Resultat)
        {
            lblPantalla.Text = Resultat.ToString();
        }




    }
}
