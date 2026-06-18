namespace Maquina_Expendedora
{
    partial class FrmExpendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpendedor));
            groupBox1 = new GroupBox();
            lblVuala = new Label();
            lblLeche = new Label();
            lblPay = new Label();
            lblPoki = new Label();
            picVuala = new PictureBox();
            picYomi = new PictureBox();
            picPay = new PictureBox();
            picPoki = new PictureBox();
            groupBox2 = new GroupBox();
            btnPagar = new Button();
            txtPago = new TextBox();
            label1 = new Label();
            lblTotal = new Label();
            lblCantidad = new Label();
            numericUpDown1 = new NumericUpDown();
            lblPrecio = new Label();
            lblProducto = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVuala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picYomi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPoki).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(lblVuala);
            groupBox1.Controls.Add(lblLeche);
            groupBox1.Controls.Add(lblPay);
            groupBox1.Controls.Add(lblPoki);
            groupBox1.Controls.Add(picVuala);
            groupBox1.Controls.Add(picYomi);
            groupBox1.Controls.Add(picPay);
            groupBox1.Controls.Add(picPoki);
            groupBox1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 548);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "   Productos Disponibles";
            // 
            // lblVuala
            // 
            lblVuala.AutoSize = true;
            lblVuala.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVuala.Location = new Point(247, 471);
            lblVuala.Name = "lblVuala";
            lblVuala.Size = new Size(90, 27);
            lblVuala.TabIndex = 6;
            lblVuala.Text = "Stock:";
            // 
            // lblLeche
            // 
            lblLeche.AutoSize = true;
            lblLeche.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeche.Location = new Point(45, 471);
            lblLeche.Name = "lblLeche";
            lblLeche.Size = new Size(90, 27);
            lblLeche.TabIndex = 5;
            lblLeche.Text = "Stock:";
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPay.Location = new Point(247, 253);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(90, 27);
            lblPay.TabIndex = 5;
            lblPay.Text = "Stock:";
            // 
            // lblPoki
            // 
            lblPoki.AutoSize = true;
            lblPoki.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoki.Location = new Point(45, 253);
            lblPoki.Name = "lblPoki";
            lblPoki.Size = new Size(90, 27);
            lblPoki.TabIndex = 4;
            lblPoki.Text = "Stock:";
            // 
            // picVuala
            // 
            picVuala.Image = (Image)resources.GetObject("picVuala.Image");
            picVuala.Location = new Point(230, 325);
            picVuala.Name = "picVuala";
            picVuala.Size = new Size(202, 143);
            picVuala.SizeMode = PictureBoxSizeMode.StretchImage;
            picVuala.TabIndex = 3;
            picVuala.TabStop = false;
            picVuala.Click += picVuala_Click;
            // 
            // picYomi
            // 
            picYomi.Image = (Image)resources.GetObject("picYomi.Image");
            picYomi.Location = new Point(47, 325);
            picYomi.Name = "picYomi";
            picYomi.Size = new Size(151, 143);
            picYomi.SizeMode = PictureBoxSizeMode.StretchImage;
            picYomi.TabIndex = 2;
            picYomi.TabStop = false;
            picYomi.Click += picYomi_Click_1;
            // 
            // picPay
            // 
            picPay.Image = (Image)resources.GetObject("picPay.Image");
            picPay.Location = new Point(247, 102);
            picPay.Name = "picPay";
            picPay.Size = new Size(151, 143);
            picPay.SizeMode = PictureBoxSizeMode.StretchImage;
            picPay.TabIndex = 1;
            picPay.TabStop = false;
            picPay.Click += picPay_Click_1;
            // 
            // picPoki
            // 
            picPoki.ErrorImage = (Image)resources.GetObject("picPoki.ErrorImage");
            picPoki.Image = (Image)resources.GetObject("picPoki.Image");
            picPoki.Location = new Point(47, 102);
            picPoki.Name = "picPoki";
            picPoki.Size = new Size(151, 143);
            picPoki.SizeMode = PictureBoxSizeMode.StretchImage;
            picPoki.TabIndex = 0;
            picPoki.TabStop = false;
            picPoki.Click += picPoki_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(btnPagar);
            groupBox2.Controls.Add(txtPago);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(lblCantidad);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(lblPrecio);
            groupBox2.Controls.Add(lblProducto);
            groupBox2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(459, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 548);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "     Realizar Compra";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.LightSalmon;
            btnPagar.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(170, 471);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(145, 51);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "Comprar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(19, 372);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(220, 39);
            txtPago.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 342);
            label1.Name = "label1";
            label1.Size = new Size(220, 27);
            label1.TabIndex = 6;
            label1.Text = "Ingrese el pago:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(19, 273);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(194, 27);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total a Pagar:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(19, 181);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(246, 27);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Elija la Cantidad:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(19, 211);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(233, 39);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(19, 118);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(103, 27);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(19, 73);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(129, 27);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Thistle;
            groupBox3.ForeColor = Color.Thistle;
            groupBox3.Location = new Point(1, -2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(908, 79);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // FrmExpendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 626);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmExpendedor";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVuala).EndInit();
            ((System.ComponentModel.ISupportInitialize)picYomi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPay).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPoki).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private Label lblPrecio;
        private Label lblProducto;
        private GroupBox groupBox3;
        private PictureBox picPoki;
        private PictureBox picVuala;
        private PictureBox picYomi;
        private PictureBox picPay;
        private Label lblVuala;
        private Label lblLeche;
        private Label lblPay;
        private Label lblPoki;
        private Label lblCantidad;
        private Label label1;
        private Label lblTotal;
        private Button btnPagar;
        private TextBox txtPago;
    }
}
