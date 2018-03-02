namespace InStat
{
    partial class InStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InStat));
            this.btn_Random = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_AvPlayers = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbx_Pos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.tbx_Level = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.lst_Wildcard = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_ShowPlayers = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.lstBox2 = new System.Windows.Forms.ListBox();
            this.fwArrow = new System.Windows.Forms.PictureBox();
            this.backArrow = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_Total = new System.Windows.Forms.TextBox();
            this.tbx_URL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_AddURL = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fwArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Random
            // 
            this.btn_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Random.Location = new System.Drawing.Point(816, 411);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(136, 23);
            this.btn_Random.TabIndex = 5;
            this.btn_Random.Text = "Random";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "InStat v3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Team A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(868, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Team B";
            // 
            // lst_AvPlayers
            // 
            this.lst_AvPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_AvPlayers.Location = new System.Drawing.Point(450, 78);
            this.lst_AvPlayers.Name = "lst_AvPlayers";
            this.lst_AvPlayers.Size = new System.Drawing.Size(136, 373);
            this.lst_AvPlayers.TabIndex = 9;
            this.lst_AvPlayers.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Available players";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbx_Pos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbx_Email);
            this.panel1.Controls.Add(this.tbx_Level);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbx_Name);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(40, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 246);
            this.panel1.TabIndex = 11;
            // 
            // lbx_Pos
            // 
            this.lbx_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_Pos.FormattingEnabled = true;
            this.lbx_Pos.Items.AddRange(new object[] {
            "Def",
            "Mid",
            "Forward"});
            this.lbx_Pos.Location = new System.Drawing.Point(80, 81);
            this.lbx_Pos.Name = "lbx_Pos";
            this.lbx_Pos.Size = new System.Drawing.Size(246, 24);
            this.lbx_Pos.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Add wildcard";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(83, 223);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Level:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Position:";
            // 
            // tbx_Email
            // 
            this.tbx_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Email.Location = new System.Drawing.Point(82, 186);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(246, 22);
            this.tbx_Email.TabIndex = 4;
            // 
            // tbx_Level
            // 
            this.tbx_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Level.Location = new System.Drawing.Point(82, 134);
            this.tbx_Level.Name = "tbx_Level";
            this.tbx_Level.Size = new System.Drawing.Size(246, 22);
            this.tbx_Level.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name:";
            // 
            // tbx_Name
            // 
            this.tbx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Name.Location = new System.Drawing.Point(82, 27);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(246, 22);
            this.tbx_Name.TabIndex = 0;
            // 
            // lst_Wildcard
            // 
            this.lst_Wildcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Wildcard.Location = new System.Drawing.Point(40, 78);
            this.lst_Wildcard.Name = "lst_Wildcard";
            this.lst_Wildcard.Size = new System.Drawing.Size(344, 108);
            this.lst_Wildcard.TabIndex = 12;
            this.lst_Wildcard.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(154, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Wildcard players";
            // 
            // btn_ShowPlayers
            // 
            this.btn_ShowPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowPlayers.Location = new System.Drawing.Point(628, 411);
            this.btn_ShowPlayers.Name = "btn_ShowPlayers";
            this.btn_ShowPlayers.Size = new System.Drawing.Size(136, 23);
            this.btn_ShowPlayers.TabIndex = 14;
            this.btn_ShowPlayers.Text = "Show players";
            this.btn_ShowPlayers.UseVisualStyleBackColor = true;
            this.btn_ShowPlayers.Click += new System.EventHandler(this.btn_ShowPlayers_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(628, 457);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(136, 23);
            this.btn_Send.TabIndex = 15;
            this.btn_Send.Text = "Send Email";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(816, 457);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(136, 23);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lstBox1
            // 
            this.lstBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.ItemHeight = 16;
            this.lstBox1.Location = new System.Drawing.Point(619, 78);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.Size = new System.Drawing.Size(136, 260);
            this.lstBox1.TabIndex = 17;
            // 
            // lstBox2
            // 
            this.lstBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox2.FormattingEnabled = true;
            this.lstBox2.ItemHeight = 16;
            this.lstBox2.Location = new System.Drawing.Point(832, 78);
            this.lstBox2.Name = "lstBox2";
            this.lstBox2.Size = new System.Drawing.Size(136, 260);
            this.lstBox2.TabIndex = 18;
            // 
            // fwArrow
            // 
            this.fwArrow.Image = ((System.Drawing.Image)(resources.GetObject("fwArrow.Image")));
            this.fwArrow.Location = new System.Drawing.Point(761, 149);
            this.fwArrow.Name = "fwArrow";
            this.fwArrow.Size = new System.Drawing.Size(65, 50);
            this.fwArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fwArrow.TabIndex = 19;
            this.fwArrow.TabStop = false;
            this.fwArrow.Click += new System.EventHandler(this.fwArrow_Click);
            // 
            // backArrow
            // 
            this.backArrow.Image = ((System.Drawing.Image)(resources.GetObject("backArrow.Image")));
            this.backArrow.Location = new System.Drawing.Point(761, 205);
            this.backArrow.Name = "backArrow";
            this.backArrow.Size = new System.Drawing.Size(65, 50);
            this.backArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backArrow.TabIndex = 20;
            this.backArrow.TabStop = false;
            this.backArrow.Click += new System.EventHandler(this.backArrow_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(402, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Total";
            // 
            // tbx_Total
            // 
            this.tbx_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Total.Location = new System.Drawing.Point(450, 460);
            this.tbx_Total.Name = "tbx_Total";
            this.tbx_Total.ReadOnly = true;
            this.tbx_Total.Size = new System.Drawing.Size(136, 22);
            this.tbx_Total.TabIndex = 22;
            // 
            // tbx_URL
            // 
            this.tbx_URL.Location = new System.Drawing.Point(619, 374);
            this.tbx_URL.Name = "tbx_URL";
            this.tbx_URL.Size = new System.Drawing.Size(223, 20);
            this.tbx_URL.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(616, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Image URL";
            // 
            // btn_AddURL
            // 
            this.btn_AddURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddURL.Location = new System.Drawing.Point(877, 371);
            this.btn_AddURL.Name = "btn_AddURL";
            this.btn_AddURL.Size = new System.Drawing.Size(75, 23);
            this.btn_AddURL.TabIndex = 25;
            this.btn_AddURL.Text = "Add";
            this.btn_AddURL.UseVisualStyleBackColor = true;
            this.btn_AddURL.Click += new System.EventHandler(this.btn_AddURL_Click);
            // 
            // InStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 516);
            this.Controls.Add(this.btn_AddURL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbx_URL);
            this.Controls.Add(this.tbx_Total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.backArrow);
            this.Controls.Add(this.fwArrow);
            this.Controls.Add(this.lstBox2);
            this.Controls.Add(this.lstBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_ShowPlayers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lst_Wildcard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_AvPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Random);
            this.MaximizeBox = false;
            this.Name = "InStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fwArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lst_AvPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.TextBox tbx_Level;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lst_Wildcard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_ShowPlayers;
        private System.Windows.Forms.ComboBox lbx_Pos;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.ListBox lstBox2;
        private System.Windows.Forms.PictureBox fwArrow;
        private System.Windows.Forms.PictureBox backArrow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_Total;
        private System.Windows.Forms.TextBox tbx_URL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_AddURL;
    }
}

