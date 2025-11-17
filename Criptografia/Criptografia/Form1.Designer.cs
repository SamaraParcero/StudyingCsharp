namespace Criptografia
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
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografar.Location = new System.Drawing.Point(23, 371);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(359, 95);
            this.btnCriptografar.TabIndex = 2;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(417, 371);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(359, 95);
            this.btnComparar.TabIndex = 3;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(108, 497);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(583, 116);
            this.labelResultado.TabIndex = 4;
            this.labelResultado.Text = "Resultado";
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(40, 12);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.ShortcutsEnabled = false;
            this.txtEntrada.Size = new System.Drawing.Size(720, 165);
            this.txtEntrada.TabIndex = 5;
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(40, 183);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ShortcutsEnabled = false;
            this.txtSaida.Size = new System.Drawing.Size(720, 165);
            this.txtSaida.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnCriptografar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSaida;
    }
}

