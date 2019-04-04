namespace AulaColeções
{
    partial class Form1
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
            this.dgvCanil = new System.Windows.Forms.DataGridView();
            this.butEditar = new System.Windows.Forms.Button();
            this.butRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.butAdicionar = new System.Windows.Forms.Button();
            this.rbtSimPedigree = new System.Windows.Forms.RadioButton();
            this.rbtNaoPedigree = new System.Windows.Forms.RadioButton();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanil)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCanil
            // 
            this.dgvCanil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanil.Location = new System.Drawing.Point(233, 35);
            this.dgvCanil.Name = "dgvCanil";
            this.dgvCanil.ReadOnly = true;
            this.dgvCanil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanil.Size = new System.Drawing.Size(338, 194);
            this.dgvCanil.TabIndex = 0;
            // 
            // butEditar
            // 
            this.butEditar.Location = new System.Drawing.Point(340, 235);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(75, 23);
            this.butEditar.TabIndex = 1;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = true;
            this.butEditar.Click += new System.EventHandler(this.butEditar_Click);
            // 
            // butRemover
            // 
            this.butRemover.Location = new System.Drawing.Point(421, 235);
            this.butRemover.Name = "butRemover";
            this.butRemover.Size = new System.Drawing.Size(75, 23);
            this.butRemover.TabIndex = 2;
            this.butRemover.Text = "Remover";
            this.butRemover.UseVisualStyleBackColor = true;
            this.butRemover.Click += new System.EventHandler(this.butRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pedigree:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(125, 63);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(93, 20);
            this.txbNome.TabIndex = 6;
            // 
            // butAdicionar
            // 
            this.butAdicionar.Location = new System.Drawing.Point(143, 143);
            this.butAdicionar.Name = "butAdicionar";
            this.butAdicionar.Size = new System.Drawing.Size(75, 23);
            this.butAdicionar.TabIndex = 9;
            this.butAdicionar.Text = "Adicionar";
            this.butAdicionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butAdicionar.UseVisualStyleBackColor = true;
            this.butAdicionar.Click += new System.EventHandler(this.butAdicionar_Click);
            // 
            // rbtSimPedigree
            // 
            this.rbtSimPedigree.AutoSize = true;
            this.rbtSimPedigree.Checked = true;
            this.rbtSimPedigree.Location = new System.Drawing.Point(125, 120);
            this.rbtSimPedigree.Name = "rbtSimPedigree";
            this.rbtSimPedigree.Size = new System.Drawing.Size(42, 17);
            this.rbtSimPedigree.TabIndex = 10;
            this.rbtSimPedigree.TabStop = true;
            this.rbtSimPedigree.Text = "Sim";
            this.rbtSimPedigree.UseVisualStyleBackColor = true;
            // 
            // rbtNaoPedigree
            // 
            this.rbtNaoPedigree.AutoSize = true;
            this.rbtNaoPedigree.Location = new System.Drawing.Point(173, 120);
            this.rbtNaoPedigree.Name = "rbtNaoPedigree";
            this.rbtNaoPedigree.Size = new System.Drawing.Size(45, 17);
            this.rbtNaoPedigree.TabIndex = 11;
            this.rbtNaoPedigree.Text = "Não";
            this.rbtNaoPedigree.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(125, 89);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(93, 20);
            this.dtpDataNascimento.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 263);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.rbtNaoPedigree);
            this.Controls.Add(this.rbtSimPedigree);
            this.Controls.Add(this.butAdicionar);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butRemover);
            this.Controls.Add(this.butEditar);
            this.Controls.Add(this.dgvCanil);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCanil;
        private System.Windows.Forms.Button butEditar;
        private System.Windows.Forms.Button butRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button butAdicionar;
        private System.Windows.Forms.RadioButton rbtSimPedigree;
        private System.Windows.Forms.RadioButton rbtNaoPedigree;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
    }
}

