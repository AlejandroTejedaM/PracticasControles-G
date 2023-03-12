namespace AppInventario
{
    partial class frmActualizar
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
            button2 = new Button();
            label1 = new Label();
            txtStock = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            btnDStock = new Button();
            btnAStock = new Button();
            btnCNombre = new Button();
            pbImagenProducto = new PictureBox();
            btnCIMagen = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnDPrecio = new Button();
            btnAPrecio = new Button();
            label4 = new Label();
            lblNombreProducto = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagenProducto).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(163, 440);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 318);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 3;
            label1.Text = "STOCK:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(107, 318);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 382);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 5;
            label2.Text = "PRECIO:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 379);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 262);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 7;
            label3.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 259);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 31);
            txtNombre.TabIndex = 8;
            // 
            // btnDStock
            // 
            btnDStock.Image = Properties.Resources.FlechaRoja;
            btnDStock.Location = new Point(405, 314);
            btnDStock.Name = "btnDStock";
            btnDStock.Size = new Size(52, 38);
            btnDStock.TabIndex = 10;
            btnDStock.UseVisualStyleBackColor = true;
            btnDStock.Click += btnDStock_Click;
            // 
            // btnAStock
            // 
            btnAStock.Image = Properties.Resources.FlechaVerde;
            btnAStock.Location = new Point(347, 314);
            btnAStock.Name = "btnAStock";
            btnAStock.Size = new Size(52, 38);
            btnAStock.TabIndex = 9;
            btnAStock.UseVisualStyleBackColor = true;
            btnAStock.Click += button5_Click;
            // 
            // btnCNombre
            // 
            btnCNombre.Location = new Point(350, 256);
            btnCNombre.Name = "btnCNombre";
            btnCNombre.Size = new Size(112, 37);
            btnCNombre.TabIndex = 11;
            btnCNombre.Text = "CAMBIAR";
            btnCNombre.UseVisualStyleBackColor = true;
            btnCNombre.Click += btnCNombre_Click;
            // 
            // pbImagenProducto
            // 
            pbImagenProducto.Location = new Point(98, 98);
            pbImagenProducto.Name = "pbImagenProducto";
            pbImagenProducto.Size = new Size(152, 135);
            pbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenProducto.TabIndex = 12;
            pbImagenProducto.TabStop = false;
            // 
            // btnCIMagen
            // 
            btnCIMagen.Image = Properties.Resources.CambiarImagen1;
            btnCIMagen.Location = new Point(280, 98);
            btnCIMagen.Name = "btnCIMagen";
            btnCIMagen.Size = new Size(142, 136);
            btnCIMagen.TabIndex = 13;
            btnCIMagen.UseVisualStyleBackColor = true;
            btnCIMagen.Click += button7_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDPrecio
            // 
            btnDPrecio.Image = Properties.Resources.FlechaRoja;
            btnDPrecio.Location = new Point(405, 372);
            btnDPrecio.Name = "btnDPrecio";
            btnDPrecio.Size = new Size(52, 38);
            btnDPrecio.TabIndex = 15;
            btnDPrecio.UseVisualStyleBackColor = true;
            btnDPrecio.Click += btnDPrecio_Click;
            // 
            // btnAPrecio
            // 
            btnAPrecio.Image = Properties.Resources.FlechaVerde;
            btnAPrecio.Location = new Point(347, 372);
            btnAPrecio.Name = "btnAPrecio";
            btnAPrecio.Size = new Size(52, 38);
            btnAPrecio.TabIndex = 14;
            btnAPrecio.UseVisualStyleBackColor = true;
            btnAPrecio.Click += btnAPrecio_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 70);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 16;
            label4.Text = "Cambiar imagen";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProducto.Location = new Point(98, 24);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(133, 38);
            lblNombreProducto.TabIndex = 17;
            lblNombreProducto.Text = "LBLName";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(42, 351);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(74, 25);
            lblStock.TabIndex = 18;
            lblStock.Text = "lblStock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(38, 414);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 25);
            lblPrecio.TabIndex = 19;
            lblPrecio.Text = "lblPrecio";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Actualizar;
            button1.Location = new Point(280, 314);
            button1.Name = "button1";
            button1.Size = new Size(52, 38);
            button1.TabIndex = 20;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.Actualizar;
            button3.Location = new Point(280, 372);
            button3.Name = "button3";
            button3.Size = new Size(52, 38);
            button3.TabIndex = 21;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frmActualizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 518);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblNombreProducto);
            Controls.Add(label4);
            Controls.Add(btnDPrecio);
            Controls.Add(btnAPrecio);
            Controls.Add(btnCIMagen);
            Controls.Add(pbImagenProducto);
            Controls.Add(btnCNombre);
            Controls.Add(btnDStock);
            Controls.Add(btnAStock);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "frmActualizar";
            Text = "frmActualizar";
            Load += frmActualizar_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagenProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private TextBox txtStock;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtNombre;
        private Button btnDStock;
        private Button btnAStock;
        private Button btnCNombre;
        private PictureBox pbImagenProducto;
        private Button btnCIMagen;
        private OpenFileDialog openFileDialog1;
        private Button btnDPrecio;
        private Button btnAPrecio;
        private Label label4;
        private Label lblNombreProducto;
        private Label lblStock;
        private Label lblPrecio;
        private Button button1;
        private Button button3;
    }
}