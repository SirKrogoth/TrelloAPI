namespace TrelloAPI
{
    partial class frmPrincipal
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
            this.btnConectarTrello = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.imgStatus = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectarTrello
            // 
            this.btnConectarTrello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectarTrello.Location = new System.Drawing.Point(84, 83);
            this.btnConectarTrello.Name = "btnConectarTrello";
            this.btnConectarTrello.Size = new System.Drawing.Size(82, 24);
            this.btnConectarTrello.TabIndex = 0;
            this.btnConectarTrello.Text = "Conectar";
            this.btnConectarTrello.UseVisualStyleBackColor = true;
            this.btnConectarTrello.Click += new System.EventHandler(this.btnConectarTrello_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 89);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: ";
            // 
            // imgStatus
            // 
            this.imgStatus.Image = global::TrelloAPI.Properties.Resources.desconectado;
            this.imgStatus.Location = new System.Drawing.Point(52, 83);
            this.imgStatus.Name = "imgStatus";
            this.imgStatus.Size = new System.Drawing.Size(26, 26);
            this.imgStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgStatus.TabIndex = 2;
            this.imgStatus.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConectarTrello);
            this.Name = "frmPrincipal";
            this.Text = "Trello API";
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectarTrello;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox imgStatus;
        private System.Windows.Forms.Button button1;
    }
}

