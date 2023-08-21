using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
namespace Calculadora.UI
{
    public partial class UIDesingLimits : UserControl
    {
        private double valor = 0;
        private string expresson1 = "x+1", expresson2 = "x";
        public bool isEditing = false, addedLimit = false;
        public UIDesingLimits()
        {
            InitializeComponent();
        }

        private void GuardarExpresion(TextBox textboxExpresson, ref string expresion)
        {
            string nuevoValor = textboxExpresson.Text;

            // Verificar si el nuevo valor contiene paréntesis
            int indiceInicio = nuevoValor.IndexOf('(');
            int indiceFin = nuevoValor.LastIndexOf(')');

            if (indiceInicio != -1 && indiceFin != -1 && indiceFin > indiceInicio)
            {
                // Extraer el contenido entre paréntesis
                string contenidoEntreParentesis = nuevoValor.Substring(indiceInicio + 1, indiceFin - indiceInicio - 1);

                // Actualizar la variable 'expresion' con el contenido entre paréntesis
                expresion = contenidoEntreParentesis;

                //MessageBox.Show("Expresión actualizada con el contenido entre paréntesis.");
            }
            else
            {
                MessageBox.Show("No se encontraron paréntesis en el nuevo valor.");
            }
        }


        public void resolvingLimit(TextBox function)
        {
            if (!addedLimit)
            {
                string nuevocontenidoActual = $"lim x → {valor} ({expresson1})";
                function.Text = nuevocontenidoActual;

                // Establece el cursor al final del TextBox para permitir la edición
                function.SelectionStart = function.Text.Length;
                function.SelectionLength = 0;
                function.Focus();
                function.BackColor = Color.AntiqueWhite;
                addedLimit = true;
            }
            else
            {
                function.Clear();
                addedLimit = false;
            }
        }

        public void calculateLimit()
        {
            GuardarExpresion(textFunction, ref expresson1);
            //MessageBox.Show($"Expresiion 1 del límite: {expresson1}");

            NCalc.Expression expression = new NCalc.Expression(expresson1);
            expression.Parameters["x"] = valor;

            try
            {
                object result = expression.Evaluate();
                MessageBox.Show($"Resultado del límite: {result}");
            }
            catch (EvaluationException ex)
            {
                MessageBox.Show($"Error al evaluar la expresión: {ex.Message}");
            }
        }

        private void UIDesingLimits_Load(object sender, EventArgs e)
        {
            textFunction.Click += textFunction_DoubleClick;

            limRac.Checked = true;
        }

        private void textFunction_DoubleClick(object sender, EventArgs e)
        {
            if (!addedLimit)
                resolvingLimit(textFunction);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculateLimit();
        }
    }
}
