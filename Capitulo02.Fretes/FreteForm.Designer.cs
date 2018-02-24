namespace Capitulo02.Fretes
{
    partial class freteForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomeLabel = new System.Windows.Forms.Label();
            this.ufLabel = new System.Windows.Forms.Label();
            this.valorLabel = new System.Windows.Forms.Label();
            this.percentualFreteLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.percentualfreteTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 9);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            this.nomeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ufLabel
            // 
            this.ufLabel.AutoSize = true;
            this.ufLabel.Location = new System.Drawing.Point(26, 63);
            this.ufLabel.Name = "ufLabel";
            this.ufLabel.Size = new System.Drawing.Size(21, 13);
            this.ufLabel.TabIndex = 4;
            this.ufLabel.Text = "UF";
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(16, 36);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(31, 13);
            this.valorLabel.TabIndex = 2;
            this.valorLabel.Text = "Valor";
            this.valorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // percentualFreteLabel
            // 
            this.percentualFreteLabel.AutoSize = true;
            this.percentualFreteLabel.Location = new System.Drawing.Point(8, 90);
            this.percentualFreteLabel.Name = "percentualFreteLabel";
            this.percentualFreteLabel.Size = new System.Drawing.Size(39, 13);
            this.percentualFreteLabel.TabIndex = 6;
            this.percentualFreteLabel.Text = "%Frete";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(65, 6);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(379, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(65, 33);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 3;
            // 
            // percentualfreteTextBox
            // 
            this.percentualfreteTextBox.Location = new System.Drawing.Point(65, 87);
            this.percentualfreteTextBox.Name = "percentualfreteTextBox";
            this.percentualfreteTextBox.ReadOnly = true;
            this.percentualfreteTextBox.Size = new System.Drawing.Size(100, 20);
            this.percentualfreteTextBox.TabIndex = 7;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(302, 168);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(256, 44);
            this.calcularButton.TabIndex = 10;
            this.calcularButton.Text = "Calcular Frete";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(16, 116);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(65, 113);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 9;
            // 
            // ufComboBox
            // 
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "AM",
            "Outros"});
            this.ufComboBox.Location = new System.Drawing.Point(65, 60);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(121, 21);
            this.ufComboBox.TabIndex = 5;
            this.ufComboBox.Text = "Selecione";
            // 
            // freteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 224);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.percentualfreteTextBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.percentualFreteLabel);
            this.Controls.Add(this.ufLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.nomeLabel);
            this.Name = "freteForm";
            this.Text = "Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label ufLabel;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.Label percentualFreteLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox percentualfreteTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
    }
}

