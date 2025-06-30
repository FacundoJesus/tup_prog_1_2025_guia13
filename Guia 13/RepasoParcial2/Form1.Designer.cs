namespace RepasoParcial2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnMayores = new Button();
            btnVerListado = new Button();
            btnAgregarExpediente = new Button();
            groupBox2 = new GroupBox();
            btnVerExpedientes = new Button();
            tbDni = new TextBox();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnVerCausa = new Button();
            tbNroCausa = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMayores);
            groupBox1.Controls.Add(btnVerListado);
            groupBox1.Controls.Add(btnAgregarExpediente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expedientes";
            // 
            // btnMayores
            // 
            btnMayores.Location = new Point(226, 31);
            btnMayores.Name = "btnMayores";
            btnMayores.Size = new Size(88, 42);
            btnMayores.TabIndex = 2;
            btnMayores.Text = "Ver Mayores en Monto";
            btnMayores.UseVisualStyleBackColor = true;
            btnMayores.Click += btnMayores_Click;
            // 
            // btnVerListado
            // 
            btnVerListado.Location = new Point(127, 31);
            btnVerListado.Name = "btnVerListado";
            btnVerListado.Size = new Size(75, 42);
            btnVerListado.TabIndex = 1;
            btnVerListado.Text = "Ver Todos";
            btnVerListado.UseVisualStyleBackColor = true;
            btnVerListado.Click += btnVerListado_Click;
            // 
            // btnAgregarExpediente
            // 
            btnAgregarExpediente.Location = new Point(25, 31);
            btnAgregarExpediente.Name = "btnAgregarExpediente";
            btnAgregarExpediente.Size = new Size(75, 42);
            btnAgregarExpediente.TabIndex = 0;
            btnAgregarExpediente.Text = "Registrar Nuevo";
            btnAgregarExpediente.UseVisualStyleBackColor = true;
            btnAgregarExpediente.Click += btnAgregarExpediente_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnVerExpedientes);
            groupBox2.Controls.Add(tbDni);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ver Expediente de una persona";
            // 
            // btnVerExpedientes
            // 
            btnVerExpedientes.Location = new Point(226, 32);
            btnVerExpedientes.Name = "btnVerExpedientes";
            btnVerExpedientes.Size = new Size(88, 42);
            btnVerExpedientes.TabIndex = 3;
            btnVerExpedientes.Text = "Ver Expedientes";
            btnVerExpedientes.UseVisualStyleBackColor = true;
            btnVerExpedientes.Click += btnVerExpedientes_Click;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(61, 43);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(121, 23);
            tbDni.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 46);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "DNI:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnVerCausa);
            groupBox3.Controls.Add(tbNroCausa);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(341, 100);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ver Expediente de una persona";
            // 
            // btnVerCausa
            // 
            btnVerCausa.Location = new Point(226, 32);
            btnVerCausa.Name = "btnVerCausa";
            btnVerCausa.Size = new Size(88, 42);
            btnVerCausa.TabIndex = 3;
            btnVerCausa.Text = "Ver Causa";
            btnVerCausa.UseVisualStyleBackColor = true;
            btnVerCausa.Click += btnVerCausa_Click;
            // 
            // tbNroCausa
            // 
            tbNroCausa.Location = new Point(61, 50);
            tbNroCausa.Name = "tbNroCausa";
            tbNroCausa.Size = new Size(121, 23);
            tbNroCausa.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 32);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Número de Causa:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 341);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parcial 2";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMayores;
        private Button btnVerListado;
        private Button btnAgregarExpediente;
        private GroupBox groupBox2;
        private Button btnVerExpedientes;
        private TextBox tbDni;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnVerCausa;
        private TextBox tbNroCausa;
        private Label label2;
    }
}
