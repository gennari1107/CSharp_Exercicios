namespace WindowsFormsApp2
{
    partial class Exc3
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtReajust = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblReajuste = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(181, 12);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 0;
            // 
            // txtReajust
            // 
            this.txtReajust.Location = new System.Drawing.Point(181, 56);
            this.txtReajust.Name = "txtReajust";
            this.txtReajust.Size = new System.Drawing.Size(100, 20);
            this.txtReajust.TabIndex = 1;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(38, 18);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(84, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Informe o salario";
            // 
            // lblReajuste
            // 
            this.lblReajuste.AutoSize = true;
            this.lblReajuste.Location = new System.Drawing.Point(41, 68);
            this.lblReajuste.Name = "lblReajuste";
            this.lblReajuste.Size = new System.Drawing.Size(96, 13);
            this.lblReajuste.TabIndex = 3;
            this.lblReajuste.Text = "Informe o Reajuste";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(181, 102);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculo";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // Exc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblReajuste);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtReajust);
            this.Controls.Add(this.txtSalario);
            this.Name = "Exc3";
            this.Text = "Exc3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtReajust;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblReajuste;
        private System.Windows.Forms.Button btnCalc;
    }
}