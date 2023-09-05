namespace Tarea_ARC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.binaryOutputLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija la accion que desea realizar:\r\n";
            // 
            // dataTypeComboBox
            // 
            this.dataTypeComboBox.AllowDrop = true;
            this.dataTypeComboBox.BackColor = System.Drawing.Color.White;
            this.dataTypeComboBox.Location = new System.Drawing.Point(77, 210);
            this.dataTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataTypeComboBox.Name = "dataTypeComboBox";
            this.dataTypeComboBox.Size = new System.Drawing.Size(299, 24);
            this.dataTypeComboBox.TabIndex = 1;
            this.dataTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.dataTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el Dato:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.BackColor = System.Drawing.Color.White;
            this.valueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueTextBox.Location = new System.Drawing.Point(77, 298);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(299, 22);
            this.valueTextBox.TabIndex = 3;
            this.valueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valueTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "La respuesta es:";
            // 
            // binaryOutputLabel
            // 
            this.binaryOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binaryOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binaryOutputLabel.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryOutputLabel.ForeColor = System.Drawing.Color.White;
            this.binaryOutputLabel.Location = new System.Drawing.Point(4, 425);
            this.binaryOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.binaryOutputLabel.Name = "binaryOutputLabel";
            this.binaryOutputLabel.Size = new System.Drawing.Size(442, 52);
            this.binaryOutputLabel.TabIndex = 5;
            this.binaryOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.convertButton.FlatAppearance.BorderSize = 2;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(133, 342);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(168, 38);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convertir";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(31, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(369, 40);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Conversor a Binario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.convertButton);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.binaryOutputLabel);
            this.panel1.Controls.Add(this.dataTypeComboBox);
            this.panel1.Controls.Add(this.valueTextBox);
            this.panel1.Location = new System.Drawing.Point(185, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 490);
            this.panel1.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblError.Location = new System.Drawing.Point(77, 319);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(50, 19);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "label4";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(803, 559);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dataTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label binaryOutputLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblError;
    }
}

