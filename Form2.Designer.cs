namespace Tarea_ARC
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.calculateParityButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.simulateErrorButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.Panel();
            this.btnHamming = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPariedad = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMetodos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Location = new System.Drawing.Point(270, 42);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(191, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // calculateParityButton
            // 
            this.calculateParityButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calculateParityButton.FlatAppearance.BorderSize = 2;
            this.calculateParityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateParityButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateParityButton.ForeColor = System.Drawing.Color.White;
            this.calculateParityButton.Location = new System.Drawing.Point(270, 68);
            this.calculateParityButton.Name = "calculateParityButton";
            this.calculateParityButton.Size = new System.Drawing.Size(191, 30);
            this.calculateParityButton.TabIndex = 2;
            this.calculateParityButton.Text = "Calcular";
            this.calculateParityButton.UseVisualStyleBackColor = true;
            this.calculateParityButton.Click += new System.EventHandler(this.calculateParityButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Location = new System.Drawing.Point(270, 134);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(191, 20);
            this.outputTextBox.TabIndex = 3;
            // 
            // simulateErrorButton
            // 
            this.simulateErrorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.simulateErrorButton.FlatAppearance.BorderSize = 2;
            this.simulateErrorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simulateErrorButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulateErrorButton.ForeColor = System.Drawing.Color.White;
            this.simulateErrorButton.Location = new System.Drawing.Point(270, 160);
            this.simulateErrorButton.Name = "simulateErrorButton";
            this.simulateErrorButton.Size = new System.Drawing.Size(191, 29);
            this.simulateErrorButton.TabIndex = 5;
            this.simulateErrorButton.Text = "Simular Error";
            this.simulateErrorButton.UseVisualStyleBackColor = true;
            this.simulateErrorButton.Click += new System.EventHandler(this.simulateErrorButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Opciones);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.btnMetodos);
            this.groupBox1.Controls.Add(this.inputTextBox);
            this.groupBox1.Controls.Add(this.calculateParityButton);
            this.groupBox1.Controls.Add(this.outputTextBox);
            this.groupBox1.Controls.Add(this.simulateErrorButton);
            this.groupBox1.Location = new System.Drawing.Point(36, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 283);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resultLabel.Location = new System.Drawing.Point(133, 237);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(84, 18);
            this.resultLabel.TabIndex = 19;
            this.resultLabel.Text = "respuesta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(132, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Resultado de la Corrección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datos con paridad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingrese los datos originales (0s y 1s): ";
            // 
            // Opciones
            // 
            this.Opciones.Controls.Add(this.btnHamming);
            this.Opciones.Controls.Add(this.panel3);
            this.Opciones.Controls.Add(this.btnPariedad);
            this.Opciones.Controls.Add(this.panel2);
            this.Opciones.Location = new System.Drawing.Point(19, 77);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(188, 116);
            this.Opciones.TabIndex = 15;
            this.Opciones.Visible = false;
            // 
            // btnHamming
            // 
            this.btnHamming.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHamming.FlatAppearance.BorderSize = 2;
            this.btnHamming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamming.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHamming.ForeColor = System.Drawing.Color.White;
            this.btnHamming.Location = new System.Drawing.Point(28, 57);
            this.btnHamming.Name = "btnHamming";
            this.btnHamming.Size = new System.Drawing.Size(135, 45);
            this.btnHamming.TabIndex = 8;
            this.btnHamming.Text = "Hamming";
            this.btnHamming.UseVisualStyleBackColor = true;
            this.btnHamming.Click += new System.EventHandler(this.btnHamming_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(19, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 45);
            this.panel3.TabIndex = 11;
            // 
            // btnPariedad
            // 
            this.btnPariedad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPariedad.FlatAppearance.BorderSize = 2;
            this.btnPariedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPariedad.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPariedad.ForeColor = System.Drawing.Color.White;
            this.btnPariedad.Location = new System.Drawing.Point(28, 6);
            this.btnPariedad.Name = "btnPariedad";
            this.btnPariedad.Size = new System.Drawing.Size(135, 45);
            this.btnPariedad.TabIndex = 8;
            this.btnPariedad.Text = "Pariedad";
            this.btnPariedad.UseVisualStyleBackColor = true;
            this.btnPariedad.Click += new System.EventHandler(this.btnPariedad_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(19, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 45);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(38, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 46);
            this.panel4.TabIndex = 14;
            // 
            // btnMetodos
            // 
            this.btnMetodos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMetodos.FlatAppearance.BorderSize = 2;
            this.btnMetodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetodos.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodos.ForeColor = System.Drawing.Color.White;
            this.btnMetodos.Location = new System.Drawing.Point(44, 26);
            this.btnMetodos.Name = "btnMetodos";
            this.btnMetodos.Size = new System.Drawing.Size(138, 45);
            this.btnMetodos.TabIndex = 13;
            this.btnMetodos.Text = "Metodos";
            this.btnMetodos.UseVisualStyleBackColor = true;
            this.btnMetodos.Click += new System.EventHandler(this.btnMetodos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(60, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(515, 32);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Simulación de Correción de Errores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 68);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(609, 440);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button calculateParityButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button simulateErrorButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Opciones;
        private System.Windows.Forms.Button btnHamming;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPariedad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMetodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}