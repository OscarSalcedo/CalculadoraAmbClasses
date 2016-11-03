namespace CalciladoraAmbClasses
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
            this.lblPantallaSeguiment = new System.Windows.Forms.Label();
            this.btnEnrere = new System.Windows.Forms.Button();
            this.lblPantalla = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPantallaSeguiment
            // 
            this.lblPantallaSeguiment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPantallaSeguiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantallaSeguiment.Location = new System.Drawing.Point(32, 38);
            this.lblPantallaSeguiment.Name = "lblPantallaSeguiment";
            this.lblPantallaSeguiment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPantallaSeguiment.Size = new System.Drawing.Size(227, 30);
            this.lblPantallaSeguiment.TabIndex = 39;
            this.lblPantallaSeguiment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPantallaSeguiment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btnEnrere
            // 
            this.btnEnrere.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEnrere.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEnrere.Location = new System.Drawing.Point(32, 268);
            this.btnEnrere.Name = "btnEnrere";
            this.btnEnrere.Size = new System.Drawing.Size(53, 37);
            this.btnEnrere.TabIndex = 30;
            this.btnEnrere.TabStop = false;
            this.btnEnrere.Text = "<--";
            this.btnEnrere.UseVisualStyleBackColor = false;
            // 
            // lblPantalla
            // 
            this.lblPantalla.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantalla.Location = new System.Drawing.Point(31, 35);
            this.lblPantalla.Name = "lblPantalla";
            this.lblPantalla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPantalla.Size = new System.Drawing.Size(233, 79);
            this.lblPantalla.TabIndex = 20;
            this.lblPantalla.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblPantalla.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBorrar.Location = new System.Drawing.Point(270, 43);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(53, 68);
            this.btnBorrar.TabIndex = 38;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDividir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDividir.Location = new System.Drawing.Point(270, 139);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(53, 37);
            this.btnDividir.TabIndex = 37;
            this.btnDividir.TabStop = false;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsOperacions_MouseUp);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMultiplicar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnMultiplicar.Location = new System.Drawing.Point(270, 182);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(53, 37);
            this.btnMultiplicar.TabIndex = 36;
            this.btnMultiplicar.TabStop = false;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsOperacions_MouseUp);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSuma.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSuma.Location = new System.Drawing.Point(270, 268);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(53, 80);
            this.btnSuma.TabIndex = 34;
            this.btnSuma.TabStop = false;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsOperacions_MouseUp);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnResta.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnResta.Location = new System.Drawing.Point(270, 225);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(53, 37);
            this.btnResta.TabIndex = 35;
            this.btnResta.TabStop = false;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsOperacions_MouseUp);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIgual.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnIgual.Location = new System.Drawing.Point(110, 311);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(132, 37);
            this.btnIgual.TabIndex = 33;
            this.btnIgual.TabStop = false;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIgual_MouseUp);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn3.Location = new System.Drawing.Point(189, 225);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 37);
            this.btn3.TabIndex = 29;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn6.Location = new System.Drawing.Point(189, 182);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 37);
            this.btn6.TabIndex = 26;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn9.Location = new System.Drawing.Point(189, 139);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 37);
            this.btn9.TabIndex = 23;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPunto.Location = new System.Drawing.Point(31, 311);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(53, 37);
            this.btnPunto.TabIndex = 32;
            this.btnPunto.TabStop = false;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn2.Location = new System.Drawing.Point(110, 225);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 37);
            this.btn2.TabIndex = 28;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn5.Location = new System.Drawing.Point(110, 182);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 37);
            this.btn5.TabIndex = 25;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn8.Location = new System.Drawing.Point(110, 139);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 37);
            this.btn8.TabIndex = 22;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn0.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn0.Location = new System.Drawing.Point(110, 268);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(132, 37);
            this.btn0.TabIndex = 31;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn1.Location = new System.Drawing.Point(31, 225);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 37);
            this.btn1.TabIndex = 27;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn4.Location = new System.Drawing.Point(31, 182);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 37);
            this.btn4.TabIndex = 24;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn7.Location = new System.Drawing.Point(31, 139);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 37);
            this.btn7.TabIndex = 21;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonsNumeros_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 395);
            this.Controls.Add(this.lblPantallaSeguiment);
            this.Controls.Add(this.btnEnrere);
            this.Controls.Add(this.lblPantalla);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPantallaSeguiment;
        private System.Windows.Forms.Button btnEnrere;
        private System.Windows.Forms.Label lblPantalla;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
    }
}

