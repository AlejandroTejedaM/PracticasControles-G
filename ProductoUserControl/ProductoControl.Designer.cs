using ProductoUserControl.Properties;

namespace ProductoUserControl
{
    partial class ProductoControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbProducto = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProducto).BeginInit();
            SuspendLayout();
            // 
            // pbProducto
            // 
            pbProducto.BorderStyle = BorderStyle.Fixed3D;
            pbProducto.Location = new Point(4, 4);
            pbProducto.Margin = new Padding(4);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(109, 108);
            pbProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProducto.TabIndex = 0;
            pbProducto.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 4);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 2;
            label2.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 3;
            label3.Text = "Precio";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(209, 4);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(223, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(209, 44);
            txtStock.Margin = new Padding(4);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(90, 31);
            txtStock.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(209, 84);
            txtPrecio.Margin = new Padding(4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(90, 31);
            txtPrecio.TabIndex = 6;
            // 
            // button1
            // 
            button1.Image = Resources.business_ordering_pencil_table_2333;
            button1.Location = new Point(308, 45);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(58, 56);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Resources.trash_bin_icon_icons_com_67981;
            button2.Location = new Point(372, 45);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(60, 56);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(440, 29);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(76, 56);
            button3.TabIndex = 9;
            button3.Text = "SELECT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ProductoControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbProducto);
            Margin = new Padding(4);
            Name = "ProductoControl";
            Size = new Size(520, 116);
            ((System.ComponentModel.ISupportInitialize)pbProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}