namespace yakalamaoyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.elmapic = new System.Windows.Forms.PictureBox();
            this.sepetpic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelhak = new System.Windows.Forms.Label();
            this.tekrarbuton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elmapic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetpic)).BeginInit();
            this.SuspendLayout();
            // 
            // elmapic
            // 
            this.elmapic.BackColor = System.Drawing.Color.Red;
            this.elmapic.Image = ((System.Drawing.Image)(resources.GetObject("elmapic.Image")));
            this.elmapic.Location = new System.Drawing.Point(100, 0);
            this.elmapic.Name = "elmapic";
            this.elmapic.Size = new System.Drawing.Size(30, 30);
            this.elmapic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elmapic.TabIndex = 0;
            this.elmapic.TabStop = false;
            // 
            // sepetpic
            // 
            this.sepetpic.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sepetpic.Image = ((System.Drawing.Image)(resources.GetObject("sepetpic.Image")));
            this.sepetpic.Location = new System.Drawing.Point(234, 390);
            this.sepetpic.Name = "sepetpic";
            this.sepetpic.Size = new System.Drawing.Size(120, 30);
            this.sepetpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sepetpic.TabIndex = 1;
            this.sepetpic.TabStop = false;
            this.sepetpic.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelhak
            // 
            this.labelhak.AutoSize = true;
            this.labelhak.Location = new System.Drawing.Point(12, 424);
            this.labelhak.Name = "labelhak";
            this.labelhak.Size = new System.Drawing.Size(121, 16);
            this.labelhak.TabIndex = 2;
            this.labelhak.Text = "TOPLAM ELMA = 0";
            this.labelhak.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelhak.Click += new System.EventHandler(this.labelhak_Click);
            // 
            // tekrarbuton
            // 
            this.tekrarbuton.BackColor = System.Drawing.Color.DarkGray;
            this.tekrarbuton.Location = new System.Drawing.Point(461, 424);
            this.tekrarbuton.Name = "tekrarbuton";
            this.tekrarbuton.Size = new System.Drawing.Size(119, 26);
            this.tekrarbuton.TabIndex = 3;
            this.tekrarbuton.Text = "Tekrar Oyna";
            this.tekrarbuton.UseVisualStyleBackColor = false;
            this.tekrarbuton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.tekrarbuton);
            this.Controls.Add(this.labelhak);
            this.Controls.Add(this.sepetpic);
            this.Controls.Add(this.elmapic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.elmapic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepetpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox elmapic;
        private System.Windows.Forms.PictureBox sepetpic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelhak;
        private System.Windows.Forms.Button tekrarbuton;
    }
}

