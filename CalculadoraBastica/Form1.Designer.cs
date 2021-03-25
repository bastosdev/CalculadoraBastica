
namespace CalculadoraBastica
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "1ª Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(101, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "2º Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(220, 107);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(84, 23);
            this.textNum1.TabIndex = 3;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(220, 142);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(84, 23);
            this.textNum2.TabIndex = 4;
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(217, 300);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(87, 23);
            this.textResultado.TabIndex = 5;
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.Purple;
            this.btnSomar.FlatAppearance.BorderSize = 0;
            this.btnSomar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSomar.ForeColor = System.Drawing.Color.White;
            this.btnSomar.Location = new System.Drawing.Point(101, 187);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(94, 38);
            this.btnSomar.TabIndex = 6;
            this.btnSomar.Text = "SOMAR";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.Purple;
            this.btnSubtrair.FlatAppearance.BorderSize = 0;
            this.btnSubtrair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSubtrair.ForeColor = System.Drawing.Color.White;
            this.btnSubtrair.Location = new System.Drawing.Point(210, 187);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(94, 38);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "SUBTRAIR";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Purple;
            this.btnMultiplicar.FlatAppearance.BorderSize = 0;
            this.btnMultiplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMultiplicar.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicar.Location = new System.Drawing.Point(101, 238);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(94, 38);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "MULTIPLICAR";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Purple;
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDividir.ForeColor = System.Drawing.Color.White;
            this.btnDividir.Location = new System.Drawing.Point(210, 238);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(94, 37);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "DIVIDIR";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(89, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "CALCULADORA BÁSICA";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Purple;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(101, 349);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 38);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Purple;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(210, 349);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 38);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

