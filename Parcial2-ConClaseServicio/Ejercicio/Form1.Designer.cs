namespace Ejercicio
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
            btnRegistrar = new Button();
            btnCargarViaje = new Button();
            btnResumenFinal = new Button();
            btnSalir = new Button();
            lsbPatentes = new ListBox();
            label1 = new Label();
            lbKM = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 39);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCargarViaje
            // 
            btnCargarViaje.Location = new Point(12, 67);
            btnCargarViaje.Name = "btnCargarViaje";
            btnCargarViaje.Size = new Size(75, 39);
            btnCargarViaje.TabIndex = 1;
            btnCargarViaje.Text = "Cargar Viaje";
            btnCargarViaje.UseVisualStyleBackColor = true;
            btnCargarViaje.Click += btnCargarViaje_Click;
            // 
            // btnResumenFinal
            // 
            btnResumenFinal.Location = new Point(12, 121);
            btnResumenFinal.Name = "btnResumenFinal";
            btnResumenFinal.Size = new Size(75, 39);
            btnResumenFinal.TabIndex = 2;
            btnResumenFinal.Text = "Resumen Final";
            btnResumenFinal.UseVisualStyleBackColor = true;
            btnResumenFinal.Click += btnResumenFinal_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 176);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 39);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lsbPatentes
            // 
            lsbPatentes.FormattingEnabled = true;
            lsbPatentes.ItemHeight = 15;
            lsbPatentes.Location = new Point(110, 12);
            lsbPatentes.Name = "lsbPatentes";
            lsbPatentes.Size = new Size(153, 169);
            lsbPatentes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 200);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "Km a Cobrar:";
            // 
            // lbKM
            // 
            lbKM.AutoSize = true;
            lbKM.BackColor = SystemColors.ActiveCaption;
            lbKM.Location = new Point(219, 200);
            lbKM.Name = "lbKM";
            lbKM.Size = new Size(12, 15);
            lbKM.TabIndex = 6;
            lbKM.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 227);
            Controls.Add(lbKM);
            Controls.Add(label1);
            Controls.Add(lsbPatentes);
            Controls.Add(btnSalir);
            Controls.Add(btnResumenFinal);
            Controls.Add(btnCargarViaje);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCargarViaje;
        private Button btnResumenFinal;
        private Button btnSalir;
        private ListBox lsbPatentes;
        private Label label1;
        private Label lbKM;
    }
}
