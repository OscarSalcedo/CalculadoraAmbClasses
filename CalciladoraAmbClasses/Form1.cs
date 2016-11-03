using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalciladoraAmbClasses
{
    public partial class Form1 : Form
    {

        private double Operand1;
        private double Operand2;
        private double Resultat;
        private String Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonsNumeros_MouseUp(object sender, MouseEventArgs e)
        {
            cCalculadora.ComprovarIMostrarNumeros(lblPantalla, sender);
            KeyPreview = true;
        }

        private void ButtonsOperacions_MouseUp(object sender, MouseEventArgs e)
        {

            Operand1 = cCalculadora.agafarOperand(lblPantalla, sender);
            Operador = cCalculadora.agafarOperador(sender);
            cCalculadora.mostrarOperand1(lblPantallaSeguiment,Operand1);
            cCalculadora.mostrarOperador(lblPantallaSeguiment, Operador);

            lblPantalla.Text = "";
        }

        private void btnIgual_MouseUp(object sender, MouseEventArgs e)
        {
            Operand2 = cCalculadora.agafarOperand(lblPantalla, sender);
            try
            {
                Resultat = cCalculadora.ferOperacio(Operand1, Operand2, Operador);
                cCalculadora.mostrarResultat(lblPantalla, Resultat);
                lblPantallaSeguiment.Text = "";
            }
            catch
            {
                lblPantalla.Text = "Error";
            }

        }

        //
    }
}
