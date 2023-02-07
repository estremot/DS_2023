namespace Aula_01
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Mensagem = new System.Windows.Forms.Button();
            this.lbl_Mensagem = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Titulo.Location = new System.Drawing.Point(134, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(119, 40);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "AULA 1";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(309, 144);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 36);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Mensagem
            // 
            this.btn_Mensagem.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mensagem.Image")));
            this.btn_Mensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Mensagem.Location = new System.Drawing.Point(12, 144);
            this.btn_Mensagem.Name = "btn_Mensagem";
            this.btn_Mensagem.Size = new System.Drawing.Size(115, 36);
            this.btn_Mensagem.TabIndex = 2;
            this.btn_Mensagem.Text = "&Mensagem";
            this.btn_Mensagem.UseVisualStyleBackColor = true;
            this.btn_Mensagem.Click += new System.EventHandler(this.btn_Mensagem_Click);
            // 
            // lbl_Mensagem
            // 
            this.lbl_Mensagem.AutoSize = true;
            this.lbl_Mensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensagem.Location = new System.Drawing.Point(9, 59);
            this.lbl_Mensagem.Name = "lbl_Mensagem";
            this.lbl_Mensagem.Size = new System.Drawing.Size(0, 21);
            this.lbl_Mensagem.TabIndex = 3;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Enabled = false;
            this.btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.Image")));
            this.btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpar.Location = new System.Drawing.Point(133, 144);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(120, 36);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 192);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lbl_Mensagem);
            this.Controls.Add(this.btn_Mensagem);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula 01 do Professor Estremote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Mensagem;
        private System.Windows.Forms.Label lbl_Mensagem;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

