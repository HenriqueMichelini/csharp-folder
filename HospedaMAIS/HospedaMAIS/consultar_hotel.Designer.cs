namespace HospedaMAIS
{
    partial class consultar_hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultar_hotel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.consultarLucrodespesaButton = new System.Windows.Forms.Button();
            this.cadastrarLucrodespesaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar hotel (clique na célula que deseja alterar)";
            // 
            // consultarLucrodespesaButton
            // 
            this.consultarLucrodespesaButton.Location = new System.Drawing.Point(634, 10);
            this.consultarLucrodespesaButton.Name = "consultarLucrodespesaButton";
            this.consultarLucrodespesaButton.Size = new System.Drawing.Size(154, 23);
            this.consultarLucrodespesaButton.TabIndex = 2;
            this.consultarLucrodespesaButton.Text = "Consultar lucros/despesas";
            this.consultarLucrodespesaButton.UseVisualStyleBackColor = true;
            this.consultarLucrodespesaButton.Click += new System.EventHandler(this.consultarLucrodespesaButton_Click);
            // 
            // cadastrarLucrodespesaButton
            // 
            this.cadastrarLucrodespesaButton.Location = new System.Drawing.Point(474, 9);
            this.cadastrarLucrodespesaButton.Name = "cadastrarLucrodespesaButton";
            this.cadastrarLucrodespesaButton.Size = new System.Drawing.Size(154, 23);
            this.cadastrarLucrodespesaButton.TabIndex = 3;
            this.cadastrarLucrodespesaButton.Text = "Cadastrar lucros/despesas";
            this.cadastrarLucrodespesaButton.UseVisualStyleBackColor = true;
            this.cadastrarLucrodespesaButton.Click += new System.EventHandler(this.cadastrarLucrodespesaButton_Click);
            // 
            // consultar_hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadastrarLucrodespesaButton);
            this.Controls.Add(this.consultarLucrodespesaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "consultar_hotel";
            this.Text = "Consultar hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button consultarLucrodespesaButton;
        private Button cadastrarLucrodespesaButton;
    }
}