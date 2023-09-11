namespace Tarea_ARC
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.detectErrorsButton = new System.Windows.Forms.Button();
            this.encodedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.corruptedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese datos de entrada (0s y 1s).";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(94, 31);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(200, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // detectErrorsButton
            // 
            this.detectErrorsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.detectErrorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detectErrorsButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectErrorsButton.ForeColor = System.Drawing.Color.White;
            this.detectErrorsButton.Location = new System.Drawing.Point(94, 57);
            this.detectErrorsButton.Name = "detectErrorsButton";
            this.detectErrorsButton.Size = new System.Drawing.Size(200, 36);
            this.detectErrorsButton.TabIndex = 2;
            this.detectErrorsButton.Text = "Detectar errores";
            this.detectErrorsButton.UseVisualStyleBackColor = true;
            this.detectErrorsButton.Click += new System.EventHandler(this.detectErrorsButton_Click);
            // 
            // encodedTextBox
            // 
            this.encodedTextBox.Location = new System.Drawing.Point(94, 128);
            this.encodedTextBox.Name = "encodedTextBox";
            this.encodedTextBox.ReadOnly = true;
            this.encodedTextBox.Size = new System.Drawing.Size(200, 20);
            this.encodedTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos codificados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultados de detección";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(63, 248);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(19, 19);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "=";
            // 
            // corruptedTextBox
            // 
            this.corruptedTextBox.Location = new System.Drawing.Point(94, 183);
            this.corruptedTextBox.Name = "corruptedTextBox";
            this.corruptedTextBox.ReadOnly = true;
            this.corruptedTextBox.Size = new System.Drawing.Size(200, 20);
            this.corruptedTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datos corruptos:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(383, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.corruptedTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encodedTextBox);
            this.Controls.Add(this.detectErrorsButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form3";
            this.Text = "Metodo de hamming";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button detectErrorsButton;
        private System.Windows.Forms.TextBox encodedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox corruptedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}