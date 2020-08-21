namespace Lasp_Browser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntBack = new System.Windows.Forms.Button();
            this.bntForward = new System.Windows.Forms.Button();
            this.bntGo = new System.Windows.Forms.Button();
            this.bntRefresh = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.bntHome);
            this.panel1.Controls.Add(this.bntRefresh);
            this.panel1.Controls.Add(this.bntGo);
            this.panel1.Controls.Add(this.bntForward);
            this.panel1.Controls.Add(this.bntBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 33);
            this.panel1.TabIndex = 0;
            // 
            // bntBack
            // 
            this.bntBack.Location = new System.Drawing.Point(7, 3);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(32, 23);
            this.bntBack.TabIndex = 0;
            this.bntBack.Text = "BK";
            this.bntBack.UseVisualStyleBackColor = true;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // bntForward
            // 
            this.bntForward.Location = new System.Drawing.Point(71, 3);
            this.bntForward.Name = "bntForward";
            this.bntForward.Size = new System.Drawing.Size(32, 23);
            this.bntForward.TabIndex = 1;
            this.bntForward.Text = "FW";
            this.bntForward.UseVisualStyleBackColor = true;
            this.bntForward.Click += new System.EventHandler(this.bntForward_Click);
            // 
            // bntGo
            // 
            this.bntGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntGo.Location = new System.Drawing.Point(497, 4);
            this.bntGo.Name = "bntGo";
            this.bntGo.Size = new System.Drawing.Size(32, 23);
            this.bntGo.TabIndex = 2;
            this.bntGo.Text = "Go";
            this.bntGo.UseVisualStyleBackColor = true;
            this.bntGo.Click += new System.EventHandler(this.bntGo_Click);
            // 
            // bntRefresh
            // 
            this.bntRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntRefresh.Location = new System.Drawing.Point(532, 4);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(32, 23);
            this.bntRefresh.TabIndex = 3;
            this.bntRefresh.Text = "RF";
            this.bntRefresh.UseVisualStyleBackColor = true;
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // bntHome
            // 
            this.bntHome.Location = new System.Drawing.Point(39, 3);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(32, 23);
            this.bntHome.TabIndex = 4;
            this.bntHome.Text = "HM";
            this.bntHome.UseVisualStyleBackColor = true;
            this.bntHome.Click += new System.EventHandler(this.bntHome_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(110, 5);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(380, 20);
            this.txtUrl.TabIndex = 5;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(567, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "ST";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 33);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(827, 417);
            this.webBrowser.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lasp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Button bntRefresh;
        private System.Windows.Forms.Button bntGo;
        private System.Windows.Forms.Button bntForward;
        private System.Windows.Forms.Button bntBack;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

