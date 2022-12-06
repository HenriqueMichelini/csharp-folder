namespace HospedaMAIS
{
    partial class cadastrar_lucrodespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar_lucrodespesa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limparCamposButton = new System.Windows.Forms.Button();
            this.dataRegistroTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hotelIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.excluirButton = new System.Windows.Forms.Button();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.lucroRadioButton = new System.Windows.Forms.RadioButton();
            this.depesaRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.depesaRadioButton);
            this.groupBox1.Controls.Add(this.lucroRadioButton);
            this.groupBox1.Controls.Add(this.limparCamposButton);
            this.groupBox1.Controls.Add(this.dataRegistroTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hotelIdTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // limparCamposButton
            // 
            this.limparCamposButton.Location = new System.Drawing.Point(254, 155);
            this.limparCamposButton.Name = "limparCamposButton";
            this.limparCamposButton.Size = new System.Drawing.Size(185, 23);
            this.limparCamposButton.TabIndex = 6;
            this.limparCamposButton.Text = "Limpar campos";
            this.limparCamposButton.UseVisualStyleBackColor = true;
            this.limparCamposButton.Click += new System.EventHandler(this.limparCamposButton_Click);
            // 
            // dataRegistroTextBox
            // 
            this.dataRegistroTextBox.Location = new System.Drawing.Point(254, 60);
            this.dataRegistroTextBox.Name = "dataRegistroTextBox";
            this.dataRegistroTextBox.Size = new System.Drawing.Size(185, 23);
            this.dataRegistroTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de registro";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(6, 112);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(185, 23);
            this.valorTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // hotelIdTextBox
            // 
            this.hotelIdTextBox.Location = new System.Drawing.Point(6, 60);
            this.hotelIdTextBox.Name = "hotelIdTextBox";
            this.hotelIdTextBox.Size = new System.Drawing.Size(185, 23);
            this.hotelIdTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID do hotel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.excluirButton);
            this.groupBox2.Controls.Add(this.cadastrarButton);
            this.groupBox2.Controls.Add(this.voltarButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // excluirButton
            // 
            this.excluirButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.excluirButton.Location = new System.Drawing.Point(188, 16);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = false;
            this.excluirButton.Visible = false;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(364, 16);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(75, 23);
            this.cadastrarButton.TabIndex = 1;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(6, 16);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 0;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // lucroRadioButton
            // 
            this.lucroRadioButton.AutoSize = true;
            this.lucroRadioButton.Checked = true;
            this.lucroRadioButton.Location = new System.Drawing.Point(254, 113);
            this.lucroRadioButton.Name = "lucroRadioButton";
            this.lucroRadioButton.Size = new System.Drawing.Size(55, 19);
            this.lucroRadioButton.TabIndex = 7;
            this.lucroRadioButton.TabStop = true;
            this.lucroRadioButton.Text = "Lucro";
            this.lucroRadioButton.UseVisualStyleBackColor = true;
            // 
            // depesaRadioButton
            // 
            this.depesaRadioButton.AutoSize = true;
            this.depesaRadioButton.Location = new System.Drawing.Point(371, 113);
            this.depesaRadioButton.Name = "depesaRadioButton";
            this.depesaRadioButton.Size = new System.Drawing.Size(68, 19);
            this.depesaRadioButton.TabIndex = 8;
            this.depesaRadioButton.Text = "Despesa";
            this.depesaRadioButton.UseVisualStyleBackColor = true;
            // 
            // cadastrar_lucrodespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastrar_lucrodespesa";
            this.Text = "Cadastrar lucro/despesa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button limparCamposButton;
        private TextBox dataRegistroTextBox;
        private Label label3;
        private TextBox valorTextBox;
        private Label label2;
        private TextBox hotelIdTextBox;
        private Label label1;
        private GroupBox groupBox2;
        private Button excluirButton;
        private Button cadastrarButton;
        private Button voltarButton;
        private RadioButton depesaRadioButton;
        private RadioButton lucroRadioButton;
    }
}