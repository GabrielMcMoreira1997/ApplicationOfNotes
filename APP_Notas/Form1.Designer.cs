
namespace APP_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnRead = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnNew
            // 
            this.bttnNew.Location = new System.Drawing.Point(111, 207);
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.Size = new System.Drawing.Size(75, 23);
            this.bttnNew.TabIndex = 0;
            this.bttnNew.Text = "Novo";
            this.bttnNew.UseVisualStyleBackColor = true;
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mensagem";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(111, 74);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(210, 118);
            this.txtMessage.TabIndex = 4;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(246, 207);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 23);
            this.bttnSave.TabIndex = 5;
            this.bttnSave.Text = "Salvar";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 157);
            this.dataGridView1.TabIndex = 6;
            // 
            // bttnRead
            // 
            this.bttnRead.Location = new System.Drawing.Point(377, 207);
            this.bttnRead.Name = "bttnRead";
            this.bttnRead.Size = new System.Drawing.Size(75, 23);
            this.bttnRead.TabIndex = 7;
            this.bttnRead.Text = "Ler";
            this.bttnRead.UseVisualStyleBackColor = true;
            this.bttnRead.Click += new System.EventHandler(this.bttnRead_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(542, 207);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(75, 23);
            this.bttnDelete.TabIndex = 8;
            this.bttnDelete.Text = "Excluir";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de mensagens:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(635, 263);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnRead);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnRead;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Label label3;
    }
}

