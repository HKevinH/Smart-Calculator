namespace Calculadora.UI
{
    partial class UIDesingLimits
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            limtContinue = new RadioButton();
            limCondition = new RadioButton();
            limRac = new RadioButton();
            textFunction = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(textFunction);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 432);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 307);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 125);
            panel3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(219, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(limtContinue);
            panel1.Controls.Add(limCondition);
            panel1.Controls.Add(limRac);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 77);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 40, 0, 0);
            panel1.Size = new Size(219, 125);
            panel1.TabIndex = 4;
            // 
            // limtContinue
            // 
            limtContinue.AutoSize = true;
            limtContinue.Dock = DockStyle.Top;
            limtContinue.Location = new Point(0, 82);
            limtContinue.Name = "limtContinue";
            limtContinue.Size = new Size(219, 21);
            limtContinue.TabIndex = 2;
            limtContinue.TabStop = true;
            limtContinue.Text = "Continuidad";
            limtContinue.UseVisualStyleBackColor = true;
            // 
            // limCondition
            // 
            limCondition.AutoSize = true;
            limCondition.Dock = DockStyle.Top;
            limCondition.Location = new Point(0, 61);
            limCondition.Name = "limCondition";
            limCondition.Size = new Size(219, 21);
            limCondition.TabIndex = 1;
            limCondition.TabStop = true;
            limCondition.Text = "Limites A Trozos";
            limCondition.UseVisualStyleBackColor = true;
            // 
            // limRac
            // 
            limRac.AutoSize = true;
            limRac.Dock = DockStyle.Top;
            limRac.Location = new Point(0, 40);
            limRac.Name = "limRac";
            limRac.Size = new Size(219, 21);
            limRac.TabIndex = 0;
            limRac.TabStop = true;
            limRac.Text = "Limites Racionales";
            limRac.UseVisualStyleBackColor = true;
            // 
            // textFunction
            // 
            textFunction.Dock = DockStyle.Top;
            textFunction.Location = new Point(0, 52);
            textFunction.Name = "textFunction";
            textFunction.Size = new Size(219, 25);
            textFunction.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 15, 0, 20);
            label1.Size = new Size(207, 52);
            label1.TabIndex = 0;
            label1.Text = "Introduce La Funcion";
            // 
            // UIDesingLimits
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            Controls.Add(panel2);
            Name = "UIDesingLimits";
            Size = new Size(820, 432);
            Load += UIDesingLimits_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Panel panel2;
        public Label label1;
        public TextBox textFunction;
        public Panel panel1;
        public Panel panel3;
        public RadioButton limtContinue;
        public RadioButton limCondition;
        public RadioButton limRac;
        public Button button1;
    }
}
