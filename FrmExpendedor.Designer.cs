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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 548);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos Disponible";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 250);
            label4.Name = "label4";
            label4.Size = new Size(315, 33);
            label4.TabIndex = 3;
            label4.Text = "Gomitas $25 Stock: 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 199);
            label3.Name = "label3";
            label3.Size = new Size(330, 33);
            label3.TabIndex = 2;
            label3.Text = "Barritas $18 Stock: 8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 146);
            label2.Name = "label2";
            label2.Size = new Size(420, 33);
            label2.TabIndex = 1;
            label2.Text = "Chocolate Nugs $15 Stock: 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 98);
            label1.Name = "label1";
            label1.Size = new Size(315, 33);
            label1.TabIndex = 0;
            label1.Text = "Doritos $20 Stock: 5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(496, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 548);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Realizar Compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 73);
            label5.Name = "label5";
            label5.Size = new Size(345, 33);
            label5.TabIndex = 0;
            label5.Text = "Selecciona el producto";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(338, 40);
            comboBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 189);
            label6.Name = "label6";
            label6.Size = new Size(345, 33);
            label6.TabIndex = 2;
            label6.Text = "Selecciona la cantidad";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(26, 232);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(338, 39);
            numericUpDown1.TabIndex = 3;
            // 
            // FrmExpendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 626);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmExpendedor";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
    }
}
