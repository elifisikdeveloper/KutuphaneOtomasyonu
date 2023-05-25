namespace KutuphaneOtomasyonu
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            tbuser = new TextBox();
            txtbpassword = new TextBox();
            labeluser = new Label();
            labelpassword = new Label();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // tbuser
            // 
            tbuser.BackColor = Color.White;
            tbuser.Location = new Point(200, 97);
            tbuser.Name = "tbuser";
            tbuser.Size = new Size(194, 27);
            tbuser.TabIndex = 0;
            // 
            // txtbpassword
            // 
            txtbpassword.BackColor = Color.White;
            txtbpassword.Location = new Point(200, 156);
            txtbpassword.Name = "txtbpassword";
            txtbpassword.Size = new Size(194, 27);
            txtbpassword.TabIndex = 1;
            // 
            // labeluser
            // 
            labeluser.AutoSize = true;
            labeluser.BackColor = Color.Transparent;
            labeluser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeluser.Location = new Point(54, 93);
            labeluser.Name = "labeluser";
            labeluser.Size = new Size(124, 28);
            labeluser.TabIndex = 2;
            labeluser.Text = "Kullanıcı Adı:";
            // 
            // labelpassword
            // 
            labelpassword.AutoSize = true;
            labelpassword.BackColor = Color.Transparent;
            labelpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelpassword.Location = new Point(108, 152);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(55, 28);
            labelpassword.TabIndex = 3;
            labelpassword.Text = "Şifre:";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(0, 192, 192);
            btnlogin.Location = new Point(236, 241);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(120, 29);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Giriş Yap";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 462);
            Controls.Add(btnlogin);
            Controls.Add(labelpassword);
            Controls.Add(labeluser);
            Controls.Add(txtbpassword);
            Controls.Add(tbuser);
            Name = "LoginForm";
            Text = "Kütühane Otomasyon Sistemi Giriş Ekranı";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbuser;
        private TextBox txtbpassword;
        private Label labeluser;
        private Label labelpassword;
        private Label label1;
        private Button btnlogin;
    }
}