using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Calculadora.UI
{
    public partial class UIHome : Form
    {
        public UIHome()
        {
            InitializeComponent();
        }

        private void UIHome_Load(object sender, EventArgs e)
        {
            btnLimits.CheckedChanged += RadioButton_CheckedChanged;
            btnDeriv.CheckedChanged += RadioButton_CheckedChanged;
            modifyView();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modifyView();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void modifyView()
        {
            panel2.Controls.Clear();

            if (btnLimits.Checked)
            {
                panel2.Controls.Clear();
                UIDesingLimits uIDesingLimits = new UIDesingLimits();
                panel2.Dock = DockStyle.Fill;
                panel2.Controls.Add(uIDesingLimits);
            }
            else if (btnDeriv.Checked)
            {
                panel2.Controls.Clear();
                UIDesingDerivative uIDesingDerivative = new UIDesingDerivative();
                panel2.Dock = DockStyle.Fill;
                panel2.Controls.Add(uIDesingDerivative);
            }
        }
    }
}
