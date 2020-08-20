namespace WindowsFormsApp3
{
    partial class CheckOut
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
            this.label1 = new System.Windows.Forms.Label();
            this.Dtdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.quant = new System.Windows.Forms.TextBox();
            this.item = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FinalCost = new System.Windows.Forms.TextBox();
            this.finalDisc = new System.Windows.Forms.TextBox();
            this.totQuant = new System.Windows.Forms.TextBox();
            this.check_addres = new System.Windows.Forms.ComboBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Dtime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.dateO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Out";
            // 
            // Dtdate
            // 
            this.Dtdate.Location = new System.Drawing.Point(583, 98);
            this.Dtdate.MinDate = new System.DateTime(2018, 4, 23, 16, 51, 46, 0);
            this.Dtdate.Name = "Dtdate";
            this.Dtdate.Size = new System.Drawing.Size(215, 20);
            this.Dtdate.TabIndex = 3;
            this.Dtdate.Value = new System.DateTime(2018, 4, 23, 16, 51, 46, 0);
            this.Dtdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delivery Date:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(571, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 83);
            this.button1.TabIndex = 5;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "        Quantity                  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "         Price     ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "         Items                    ";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.DarkSalmon;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Location = new System.Drawing.Point(331, 94);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(138, 216);
            this.price.TabIndex = 51;
            // 
            // quant
            // 
            this.quant.BackColor = System.Drawing.Color.DarkSalmon;
            this.quant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quant.Location = new System.Drawing.Point(169, 94);
            this.quant.Multiline = true;
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Size = new System.Drawing.Size(173, 216);
            this.quant.TabIndex = 50;
            this.quant.TextChanged += new System.EventHandler(this.quant_TextChanged);
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.DarkSalmon;
            this.item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.item.Location = new System.Drawing.Point(35, 94);
            this.item.Multiline = true;
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Size = new System.Drawing.Size(135, 216);
            this.item.TabIndex = 49;
            this.item.TextChanged += new System.EventHandler(this.item_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 55;
            this.label6.Text = " Discount:     ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Total :           ";
            // 
            // firstTotal
            // 
            this.firstTotal.BackColor = System.Drawing.Color.IndianRed;
            this.firstTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstTotal.Location = new System.Drawing.Point(365, 313);
            this.firstTotal.Name = "firstTotal";
            this.firstTotal.ReadOnly = true;
            this.firstTotal.Size = new System.Drawing.Size(100, 13);
            this.firstTotal.TabIndex = 57;
            this.firstTotal.TextChanged += new System.EventHandler(this.firstTotal_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.IndianRed;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "Final Cost:    ";
            // 
            // FinalCost
            // 
            this.FinalCost.BackColor = System.Drawing.Color.IndianRed;
            this.FinalCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FinalCost.Location = new System.Drawing.Point(365, 366);
            this.FinalCost.Name = "FinalCost";
            this.FinalCost.ReadOnly = true;
            this.FinalCost.Size = new System.Drawing.Size(100, 13);
            this.FinalCost.TabIndex = 59;
            // 
            // finalDisc
            // 
            this.finalDisc.BackColor = System.Drawing.Color.IndianRed;
            this.finalDisc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalDisc.Location = new System.Drawing.Point(365, 341);
            this.finalDisc.Name = "finalDisc";
            this.finalDisc.ReadOnly = true;
            this.finalDisc.Size = new System.Drawing.Size(100, 13);
            this.finalDisc.TabIndex = 60;
            // 
            // totQuant
            // 
            this.totQuant.BackColor = System.Drawing.Color.IndianRed;
            this.totQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totQuant.Location = new System.Drawing.Point(226, 313);
            this.totQuant.Name = "totQuant";
            this.totQuant.ReadOnly = true;
            this.totQuant.Size = new System.Drawing.Size(100, 13);
            this.totQuant.TabIndex = 61;
            // 
            // check_addres
            // 
            this.check_addres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.check_addres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.check_addres.FormattingEnabled = true;
            this.check_addres.Items.AddRange(new object[] {
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
            this.check_addres.Location = new System.Drawing.Point(583, 195);
            this.check_addres.Name = "check_addres";
            this.check_addres.Size = new System.Drawing.Size(121, 21);
            this.check_addres.TabIndex = 65;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(583, 227);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(121, 20);
            this.txtadd.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "Region";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(473, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 62;
            this.label10.Text = "Address";
            // 
            // Dtime
            // 
            this.Dtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtime.Location = new System.Drawing.Point(583, 150);
            this.Dtime.Name = "Dtime";
            this.Dtime.Size = new System.Drawing.Size(215, 20);
            this.Dtime.TabIndex = 66;
            this.Dtime.Value = new System.DateTime(2018, 4, 23, 16, 52, 0, 0);
            this.Dtime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(473, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 67;
            this.label11.Text = "Delivery Time:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(22, 23);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 13);
            this.Phone.TabIndex = 68;
            this.Phone.Text = "label12";
            // 
            // dateO
            // 
            this.dateO.AutoSize = true;
            this.dateO.Location = new System.Drawing.Point(794, 234);
            this.dateO.Name = "dateO";
            this.dateO.Size = new System.Drawing.Size(41, 13);
            this.dateO.TabIndex = 69;
            this.dateO.Text = "label12";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 388);
            this.Controls.Add(this.dateO);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Dtime);
            this.Controls.Add(this.check_addres);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.totQuant);
            this.Controls.Add(this.finalDisc);
            this.Controls.Add(this.FinalCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.firstTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quant);
            this.Controls.Add(this.item);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dtdate);
            this.Controls.Add(this.label1);
            this.Name = "CheckOut";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quant;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox firstTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FinalCost;
        private System.Windows.Forms.TextBox finalDisc;
        private System.Windows.Forms.TextBox totQuant;
        private System.Windows.Forms.ComboBox check_addres;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Dtime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label dateO;
    }
}