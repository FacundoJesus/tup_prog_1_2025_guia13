namespace RepasoParcial2
{
    partial class FormVer
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
            lsbResultados = new ListBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lsbResultados
            // 
            lsbResultados.FormattingEnabled = true;
            lsbResultados.ItemHeight = 15;
            lsbResultados.Location = new Point(12, 12);
            lsbResultados.Name = "lsbResultados";
            lsbResultados.Size = new Size(370, 139);
            lsbResultados.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.DialogResult = DialogResult.OK;
            btnCerrar.Location = new Point(107, 157);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 192);
            Controls.Add(btnCerrar);
            Controls.Add(lsbResultados);
            Name = "FormVer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVer";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCerrar;
        public ListBox lsbResultados;
    }
}