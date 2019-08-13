namespace WindowsFormsApp2
{
    partial class Exc4
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
            this.lblTempGasto = new System.Windows.Forms.Label();
            this.txtTempGast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVelocMedia = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTempGasto
            // 
            this.lblTempGasto.AutoSize = true;
            this.lblTempGasto.Location = new System.Drawing.Point(43, 23);
            this.lblTempGasto.Name = "lblTempGasto";
            this.lblTempGasto.Size = new System.Drawing.Size(164, 13);
            this.lblTempGasto.TabIndex = 0;
            this.lblTempGasto.Text = "Informe o tempo gasto na viagem";
            // 
            // txtTempGast
            // 
            this.txtTempGast.Location = new System.Drawing.Point(224, 23);
            this.txtTempGast.Name = "txtTempGast";
            this.txtTempGast.Size = new System.Drawing.Size(100, 20);
            this.txtTempGast.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe a velocidade media";
            // 
            // txtVelocMedia
            // 
            this.txtVelocMedia.Location = new System.Drawing.Point(224, 60);
            this.txtVelocMedia.Name = "txtVelocMedia";
            this.txtVelocMedia.Size = new System.Drawing.Size(100, 20);
            this.txtVelocMedia.TabIndex = 3;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(131, 109);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 4;
            this.btnCalculo.Text = "Calculo";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.BtnCalculo_Click);
            // 
            // Exc4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtVelocMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempGast);
            this.Controls.Add(this.lblTempGasto);
            this.Name = "Exc4";
            this.Text = "Exc4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempGasto;
        private System.Windows.Forms.TextBox txtTempGast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVelocMedia;
        private System.Windows.Forms.Button btnCalculo;
    }
}