namespace Calculadora.UI
{
    partial class UIHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            btnDeriv = new RadioButton();
            btnLimits = new RadioButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(btnDeriv);
            panel1.Controls.Add(btnLimits);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(20, 20, 1, 1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 20, 0, 30);
            panel1.Size = new Size(160, 469);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Dock = DockStyle.Top;
            radioButton3.Location = new Point(10, 68);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(150, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnDeriv
            // 
            btnDeriv.AutoSize = true;
            btnDeriv.Dock = DockStyle.Top;
            btnDeriv.Location = new Point(10, 44);
            btnDeriv.Name = "btnDeriv";
            btnDeriv.Size = new Size(150, 24);
            btnDeriv.TabIndex = 1;
            btnDeriv.TabStop = true;
            btnDeriv.Text = "Derivadas";
            btnDeriv.UseVisualStyleBackColor = true;
            // 
            // btnLimits
            // 
            btnLimits.AutoSize = true;
            btnLimits.Dock = DockStyle.Top;
            btnLimits.Location = new Point(10, 20);
            btnLimits.Name = "btnLimits";
            btnLimits.Size = new Size(150, 24);
            btnLimits.TabIndex = 0;
            btnLimits.TabStop = true;
            btnLimits.Text = "Limites";
            btnLimits.UseVisualStyleBackColor = true;
            btnLimits.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.Location = new Point(160, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // UIHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(823, 469);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UIHome";
            Text = "UIHome";
            Load += UIHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton btnDeriv;
        private RadioButton btnLimits;
        private Panel panel2;
    }
}