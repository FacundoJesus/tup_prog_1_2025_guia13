namespace RepasoParcial2
{
    partial class FormDatos
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNroCausa = new TextBox();
            tbDni = new TextBox();
            tbMonto = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbMonto);
            groupBox1.Controls.Add(tbDni);
            groupBox1.Controls.Add(tbNroCausa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 134);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expediente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 28);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Número de Causa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 63);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI Persona:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 97);
            label3.Name = "label3";
            label3.Size = new Size(171, 15);
            label3.TabIndex = 2;
            label3.Text = "Importe Por faltas cometidas $:";
            // 
            // tbNroCausa
            // 
            tbNroCausa.Location = new Point(187, 25);
            tbNroCausa.Name = "tbNroCausa";
            tbNroCausa.Size = new Size(100, 23);
            tbNroCausa.TabIndex = 3;
            tbNroCausa.TextChanged += tbNroCausa_TextChanged;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(187, 60);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(100, 23);
            tbDni.TabIndex = 4;
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(187, 94);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(100, 23);
            tbMonto.TabIndex = 5;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(72, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(189, 152);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 192);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FormDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDatos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox tbMonto;
        public TextBox tbDni;
        public TextBox tbNroCausa;
        private Button button1;
        private Button button2;
    }
}