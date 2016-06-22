namespace AtbashCipher
{
    partial class Form1
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
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.txtlistas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(64, 142);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(142, 20);
            this.txtResultados.TabIndex = 20;
            // 
            // txtlistas
            // 
            this.txtlistas.FormattingEnabled = true;
            this.txtlistas.Location = new System.Drawing.Point(64, 178);
            this.txtlistas.Name = "txtlistas";
            this.txtlistas.Size = new System.Drawing.Size(149, 121);
            this.txtlistas.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 18;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(98, 90);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 16;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Atbash";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(43, 35);
            this.txtCadena.Multiline = true;
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(193, 39);
            this.txtCadena.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 308);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.txtlistas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.ListBox txtlistas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
    }
}

