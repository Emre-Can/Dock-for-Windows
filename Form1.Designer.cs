namespace UygulamaBar
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDiger2 = new System.Windows.Forms.Button();
            this.buttonDiger1 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGmail = new System.Windows.Forms.Button();
            this.buttonBupc = new System.Windows.Forms.Button();
            this.buttonChrome = new System.Windows.Forms.Button();
            this.elipseControl6 = new UygulamaBar.ElipseControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1213, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1213, 78);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ayarla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDiger2
            // 
            this.buttonDiger2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDiger2.FlatAppearance.BorderSize = 0;
            this.buttonDiger2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiger2.Location = new System.Drawing.Point(560, 5);
            this.buttonDiger2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonDiger2.Name = "buttonDiger2";
            this.buttonDiger2.Size = new System.Drawing.Size(133, 123);
            this.buttonDiger2.TabIndex = 10;
            this.buttonDiger2.UseVisualStyleBackColor = true;
            this.buttonDiger2.Visible = false;
            this.buttonDiger2.Click += new System.EventHandler(this.buttonDiger2_Click);
            // 
            // buttonDiger1
            // 
            this.buttonDiger1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDiger1.FlatAppearance.BorderSize = 0;
            this.buttonDiger1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiger1.Location = new System.Drawing.Point(421, 5);
            this.buttonDiger1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonDiger1.Name = "buttonDiger1";
            this.buttonDiger1.Size = new System.Drawing.Size(133, 123);
            this.buttonDiger1.TabIndex = 8;
            this.buttonDiger1.UseVisualStyleBackColor = true;
            this.buttonDiger1.Visible = false;
            this.buttonDiger1.Click += new System.EventHandler(this.buttonDiger1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackgroundImage = global::UygulamaBar.Properties.Resources.icons8_shutdown_100px;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(1072, 5);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 123);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonGmail
            // 
            this.buttonGmail.BackgroundImage = global::UygulamaBar.Properties.Resources.icons8_gmail_100px;
            this.buttonGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGmail.FlatAppearance.BorderSize = 0;
            this.buttonGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGmail.Location = new System.Drawing.Point(280, 5);
            this.buttonGmail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonGmail.Name = "buttonGmail";
            this.buttonGmail.Size = new System.Drawing.Size(133, 123);
            this.buttonGmail.TabIndex = 5;
            this.buttonGmail.UseVisualStyleBackColor = true;
            this.buttonGmail.Click += new System.EventHandler(this.buttonGmail_Click);
            // 
            // buttonBupc
            // 
            this.buttonBupc.BackgroundImage = global::UygulamaBar.Properties.Resources.icons8_windows_client_100px;
            this.buttonBupc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBupc.FlatAppearance.BorderSize = 0;
            this.buttonBupc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBupc.Location = new System.Drawing.Point(-5, -5);
            this.buttonBupc.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonBupc.Name = "buttonBupc";
            this.buttonBupc.Size = new System.Drawing.Size(133, 123);
            this.buttonBupc.TabIndex = 4;
            this.buttonBupc.UseVisualStyleBackColor = true;
            this.buttonBupc.Click += new System.EventHandler(this.buttonBupc_Click);
            // 
            // buttonChrome
            // 
            this.buttonChrome.BackgroundImage = global::UygulamaBar.Properties.Resources.icons8_chrome_100px;
            this.buttonChrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChrome.FlatAppearance.BorderSize = 0;
            this.buttonChrome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChrome.Location = new System.Drawing.Point(144, 5);
            this.buttonChrome.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonChrome.Name = "buttonChrome";
            this.buttonChrome.Size = new System.Drawing.Size(133, 123);
            this.buttonChrome.TabIndex = 3;
            this.buttonChrome.UseVisualStyleBackColor = true;
            this.buttonChrome.Click += new System.EventHandler(this.buttonChrome_Click);
            // 
            // elipseControl6
            // 
            this.elipseControl6.CornerRadius = 7;
            this.elipseControl6.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 133);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDiger2);
            this.Controls.Add(this.buttonDiger1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonGmail);
            this.Controls.Add(this.buttonBupc);
            this.Controls.Add(this.buttonChrome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonChrome;
        private System.Windows.Forms.Button buttonBupc;
        private System.Windows.Forms.Button buttonGmail;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDiger1;
        private System.Windows.Forms.Timer timer1;
        private ElipseControl elipseControl6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDiger2;
    }
}

