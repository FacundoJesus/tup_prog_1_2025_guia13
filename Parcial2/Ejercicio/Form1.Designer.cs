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
            listBoxPatentes = new ListBox();
            label1 = new Label();
            labelKM = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 42);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCargarViaje
            // 
            btnCargarViaje.Location = new Point(12, 75);
            btnCargarViaje.Name = "btnCargarViaje";
            btnCargarViaje.Size = new Size(75, 42);
            btnCargarViaje.TabIndex = 1;
            btnCargarViaje.Text = "Cargar Viaje";
            btnCargarViaje.UseVisualStyleBackColor = true;
            btnCargarViaje.Click += btnCargarViaje_Click;
            // 
            // btnResumenFinal
            // 
            btnResumenFinal.Location = new Point(12, 133);
            btnResumenFinal.Name = "btnResumenFinal";
            btnResumenFinal.Size = new Size(75, 42);
            btnResumenFinal.TabIndex = 2;
            btnResumenFinal.Text = "Resumen Final";
            btnResumenFinal.UseVisualStyleBackColor = true;
            btnResumenFinal.Click += btnResumenFinal_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 192);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 42);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listBoxPatentes
            // 
            listBoxPatentes.FormattingEnabled = true;
            listBoxPatentes.ItemHeight = 15;
            listBoxPatentes.Location = new Point(108, 12);
            listBoxPatentes.Name = "listBoxPatentes";
            listBoxPatentes.Size = new Size(223, 184);
            listBoxPatentes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 219);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "Km a Cobrar:";
            // 
            // labelKM
            // 
            labelKM.AutoSize = true;
            labelKM.Location = new Point(273, 219);
            labelKM.Name = "labelKM";
            labelKM.Size = new Size(12, 15);
            labelKM.TabIndex = 6;
            labelKM.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 250);
            Controls.Add(labelKM);
            Controls.Add(label1);
            Controls.Add(listBoxPatentes);
            Controls.Add(btnSalir);
            Controls.Add(btnResumenFinal);
            Controls.Add(btnCargarViaje);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCargarViaje;
        private Button btnResumenFinal;
        private Button btnSalir;
        private ListBox listBoxPatentes;
        private Label label1;
        private Label labelKM;
    }
}
