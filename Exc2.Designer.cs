namespace WindowsFormsApp2
{
    partial class Exc2
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.btnCalculoAB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(56, 28);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(90, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Informe o valor  A";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(181, 28);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(100, 20);
            this.txtValorA.TabIndex = 1;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(56, 71);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(87, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Informe o valor B";
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(181, 64);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(100, 20);
            this.txtValorB.TabIndex = 3;
            // 
            // btnCalculoAB
            // 
            this.btnCalculoAB.Location = new System.Drawing.Point(181, 105);
            this.btnCalculoAB.Name = "btnCalculoAB";
            this.btnCalculoAB.Size = new System.Drawing.Size(75, 23);
            this.btnCalculoAB.TabIndex = 4;
            this.btnCalculoAB.Text = "calculo";
            this.btnCalculoAB.UseVisualStyleBackColor = true;
            this.btnCalculoAB.Click += new System.EventHandler(this.BtnCalculoAB_Click);
            // 
            // Exc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculoAB);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblA);
            this.Name = "Exc2";
            this.Text = "Exc2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Button btnCalculoAB;
    }
}