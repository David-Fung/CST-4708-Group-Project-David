namespace ProjectD1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTNregister = new System.Windows.Forms.Button();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.BTNlogin = new System.Windows.Forms.Button();
            this.LLaboutus = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LLcontactus = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::ProjectD1.Properties.Resources.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.91045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.08955F));
            this.tableLayoutPanel1.Controls.Add(this.BTNregister, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBpassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBusername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTNlogin, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(274, 179);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTNregister
            // 
            this.BTNregister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNregister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTNregister.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNregister.Location = new System.Drawing.Point(7, 89);
            this.BTNregister.Name = "BTNregister";
            this.BTNregister.Size = new System.Drawing.Size(113, 35);
            this.BTNregister.TabIndex = 5;
            this.BTNregister.Text = "Register";
            this.BTNregister.UseVisualStyleBackColor = false;
            this.BTNregister.Click += new System.EventHandler(this.BTNregister_Click);
            // 
            // TBpassword
            // 
            this.TBpassword.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpassword.Location = new System.Drawing.Point(130, 40);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.PasswordChar = '*';
            this.TBpassword.Size = new System.Drawing.Size(192, 31);
            this.TBpassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // TBusername
            // 
            this.TBusername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBusername.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusername.Location = new System.Drawing.Point(130, 3);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(192, 31);
            this.TBusername.TabIndex = 2;
            // 
            // BTNlogin
            // 
            this.BTNlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTNlogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTNlogin.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNlogin.Location = new System.Drawing.Point(186, 89);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(90, 35);
            this.BTNlogin.TabIndex = 4;
            this.BTNlogin.Text = "Login";
            this.BTNlogin.UseVisualStyleBackColor = false;
            this.BTNlogin.Click += new System.EventHandler(this.BTNlogin_Click);
            // 
            // LLaboutus
            // 
            this.LLaboutus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LLaboutus.AutoSize = true;
            this.LLaboutus.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.LLaboutus.Location = new System.Drawing.Point(76, 5);
            this.LLaboutus.Name = "LLaboutus";
            this.LLaboutus.Size = new System.Drawing.Size(78, 18);
            this.LLaboutus.TabIndex = 6;
            this.LLaboutus.TabStop = true;
            this.LLaboutus.Text = "About Us";
            this.LLaboutus.Click += new System.EventHandler(this.LLaboutus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjectD1.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(342, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel2.BackgroundImage")));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LLaboutus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LLcontactus, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(274, 319);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(335, 28);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LLcontactus
            // 
            this.LLcontactus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LLcontactus.AutoSize = true;
            this.LLcontactus.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.LLcontactus.Location = new System.Drawing.Point(180, 5);
            this.LLcontactus.Name = "LLcontactus";
            this.LLcontactus.Size = new System.Drawing.Size(91, 18);
            this.LLcontactus.TabIndex = 7;
            this.LLcontactus.TabStop = true;
            this.LLcontactus.Text = "Contact Us";
            this.LLcontactus.Click += new System.EventHandler(this.LLcontactus_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(160, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "|";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectD1.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 502);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTNregister;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.Button BTNlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel LLaboutus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel LLcontactus;
        private System.Windows.Forms.Label label3;
    }
}

