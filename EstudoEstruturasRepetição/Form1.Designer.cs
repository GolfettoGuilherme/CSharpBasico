namespace EstudoEstruturasRepetição
{
    partial class frmEstruturasRep
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.lsbResultados = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(108, 6);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(100, 20);
            this.txbNum.TabIndex = 1;
            // 
            // lsbResultados
            // 
            this.lsbResultados.FormattingEnabled = true;
            this.lsbResultados.Location = new System.Drawing.Point(214, 6);
            this.lsbResultados.Name = "lsbResultados";
            this.lsbResultados.Size = new System.Drawing.Size(188, 147);
            this.lsbResultados.TabIndex = 2;
            this.lsbResultados.SelectedIndexChanged += new System.EventHandler(this.lsbResultados_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(108, 32);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmEstruturasRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 165);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lsbResultados);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.label1);
            this.Name = "frmEstruturasRep";
            this.Text = "TreinaWeb - Estudo de Estruras de repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNum;
        private System.Windows.Forms.ListBox lsbResultados;
        private System.Windows.Forms.Button btnCalcular;
    }
}

