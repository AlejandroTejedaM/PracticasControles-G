namespace AppInventario
{
    partial class frmSeleccionar
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
            lblName = new Label();
            lblStock = new Label();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            txtCantidadCompraProd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPrecio = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(68, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(91, 78);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 1;
            lblStock.Text = "Stock:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(156, 78);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 3;
            // 
            // txtCantidadCompraProd
            // 
            txtCantidadCompraProd.Location = new Point(156, 206);
            txtCantidadCompraProd.Name = "txtCantidadCompraProd";
            txtCantidadCompraProd.Size = new Size(150, 31);
            txtCantidadCompraProd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 209);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 5;
            label1.Text = "Comprar (QTY)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 6;
            label2.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(156, 133);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(150, 31);
            txtPrecio.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(174, 273);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmSeleccionar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 359);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCantidadCompraProd);
            Controls.Add(txtStock);
            Controls.Add(txtNombre);
            Controls.Add(lblStock);
            Controls.Add(lblName);
            Name = "frmSeleccionar";
            Text = "frmSeleccionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblStock;
        private TextBox txtNombre;
        private TextBox txtStock;
        private TextBox txtCantidadCompraProd;
        private Label label1;
        private Label label2;
        private TextBox txtPrecio;
        private Button button1;
    }
}