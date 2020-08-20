namespace WindowsFormsApp3
{
    partial class home
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
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Uphone = new System.Windows.Forms.TextBox();
            this.Upassword = new System.Windows.Forms.TextBox();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buRegs = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(210, 232);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 0;
            this.login.Text = "Log in";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(343, 232);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 1;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.Location = new System.Drawing.Point(195, 87);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(38, 13);
            this.phone.TabIndex = 2;
            this.phone.Text = "Phone";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Location = new System.Drawing.Point(195, 150);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // Uphone
            // 
            this.Uphone.Location = new System.Drawing.Point(318, 84);
            this.Uphone.Name = "Uphone";
            this.Uphone.Size = new System.Drawing.Size(100, 20);
            this.Uphone.TabIndex = 4;
            // 
            // Upassword
            // 
            this.Upassword.Location = new System.Drawing.Point(318, 150);
            this.Upassword.Name = "Upassword";
            this.Upassword.Size = new System.Drawing.Size(100, 20);
            this.Upassword.TabIndex = 5;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.Transparent;
            this.registerPanel.Controls.Add(this.button1);
            this.registerPanel.Controls.Add(this.buRegs);
            this.registerPanel.Controls.Add(this.comboBox1);
            this.registerPanel.Controls.Add(this.txtpass);
            this.registerPanel.Controls.Add(this.txtadd);
            this.registerPanel.Controls.Add(this.txtphone);
            this.registerPanel.Controls.Add(this.txtname);
            this.registerPanel.Controls.Add(this.label5);
            this.registerPanel.Controls.Add(this.label4);
            this.registerPanel.Controls.Add(this.label3);
            this.registerPanel.Controls.Add(this.label2);
            this.registerPanel.Controls.Add(this.label1);
            this.registerPanel.Location = new System.Drawing.Point(159, 52);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(259, 257);
            this.registerPanel.TabIndex = 6;
            this.registerPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buRegs
            // 
            this.buRegs.Location = new System.Drawing.Point(42, 222);
            this.buRegs.Name = "buRegs";
            this.buRegs.Size = new System.Drawing.Size(75, 23);
            this.buRegs.TabIndex = 10;
            this.buRegs.Text = "Register";
            this.buRegs.UseVisualStyleBackColor = true;
            this.buRegs.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Abassia",
            "Ain-Shams",
            "Alf-Maskan",
            "Doki",
            "Down Town",
            "Elharm",
            "Heliopolis",
            "Helwan",
            "Matarya",
            "Moqattam",
            "Naser City",
            "New Cairo",
            "Ramses",
            "Shoubra",
            "Tahrir",
            "Zamalek",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(121, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(121, 180);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(121, 20);
            this.txtpass.TabIndex = 8;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(121, 147);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(121, 20);
            this.txtadd.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(121, 84);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(121, 20);
            this.txtphone.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(121, 48);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 20);
            this.txtname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.pexels_photo_358904;
            this.ClientSize = new System.Drawing.Size(574, 348);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.Upassword);
            this.Controls.Add(this.Uphone);
            this.Controls.Add(this.password);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Name = "home";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.home_Load);
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox Uphone;
        private System.Windows.Forms.TextBox Upassword;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Button buRegs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}