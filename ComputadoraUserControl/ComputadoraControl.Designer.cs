namespace ComputadoraUserControl
{
    partial class ComputadoraControl
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
            components = new System.ComponentModel.Container();
            pbPC = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtInicio = new TextBox();
            label2 = new Label();
            txtFin = new TextBox();
            label3 = new Label();
            txtCosto = new TextBox();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pbTiempo = new ProgressBar();
            label5 = new Label();
            txtTiempoExtra = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPC).BeginInit();
            SuspendLayout();
            // 
            // pbPC
            // 
            pbPC.BorderStyle = BorderStyle.Fixed3D;
            pbPC.Location = new Point(16, 17);
            pbPC.Margin = new Padding(4, 3, 4, 3);
            pbPC.Name = "pbPC";
            pbPC.Size = new Size(210, 174);
            pbPC.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPC.TabIndex = 0;
            pbPC.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 203);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(16, 233);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(210, 31);
            txtUsuario.TabIndex = 2;
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(16, 298);
            txtInicio.Margin = new Padding(4, 3, 4, 3);
            txtInicio.Name = "txtInicio";
            txtInicio.ReadOnly = true;
            txtInicio.Size = new Size(210, 31);
            txtInicio.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 270);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "Inicio";
            // 
            // txtFin
            // 
            txtFin.Location = new Point(16, 365);
            txtFin.Margin = new Padding(4, 3, 4, 3);
            txtFin.Name = "txtFin";
            txtFin.ReadOnly = true;
            txtFin.Size = new Size(210, 31);
            txtFin.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 337);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 25);
            label3.TabIndex = 5;
            label3.Text = "Fin";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(16, 432);
            txtCosto.Margin = new Padding(4, 3, 4, 3);
            txtCosto.Name = "txtCosto";
            txtCosto.ReadOnly = true;
            txtCosto.Size = new Size(210, 31);
            txtCosto.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 403);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 7;
            label4.Text = "Costo";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // pbTiempo
            // 
            pbTiempo.Location = new Point(16, 578);
            pbTiempo.Margin = new Padding(4, 3, 4, 3);
            pbTiempo.Name = "pbTiempo";
            pbTiempo.Size = new Size(210, 37);
            pbTiempo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 481);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(226, 25);
            label5.TabIndex = 10;
            label5.Text = "Incrementar Tiempo del PC";
            // 
            // txtTiempoExtra
            // 
            txtTiempoExtra.Location = new Point(43, 529);
            txtTiempoExtra.Margin = new Padding(4, 5, 4, 5);
            txtTiempoExtra.Name = "txtTiempoExtra";
            txtTiempoExtra.Size = new Size(155, 31);
            txtTiempoExtra.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(65, 634);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 12;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ComputadoraControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(button1);
            Controls.Add(txtTiempoExtra);
            Controls.Add(label5);
            Controls.Add(pbTiempo);
            Controls.Add(txtCosto);
            Controls.Add(label4);
            Controls.Add(txtFin);
            Controls.Add(label3);
            Controls.Add(txtInicio);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pbPC);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ComputadoraControl";
            Size = new Size(241, 692);
            Load += ComputadoraControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbPC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbPC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public System.Windows.Forms.Timer timer1;
        public TextBox txtUsuario;
        public TextBox txtInicio;
        public TextBox txtFin;
        public TextBox txtCosto;
        private ProgressBar pbTiempo;
        private Label label5;
        private TextBox txtTiempoExtra;
        private Button button1;
    }
}