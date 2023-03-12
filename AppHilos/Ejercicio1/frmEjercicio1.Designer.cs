namespace AppHilos.Ejercicio1
{
    partial class frmEjercicio1
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
            Pelota = new PictureBox();
            Barra = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pelota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Barra).BeginInit();
            SuspendLayout();
            // 
            // Pelota
            // 
            Pelota.BackColor = Color.Red;
            Pelota.Location = new Point(8, 7);
            Pelota.Margin = new Padding(2);
            Pelota.Name = "Pelota";
            Pelota.Size = new Size(31, 26);
            Pelota.TabIndex = 0;
            Pelota.TabStop = false;
            // 
            // Barra
            // 
            Barra.BackColor = Color.Orange;
            Barra.Location = new Point(272, 354);
            Barra.Margin = new Padding(2);
            Barra.Name = "Barra";
            Barra.Size = new Size(97, 19);
            Barra.TabIndex = 1;
            Barra.TabStop = false;
            // 
            // frmEjercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 410);
            Controls.Add(Barra);
            Controls.Add(Pelota);
            Margin = new Padding(2);
            Name = "frmEjercicio1";
            Text = "frmEjercicio1";
            FormClosing += frmEjercicio1_FormClosing;
            KeyDown += frmEjercicio1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Pelota).EndInit();
            ((System.ComponentModel.ISupportInitialize)Barra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Pelota;
        private PictureBox Barra;
    }
}