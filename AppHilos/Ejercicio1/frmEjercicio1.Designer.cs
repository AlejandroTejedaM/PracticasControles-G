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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pelota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Barra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Pelota
            // 
            Pelota.BackColor = Color.Black;
            Pelota.BorderStyle = BorderStyle.Fixed3D;
            Pelota.Location = new Point(271, 359);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.Location = new Point(42, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 36);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.IndianRed;
            pictureBox2.Location = new Point(212, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 36);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.IndianRed;
            pictureBox3.Location = new Point(408, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 36);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.IndianRed;
            pictureBox4.Location = new Point(598, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 36);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // frmEjercicio1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 547);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Barra);
            Controls.Add(Pelota);
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmEjercicio1";
            Text = "frmEjercicio1";
            FormClosing += frmEjercicio1_FormClosing;
            KeyDown += frmEjercicio1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Pelota).EndInit();
            ((System.ComponentModel.ISupportInitialize)Barra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Pelota;
        private PictureBox Barra;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}