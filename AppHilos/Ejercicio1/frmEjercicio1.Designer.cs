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
            Cubito1 = new PictureBox();
            Cubito2 = new PictureBox();
            Cubito3 = new PictureBox();
            Cubito4 = new PictureBox();
            label1 = new Label();
            txtPuntaje = new Label();
            ((System.ComponentModel.ISupportInitialize)Pelota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Barra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cubito1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cubito2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cubito3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cubito4).BeginInit();
            SuspendLayout();
            // 
            // Pelota
            // 
            Pelota.BackColor = Color.Black;
            Pelota.BorderStyle = BorderStyle.Fixed3D;
            Pelota.Location = new Point(353, 113);
            Pelota.Margin = new Padding(2, 3, 2, 3);
            Pelota.Name = "Pelota";
            Pelota.Size = new Size(35, 35);
            Pelota.TabIndex = 0;
            Pelota.TabStop = false;
            // 
            // Barra
            // 
            Barra.BackColor = SystemColors.ControlDarkDark;
            Barra.BackgroundImageLayout = ImageLayout.Stretch;
            Barra.BorderStyle = BorderStyle.Fixed3D;
            Barra.Location = new Point(302, 457);
            Barra.Margin = new Padding(2, 3, 2, 3);
            Barra.Name = "Barra";
            Barra.Size = new Size(111, 25);
            Barra.TabIndex = 1;
            Barra.TabStop = false;
            // 
            // Cubito1
            // 
            Cubito1.BackColor = Color.IndianRed;
            Cubito1.Location = new Point(42, 32);
            Cubito1.Name = "Cubito1";
            Cubito1.Size = new Size(125, 36);
            Cubito1.TabIndex = 2;
            Cubito1.TabStop = false;
            // 
            // Cubito2
            // 
            Cubito2.BackColor = Color.IndianRed;
            Cubito2.Location = new Point(213, 32);
            Cubito2.Name = "Cubito2";
            Cubito2.Size = new Size(125, 36);
            Cubito2.TabIndex = 3;
            Cubito2.TabStop = false;
            // 
            // Cubito3
            // 
            Cubito3.BackColor = Color.IndianRed;
            Cubito3.Location = new Point(408, 32);
            Cubito3.Name = "Cubito3";
            Cubito3.Size = new Size(125, 36);
            Cubito3.TabIndex = 4;
            Cubito3.TabStop = false;
            // 
            // Cubito4
            // 
            Cubito4.BackColor = Color.IndianRed;
            Cubito4.Location = new Point(598, 32);
            Cubito4.Name = "Cubito4";
            Cubito4.Size = new Size(125, 36);
            Cubito4.TabIndex = 5;
            Cubito4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 515);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 6;
            label1.Text = "Puntaje:";
            // 
            // txtPuntaje
            // 
            txtPuntaje.AutoSize = true;
            txtPuntaje.Location = new Point(632, 516);
            txtPuntaje.Name = "txtPuntaje";
            txtPuntaje.Size = new Size(50, 20);
            txtPuntaje.TabIndex = 7;
            txtPuntaje.Text = "label2";
            // 
            // frmEjercicio1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 547);
            Controls.Add(txtPuntaje);
            Controls.Add(label1);
            Controls.Add(Cubito4);
            Controls.Add(Cubito3);
            Controls.Add(Cubito2);
            Controls.Add(Cubito1);
            Controls.Add(Barra);
            Controls.Add(Pelota);
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmEjercicio1";
            Text = "frmEjercicio1";
            FormClosing += frmEjercicio1_FormClosing;
            KeyDown += frmEjercicio1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Pelota).EndInit();
            ((System.ComponentModel.ISupportInitialize)Barra).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cubito1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cubito2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cubito3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cubito4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pelota;
        private PictureBox Barra;
        private PictureBox Cubito1;
        private PictureBox Cubito2;
        private PictureBox Cubito3;
        private PictureBox Cubito4;
        private Label label1;
        private Label txtPuntaje;
    }
}