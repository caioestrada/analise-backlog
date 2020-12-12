namespace AnaliseBacklog.Framework
{
    partial class formPrincipal
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
            this.openFileBacklog = new System.Windows.Forms.OpenFileDialog();
            this.openFileTracking = new System.Windows.Forms.OpenFileDialog();
            this.openFileBase = new System.Windows.Forms.OpenFileDialog();
            this.btnBackLog = new System.Windows.Forms.Button();
            this.txtBacklog = new System.Windows.Forms.TextBox();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.btnTracking = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.btnBase = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblTracking = new System.Windows.Forms.Label();
            this.lblBacklog = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileBacklog
            // 
            this.openFileBacklog.FileName = "openFileBacklog";
            // 
            // openFileTracking
            // 
            this.openFileTracking.FileName = "openFileTracking";
            // 
            // openFileBase
            // 
            this.openFileBase.FileName = "openFileBase";
            // 
            // btnBackLog
            // 
            this.btnBackLog.Location = new System.Drawing.Point(299, 33);
            this.btnBackLog.Name = "btnBackLog";
            this.btnBackLog.Size = new System.Drawing.Size(122, 20);
            this.btnBackLog.TabIndex = 3;
            this.btnBackLog.Text = "Selecionar Backlog...";
            this.btnBackLog.UseVisualStyleBackColor = true;
            this.btnBackLog.Click += new System.EventHandler(this.btnBackLog_Click);
            // 
            // txtBacklog
            // 
            this.txtBacklog.Location = new System.Drawing.Point(15, 33);
            this.txtBacklog.Name = "txtBacklog";
            this.txtBacklog.Size = new System.Drawing.Size(278, 20);
            this.txtBacklog.TabIndex = 4;
            // 
            // txtTracking
            // 
            this.txtTracking.Location = new System.Drawing.Point(15, 87);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(278, 20);
            this.txtTracking.TabIndex = 6;
            // 
            // btnTracking
            // 
            this.btnTracking.Location = new System.Drawing.Point(299, 87);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(122, 20);
            this.btnTracking.TabIndex = 5;
            this.btnTracking.Text = "Selecionar Tracking...";
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(15, 140);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(278, 20);
            this.txtBase.TabIndex = 8;
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(299, 139);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(122, 20);
            this.btnBase.TabIndex = 7;
            this.btnBase.Text = "Selecionar Base...";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(12, 119);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(188, 17);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Selecionar planilha da Base";
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracking.Location = new System.Drawing.Point(12, 66);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(209, 17);
            this.lblTracking.TabIndex = 1;
            this.lblTracking.Text = "Selecionar planilha de Tracking";
            // 
            // lblBacklog
            // 
            this.lblBacklog.AutoSize = true;
            this.lblBacklog.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacklog.Location = new System.Drawing.Point(12, 9);
            this.lblBacklog.Name = "lblBacklog";
            this.lblBacklog.Size = new System.Drawing.Size(206, 17);
            this.lblBacklog.TabIndex = 0;
            this.lblBacklog.Text = "Selecionar planilha de Backlog";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGerar.Location = new System.Drawing.Point(504, 139);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(69, 20);
            this.btnGerar.TabIndex = 9;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 175);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.txtTracking);
            this.Controls.Add(this.btnTracking);
            this.Controls.Add(this.txtBacklog);
            this.Controls.Add(this.btnBackLog);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblTracking);
            this.Controls.Add(this.lblBacklog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.Text = "Análise Backlog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileBacklog;
        private System.Windows.Forms.OpenFileDialog openFileTracking;
        private System.Windows.Forms.OpenFileDialog openFileBase;
        private System.Windows.Forms.Button btnBackLog;
        private System.Windows.Forms.TextBox txtBacklog;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Button btnTracking;
        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.Label lblBacklog;
        private System.Windows.Forms.Button btnGerar;
    }
}

