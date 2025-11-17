namespace ProjectAsync
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnExecAsync = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(11, 13);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(521, 407);
            this.listaResultado.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(553, 13);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(207, 62);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnExecAsync
            // 
            this.btnExecAsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecAsync.Location = new System.Drawing.Point(553, 93);
            this.btnExecAsync.Name = "btnExecAsync";
            this.btnExecAsync.Size = new System.Drawing.Size(207, 62);
            this.btnExecAsync.TabIndex = 2;
            this.btnExecAsync.Text = "Executar Async";
            this.btnExecAsync.UseVisualStyleBackColor = true;
            this.btnExecAsync.Click += new System.EventHandler(this.btnExecAsync_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(553, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExecAsync);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.listaResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnExecAsync;
        private System.Windows.Forms.Button button2;
    }
}

