namespace Ejercicio
{
    partial class Fresumen
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
            lsbPatentes = new ListBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lsbPatentes
            // 
            lsbPatentes.FormattingEnabled = true;
            lsbPatentes.ItemHeight = 15;
            lsbPatentes.Location = new Point(12, 12);
            lsbPatentes.Name = "lsbPatentes";
            lsbPatentes.Size = new Size(284, 124);
            lsbPatentes.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.OK;
            btnSalir.Location = new Point(110, 142);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Fresumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 174);
            Controls.Add(btnSalir);
            Controls.Add(lsbPatentes);
            Name = "Fresumen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Fresumen";
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalir;
        public ListBox lsbPatentes;
    }
}