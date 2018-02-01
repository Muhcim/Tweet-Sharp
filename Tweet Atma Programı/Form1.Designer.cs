namespace Tweet_Atma_Programı
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.RichMetin = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TxtZaman = new System.Windows.Forms.TextBox();
            this.BtnTweetAt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(903, 583);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://twitter.com/", System.UriKind.Absolute);
            // 
            // RichMetin
            // 
            this.RichMetin.Location = new System.Drawing.Point(12, 12);
            this.RichMetin.Name = "RichMetin";
            this.RichMetin.Size = new System.Drawing.Size(223, 158);
            this.RichMetin.TabIndex = 1;
            this.RichMetin.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(0, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(306, 28);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Şu Kadar Saniye Sonra Tweeti At";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TxtZaman
            // 
            this.TxtZaman.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtZaman.Location = new System.Drawing.Point(0, 231);
            this.TxtZaman.Name = "TxtZaman";
            this.TxtZaman.Size = new System.Drawing.Size(285, 29);
            this.TxtZaman.TabIndex = 4;
            this.TxtZaman.Visible = false;
            // 
            // BtnTweetAt
            // 
            this.BtnTweetAt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTweetAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTweetAt.Location = new System.Drawing.Point(4, 276);
            this.BtnTweetAt.Name = "BtnTweetAt";
            this.BtnTweetAt.Size = new System.Drawing.Size(281, 44);
            this.BtnTweetAt.TabIndex = 2;
            this.BtnTweetAt.Text = "Tweet At";
            this.BtnTweetAt.UseVisualStyleBackColor = false;
            this.BtnTweetAt.Click += new System.EventHandler(this.BtnTweetAt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 583);
            this.Controls.Add(this.TxtZaman);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnTweetAt);
            this.Controls.Add(this.RichMetin);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Sayaçlı Tweet Atma Programı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox RichMetin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TxtZaman;
        private System.Windows.Forms.Button BtnTweetAt;

    }
}

