namespace WindowsFormsApp2
{
    partial class Exc5
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
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalarioFixo = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.btnNovoSalario = new System.Windows.Forms.Button();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtSlrFixo = new System.Windows.Forms.TextBox();
            this.txtVendas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(43, 13);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(153, 13);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Informe o nome do Funcionario";
            // 
            // lblSalarioFixo
            // 
            this.lblSalarioFixo.AutoSize = true;
            this.lblSalarioFixo.Location = new System.Drawing.Point(46, 56);
            this.lblSalarioFixo.Name = "lblSalarioFixo";
            this.lblSalarioFixo.Size = new System.Drawing.Size(108, 13);
            this.lblSalarioFixo.TabIndex = 1;
            this.lblSalarioFixo.Text = "Informe o Salario Fixo";
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Location = new System.Drawing.Point(46, 104);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(85, 13);
            this.lblTotalVendas.TabIndex = 2;
            this.lblTotalVendas.Text = "Total de Vendas";
            // 
            // btnNovoSalario
            // 
            this.btnNovoSalario.Location = new System.Drawing.Point(46, 145);
            this.btnNovoSalario.Name = "btnNovoSalario";
            this.btnNovoSalario.Size = new System.Drawing.Size(75, 23);
            this.btnNovoSalario.TabIndex = 3;
            this.btnNovoSalario.Text = "Calculo";
            this.btnNovoSalario.UseVisualStyleBackColor = true;
            this.btnNovoSalario.Click += new System.EventHandler(this.BtnNovoSalario_Click);
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(213, 13);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFunc.TabIndex = 4;
            // 
            // txtSlrFixo
            // 
            this.txtSlrFixo.Location = new System.Drawing.Point(213, 48);
            this.txtSlrFixo.Name = "txtSlrFixo";
            this.txtSlrFixo.Size = new System.Drawing.Size(100, 20);
            this.txtSlrFixo.TabIndex = 5;
            // 
            // txtVendas
            // 
            this.txtVendas.Location = new System.Drawing.Point(213, 104);
            this.txtVendas.Name = "txtVendas";
            this.txtVendas.Size = new System.Drawing.Size(100, 20);
            this.txtVendas.TabIndex = 6;
            // 
            // Exc5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVendas);
            this.Controls.Add(this.txtSlrFixo);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.btnNovoSalario);
            this.Controls.Add(this.lblTotalVendas);
            this.Controls.Add(this.lblSalarioFixo);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Exc5";
            this.Text = "Exc5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalarioFixo;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Button btnNovoSalario;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtSlrFixo;
        private System.Windows.Forms.TextBox txtVendas;
    }
}